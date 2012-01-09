using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace PatientSimulator
{
    public partial class MainMenu : Form
    {        
        private PatientMenu p_menu;
        private BackgroundWorker bgw;
        private bool loading = false;
        private List<Patient> patientList = new List<Patient>();
        private int index;
                       
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            CreatePatients();
            PopulateListBox();           
        }

        private void CreatePatients()
        {
            //Create some virtual patients for demonstration purposes
            Patient p1 = new Patient();
            p1.title = "Mr";
            p1.fName = "John";
            p1.lName = "Smith";
            p1.patientId = "11223344";         
            p1.gender = "Male";
            p1.bloodtype = "O";
            p1.dob = Convert.ToDateTime("01/01/1982");

            Patient p2 = new Patient();
            p2.title = "Mrs";
            p2.fName = "Jane";
            p2.lName = "Doe";
            p2.gender = "Female";
            p2.bloodtype = "AB";
            p2.patientId = "11223355";            
            p2.dob = Convert.ToDateTime("02/02/1971");

            Patient p3 = new Patient();
            p3.title = "Mr";
            p3.fName = "James";
            p3.lName = "Smith";
            p3.gender = "Male";
            p3.bloodtype = "A";
            p3.patientId = "11223366";
            p3.dob = Convert.ToDateTime("15/09/1987");

            Patient p4 = new Patient();
            p4.title = "Mrs";
            p4.fName = "Kate";
            p4.lName = "Doe";
            p4.gender = "Female";
            p4.bloodtype = "O";
            p4.patientId = "11223377";
            p4.dob = Convert.ToDateTime("09/11/1965");

            patientList.Add(p1);
            patientList.Add(p2);
            patientList.Add(p3);
            patientList.Add(p4);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loading == true)
            {
            }
            else
            {
                btn_LoadPatient.Text = "Load Patient";
            }
        }


        private void PopulateListBox()
        {      
            int count = 1;
            foreach (Patient p in patientList)
            {
                listBox1.Items.Add(count + " :" + p.title + " " + p.fName + " " + p.lName + " (Patient ID: " + p.patientId + ")");
                count++;
            }
        }       
     
        public delegate void LoadPatientDelegate(string btn_Text);
        private void btn_LoadPatient_Click(object sender, EventArgs e)
        {           
            if (listBox1.SelectedIndex < 0)
            {
                MessageBox.Show("Choose a Patient from list");
            }
            else
            {
                progressBar1.Visible = true;

                bgw = new BackgroundWorker();
                //mandatory. Otherwise will throw an exception when calling ReportProgress method  
                bgw.WorkerReportsProgress = true;
                //mandatory. Otherwise we would get an InvalidOperationException when trying to cancel the operation  
                bgw.WorkerSupportsCancellation = true;
                bgw.DoWork += bgw_LoadPatient;
                bgw.ProgressChanged += bgw_ProgressChanged;
                bgw.RunWorkerCompleted += bgw_Completed;
                bgw.RunWorkerAsync();
                index = listBox1.SelectedIndex;
                btn_LoadPatient.Text = "Loading...";
                btn_LoadPatient.Enabled = false;               
            }
        }

        private void bgw_LoadPatient(object source, DoWorkEventArgs e)
        {          
                PatientMenu match;
                bool isOpen = false;

                Patient myPatient = patientList.ElementAt(index);
                               
                bgw.ReportProgress(10);
                foreach (Form f in Application.OpenForms)
                {
                    if (f is PatientMenu)
                    {
                        match = (PatientMenu)f;

                        if (match.patient.patientId == myPatient.patientId)
                        {
                            isOpen = true;
                            SetText("Already Loaded!");
                            bgw.Dispose();
                            bgw.ReportProgress(100);
                            break;                            
                        }
                    }
                }
                bgw.ReportProgress(30);
                if (!isOpen)
                {
                    //Note: Thread.Sleep is only used to demonstrate that GUI 
                    //      remains responsive during "Loading".                    
                    loading = true;                               
                    p_menu = new PatientMenu();
                    p_menu.patient = myPatient;
                    p_menu.Text = "Patient ID: " + myPatient.patientId;
                    Thread.Sleep(1000);
                    bgw.ReportProgress(40);
                    Thread.Sleep(1000);
                    bgw.ReportProgress(50);
                    Thread.Sleep(1000);
                    bgw.ReportProgress(80);
                    Thread.Sleep(1000);     
                    SetText("Load Patient");                    
                    bgw.ReportProgress(100);
                    p_menu.ShowDialog();                                                                          
                }
            }
                  

        private void SetText(string btn_Text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.btn_LoadPatient.InvokeRequired) 
            {
                LoadPatientDelegate d = new LoadPatientDelegate(SetText);
                this.Invoke(d, new object[] { btn_Text });
            }
            else
            {
                this.btn_LoadPatient.Enabled = true;
                this.btn_LoadPatient.Text = btn_Text;
                loading = false;
                bgw.Dispose();
                progressBar1.Visible = false;
                progressBar1.Value = 0;
            }
        }

        private void bgw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
           progressBar1.Value = e.ProgressPercentage;
        }

        private void bgw_Completed(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            try
            {
                bgw.Dispose();
                progressBar1.Visible = false;
                progressBar1.Value = 0;
            }
            catch (Exception)
            {
            }
        }
    }
}

