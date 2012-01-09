using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZedGraph;
using System.Timers;

namespace PatientSimulator
{
    public partial class PatientMenu : Form
    {
        private Object thisLock = new Object();
        private string GENDER;

        #region ecg 
        ECG ec = new ECG();
        double a_pwav = 0.25;
        double d_pwav = 0.09;
        double t_pwav = 0.16;

        double a_qwav = 0.025;
        double d_qwav = 0.066;
        double t_qwav = 0.166;

        double a_qrswav = 1.6;
        double d_qrswav = 0.11;

        double a_swav = 0.25;
        double d_swav = 0.066;
        double t_swav = 0.09;

        double a_twav = 0.35;
        double d_twav = 0.142;
        double t_twav = 0.2;

        double a_uwav = 0.035;
        double d_uwav = 0.0476;
        double t_uwav = 0.433;       
        double _x;
        #endregion

        private BackgroundWorker bgw;

        private Ticker t1 = new Ticker();      
        private DateTime simulationTime = new DateTime();       

        string startD;
        string startT;
        string stopD;
        string stopT;

        HeartRate hr = new HeartRate();
        BloodPressure bp = new BloodPressure();
        Temperature temp = new Temperature();
        Respiratory rr = new Respiratory();
        SpO2 spo = new SpO2();

        private double hr_current;
        private double bp_current;
        private double rr_current;
        private double spo2_current;
        private double temp_current;

        private double hr_ = 80;
        private double bp_ = 120;
        private double rr_ = 12;
        private double spo2_ = 98;
        private double temp_ = 36.8;        

        private bool MI = false;
        private bool GI = false;
        private bool Stroke = false;
        private bool Normal = true;
        private int captured_time;
        private bool Complete= false;
        bool firstRun = true;

        PointPairList list;

        private Patient aPatient = null; //Stores the value of the patient property
        public Patient patient  //The patient property
        {
            get
            {
                return aPatient;
            }
            set
            {
                aPatient = value;
                txtBox_fName.Text = aPatient.fName;
                txtBox_lName.Text = aPatient.lName;
                txtBox_Title.Text = aPatient.title;               
            }
        }  
        
        public PatientMenu()
        {
            InitializeComponent();

        }    

        private void PatientMenu_Load(object sender, EventArgs e)
        {
            try
            {                
                txtBox_Gender.Text = aPatient.gender;                
                txtBox_Bloodtype.Text = aPatient.bloodtype;                
                txtBox_DOB.Text = aPatient.dob.Date.ToShortDateString();
                GENDER = aPatient.gender;               
                txtBox_CurrentHR.Text = hr_.ToString();
                txtBox_CurrentBP.Text = bp_.ToString();
                txtBox_CurrentTemp.Text = temp_.ToString();
                txtBox_CurrentRR.Text = rr_.ToString();
                txtBox_CurrentSpo2.Text = spo2_.ToString();
                                             
                if (aPatient.title == "Ms" || aPatient.title == "Mrs" || aPatient.title == "Miss")
                {
                    patientPortrait.Image = Properties.Resources.female;
                }
                else
                {
                    patientPortrait.Image = Properties.Resources.male;
                }
                combo_Scenario.SelectedIndex = 0;    

            }
            catch (Exception)
            {
            }

            startDate.Value = System.DateTime.Now;
            stopDate.Value = System.DateTime.Now;
            startTime.Value = System.DateTime.Now;
            stopTime.Value = System.DateTime.Now.AddHours(1);

            #region Graph Configrations (more design of graph stuff)


            hrOverview.ForeColor = Color.Black;
            bpOverview.ForeColor = Color.Black;
            tempOverview.ForeColor = Color.Black;
            rrOverview.ForeColor = Color.Black;
            spo2Overview.ForeColor = Color.Black;

            zedGraphControl1.GraphPane.YAxis.Scale.FontSpec.FontColor = Color.White;
            zedGraphControl1.GraphPane.YAxis.Title.FontSpec.FontColor = Color.White;
            zedGraphControl1.GraphPane.XAxis.Scale.FontSpec.FontColor = Color.White;
            zedGraphControl1.GraphPane.XAxis.Title.FontSpec.FontColor = Color.White;
            zedGraphControl1.GraphPane.YAxis.MajorTic.Color = Color.White;
            zedGraphControl1.GraphPane.YAxis.MinorTic.Color = Color.White;
            zedGraphControl1.GraphPane.XAxis.MajorTic.Color = Color.White;
            zedGraphControl1.GraphPane.XAxis.MinorTic.Color = Color.White;
            zedGraphControl1.GraphPane.Fill = new Fill(Color.Black);
            zedGraphControl1.GraphPane.Chart.Fill.IsVisible = false;
            zedGraphControl1.GraphPane.Title.IsVisible = false;
            zedGraphControl1.GraphPane.XAxis.Title.IsVisible = false;
            zedGraphControl1.GraphPane.YAxis.Title.IsVisible = false;
            zedGraphControl1.GraphPane.Title.FontSpec.FontColor = Color.White;
            zedGraphControl1.GraphPane.XAxis.Title.FontSpec.FontColor = Color.White;
            zedGraphControl1.GraphPane.YAxis.Title.FontSpec.FontColor = Color.White;
            zedGraphControl1.GraphPane.Legend.IsVisible = false;
            //
            //zedGraphControl1.GraphPane.YAxis.MajorGrid.IsVisible = true;
            //zedGraphControl1.GraphPane.YAxis.MajorGrid.Color = Color.White;
            //zedGraphControl1.GraphPane.XAxis.MajorGrid.IsVisible = true;
            //zedGraphControl1.GraphPane.XAxis.MajorGrid.Color = Color.White;
            zedGraphControl1.IsShowHScrollBar = false;

            zedGraphControl2.GraphPane.YAxis.Scale.FontSpec.FontColor = Color.White;
            zedGraphControl2.GraphPane.YAxis.Title.FontSpec.FontColor = Color.White;
            zedGraphControl2.GraphPane.XAxis.Scale.FontSpec.FontColor = Color.White;
            zedGraphControl2.GraphPane.XAxis.Title.FontSpec.FontColor = Color.White;
            zedGraphControl2.GraphPane.YAxis.MajorTic.Color = Color.White;
            zedGraphControl2.GraphPane.YAxis.MinorTic.Color = Color.White;
            zedGraphControl2.GraphPane.XAxis.MajorTic.Color = Color.White;
            zedGraphControl2.GraphPane.XAxis.MinorTic.Color = Color.White;
            zedGraphControl2.GraphPane.Fill = new Fill(Color.Black);
            zedGraphControl2.GraphPane.Chart.Fill.IsVisible = false;
            //zedGraphControl2.GraphPane.Title.Text = "Temperature";
            //zedGraphControl2.GraphPane.YAxis.Title.Text = "Degree Celcius";
            //zedGraphControl2.GraphPane.XAxis.Title.Text = "Time, Seconds";
            zedGraphControl2.GraphPane.Title.IsVisible = false;
            zedGraphControl2.GraphPane.XAxis.Title.IsVisible = false;
            zedGraphControl2.GraphPane.YAxis.Title.IsVisible = false;
            zedGraphControl2.GraphPane.Title.FontSpec.FontColor = Color.White;
            zedGraphControl2.GraphPane.XAxis.Title.FontSpec.FontColor = Color.White;
            zedGraphControl2.GraphPane.YAxis.Title.FontSpec.FontColor = Color.White;
            zedGraphControl2.GraphPane.Legend.IsVisible = false;
            //
            //zedGraphControl2.GraphPane.YAxis.MajorGrid.IsVisible = true;
            //zedGraphControl2.GraphPane.YAxis.MajorGrid.Color = Color.White;
            //zedGraphControl2.GraphPane.YAxis.MinorGrid.IsVisible = true;
            //zedGraphControl2.GraphPane.YAxis.MinorGrid.Color = Color.White;
            //zedGraphControl2.GraphPane.XAxis.MajorGrid.IsVisible = true;
            //zedGraphControl2.GraphPane.XAxis.MajorGrid.Color = Color.White;
            zedGraphControl2.IsShowHScrollBar = false;

            zedGraphControl3.GraphPane.YAxis.Scale.FontSpec.FontColor = Color.White;
            zedGraphControl3.GraphPane.YAxis.Title.FontSpec.FontColor = Color.White;
            zedGraphControl3.GraphPane.XAxis.Scale.FontSpec.FontColor = Color.White;
            zedGraphControl3.GraphPane.XAxis.Title.FontSpec.FontColor = Color.White;
            zedGraphControl3.GraphPane.YAxis.MajorTic.Color = Color.White;
            zedGraphControl3.GraphPane.YAxis.MinorTic.Color = Color.White;
            zedGraphControl3.GraphPane.XAxis.MajorTic.Color = Color.White;
            zedGraphControl3.GraphPane.XAxis.MinorTic.Color = Color.White;
            //   zedGraphControl3.GraphPane.Fill = new Fill(texBrush);
            zedGraphControl3.GraphPane.Fill = new Fill(Color.Black);
            zedGraphControl3.GraphPane.Chart.Fill.IsVisible = false;
            zedGraphControl3.GraphPane.Title.IsVisible = false;
            zedGraphControl3.GraphPane.XAxis.Title.IsVisible = false;
            zedGraphControl3.GraphPane.YAxis.Title.IsVisible = false;
            //  zedGraphControl3.GraphPane.Title.Text = "Blood Pressure";
            //  zedGraphControl3.GraphPane.YAxis.Title.Text = "Systolic";
            //  zedGraphControl3.GraphPane.XAxis.Title.Text = "Time, Seconds";
            zedGraphControl3.GraphPane.Title.FontSpec.FontColor = Color.White;
            zedGraphControl3.GraphPane.XAxis.Title.FontSpec.FontColor = Color.White;
            zedGraphControl3.GraphPane.YAxis.Title.FontSpec.FontColor = Color.White;
            zedGraphControl3.GraphPane.Legend.IsVisible = false;
            //
           // zedGraphControl3.GraphPane.YAxis.MajorGrid.IsVisible = true;
            //zedGraphControl3.GraphPane.YAxis.MajorGrid.Color = Color.White;
            //zedGraphControl3.GraphPane.XAxis.MajorGrid.IsVisible = true;
            //zedGraphControl3.GraphPane.XAxis.MajorGrid.Color = Color.White;
            zedGraphControl3.IsShowHScrollBar = false;

            zedGraphControl4.GraphPane.YAxis.Scale.FontSpec.FontColor = Color.White;
            zedGraphControl4.GraphPane.YAxis.Title.FontSpec.FontColor = Color.White;
            zedGraphControl4.GraphPane.XAxis.Scale.FontSpec.FontColor = Color.White;
            zedGraphControl4.GraphPane.XAxis.Title.FontSpec.FontColor = Color.White;
            zedGraphControl4.GraphPane.YAxis.MajorTic.Color = Color.White;
            zedGraphControl4.GraphPane.YAxis.MinorTic.Color = Color.White;
            zedGraphControl4.GraphPane.XAxis.MajorTic.Color = Color.White;
            zedGraphControl4.GraphPane.XAxis.MinorTic.Color = Color.White;
            zedGraphControl4.GraphPane.Fill = new Fill(Color.Black);
            zedGraphControl4.GraphPane.Chart.Fill.IsVisible = false;
            //zedGraphControl4.GraphPane.Title.Text = "Respiratory Rate";
            //zedGraphControl4.GraphPane.YAxis.Title.Text = "RR per Minute";
            //zedGraphControl4.GraphPane.XAxis.Title.Text = "Time, Seconds";
            zedGraphControl4.GraphPane.Title.IsVisible = false;
            zedGraphControl4.GraphPane.XAxis.Title.IsVisible = false;
            zedGraphControl4.GraphPane.YAxis.Title.IsVisible = false;
            zedGraphControl4.GraphPane.Title.FontSpec.FontColor = Color.White;
            zedGraphControl4.GraphPane.XAxis.Title.FontSpec.FontColor = Color.White;
            zedGraphControl4.GraphPane.YAxis.Title.FontSpec.FontColor = Color.White;
            zedGraphControl4.GraphPane.Legend.IsVisible = false;
            //
            //zedGraphControl4.GraphPane.YAxis.MajorGrid.IsVisible = true;
            //zedGraphControl4.GraphPane.YAxis.MajorGrid.Color = Color.White;
            //zedGraphControl4.GraphPane.XAxis.MajorGrid.IsVisible = true;
            //zedGraphControl4.GraphPane.XAxis.MajorGrid.Color = Color.White;
            zedGraphControl4.IsShowHScrollBar = false;

            zedGraphControl5.GraphPane.YAxis.Scale.FontSpec.FontColor = Color.White;
            zedGraphControl5.GraphPane.YAxis.Title.FontSpec.FontColor = Color.White;
            zedGraphControl5.GraphPane.XAxis.Scale.FontSpec.FontColor = Color.White;
            zedGraphControl5.GraphPane.XAxis.Title.FontSpec.FontColor = Color.White;
            zedGraphControl5.GraphPane.YAxis.MajorTic.Color = Color.White;
            zedGraphControl5.GraphPane.YAxis.MinorTic.Color = Color.White;
            zedGraphControl5.GraphPane.XAxis.MajorTic.Color = Color.White;
            zedGraphControl5.GraphPane.XAxis.MinorTic.Color = Color.White;
            zedGraphControl5.GraphPane.Fill = new Fill(Color.Black);
            zedGraphControl5.GraphPane.Chart.Fill.IsVisible = false;
            // zedGraphControl5.GraphPane.Title.Text = "SpO2";
            // zedGraphControl5.GraphPane.YAxis.Title.Text = "%";
            // zedGraphControl5.GraphPane.XAxis.Title.Text = "Time, Seconds";
            zedGraphControl5.GraphPane.Title.IsVisible = false;
            zedGraphControl5.GraphPane.XAxis.Title.IsVisible = false;
            zedGraphControl5.GraphPane.YAxis.Title.IsVisible = false;
            zedGraphControl5.GraphPane.Title.FontSpec.FontColor = Color.White;
            zedGraphControl5.GraphPane.XAxis.Title.FontSpec.FontColor = Color.White;
            zedGraphControl5.GraphPane.YAxis.Title.FontSpec.FontColor = Color.White;
            zedGraphControl5.GraphPane.Legend.IsVisible = false;
            //
            //zedGraphControl5.GraphPane.YAxis.MajorGrid.IsVisible = true;
            //zedGraphControl5.GraphPane.YAxis.MajorGrid.Color = Color.White;
            //zedGraphControl5.GraphPane.XAxis.MajorGrid.IsVisible = true;
            //zedGraphControl5.GraphPane.XAxis.MajorGrid.Color = Color.White;
            zedGraphControl5.IsShowHScrollBar = false;    
            #endregion

        }

        #region Initite Graphs (mainly design stuff - no functionality here)
        private void initiate_graphs()
        {
            GraphPane heartRatePane = zedGraphControl1.GraphPane;
            GraphPane temperaturePane = zedGraphControl2.GraphPane;
            GraphPane bloodpressurePane = zedGraphControl3.GraphPane;
            GraphPane respiratoryRatePane = zedGraphControl4.GraphPane;
            GraphPane spO2Pane = zedGraphControl5.GraphPane;           

            // Save 1200 points.  At 50 ms sample rate, this is one minute
            // The RollingPointPairList is an efficient storage class that always
            // keeps a rolling set of point data without needing to shift any data values
            //RollingPointPairList list = new RollingPointPairList(2400);
          //  RollingPointPairList list = new RollingPointPairList(1200);
            list = new PointPairList();
            RollingPointPairList list2 = new RollingPointPairList(120);
            RollingPointPairList list3 = new RollingPointPairList(120);
            RollingPointPairList list4 = new RollingPointPairList(120);
            RollingPointPairList list5 = new RollingPointPairList(120);
            // Initially, a curve is added with no data points (list is empty)          
            LineItem curve = heartRatePane.AddCurve("Heart Rate", list, Color.LightGreen, SymbolType.None);
            LineItem curve2 = temperaturePane.AddCurve("Temperature", list2, Color.White, SymbolType.None);
            LineItem curve3 = bloodpressurePane.AddCurve("Blood Pressure", list3, Color.Pink, SymbolType.None);
            LineItem curve4 = respiratoryRatePane.AddCurve("Respiratory Rate", list4, Color.Yellow, SymbolType.None);
            LineItem curve5 = spO2Pane.AddCurve("Spo2", list5, Color.Blue, SymbolType.None);

            curve.Line.IsSmooth = false;

            curve2.Line.IsSmooth = true;
            curve2.Line.SmoothTension = 0.5F;
            //curve2.Line.Width = 2;

            curve3.Line.IsSmooth = true;
            curve3.Line.SmoothTension = 0.5F;
            //curve3.Line.Width = 2;

            curve4.Line.IsSmooth = true;
            curve4.Line.SmoothTension = 0.5F;
            //curve4.Line.Width = 2;

            curve5.Line.IsSmooth = true;
            curve5.Line.SmoothTension = 0.5F;
            //curve5.Line.Width = 2;

            // Just manually control the X axis range so it scrolls continuously
            // instead of discrete step-sized jumps
            //Assuming XAxis.Scale.MinAuto, XAxis.Scale.MajorStepAuto, and XAxis.Scale.MaxAuto


            //heartRatePane.YAxis.Scale.Min = 0;
            heartRatePane.XAxis.Scale.Min = 0;
            heartRatePane.XAxis.Scale.Max = 10;
            //heartRatePane.XAxis.Scale.MinorStep = 1;
            //heartRatePane.XAxis.Scale.MajorStep = 10;
            //heartRatePane.YAxis.Scale.MajorStep = 1;
            heartRatePane.YAxis.Scale.MinAuto = true;
            heartRatePane.YAxis.Scale.MaxAuto = true;

            temperaturePane.YAxis.Scale.Min = 0;
            temperaturePane.XAxis.Scale.Min = 0;
            temperaturePane.XAxis.Scale.Max = 60;
            temperaturePane.XAxis.Scale.MinorStep = 1;
            temperaturePane.XAxis.Scale.MajorStep = 10;
            temperaturePane.YAxis.Scale.MajorStep = 1;
            temperaturePane.YAxis.Scale.MinAuto = true;
            temperaturePane.YAxis.Scale.MaxAuto = true;

            bloodpressurePane.YAxis.Scale.Min = 0;
            bloodpressurePane.XAxis.Scale.Min = 0;
            bloodpressurePane.XAxis.Scale.Max = 60;
            bloodpressurePane.XAxis.Scale.MinorStep = 1;
            bloodpressurePane.XAxis.Scale.MajorStep = 10;
            bloodpressurePane.YAxis.Scale.MinAuto = true;
            bloodpressurePane.YAxis.Scale.MaxAuto = true;


            respiratoryRatePane.YAxis.Scale.Min = 0;
            respiratoryRatePane.XAxis.Scale.Min = 0;
            respiratoryRatePane.XAxis.Scale.Max = 60;
            respiratoryRatePane.YAxis.Scale.MajorStep = 1;
            respiratoryRatePane.XAxis.Scale.MajorStep = 10;
            respiratoryRatePane.YAxis.Scale.MinAuto = true;
            respiratoryRatePane.YAxis.Scale.MaxAuto = true;

            spO2Pane.YAxis.Scale.Min = 0;
            spO2Pane.XAxis.Scale.Min = 0;
            spO2Pane.XAxis.Scale.Max = 60;
            //spO2Pane.XAxis.Scale.MinorStep = 1;
            spO2Pane.XAxis.Scale.MajorStep = 10;
            spO2Pane.YAxis.Scale.MajorStep = 1;
            spO2Pane.YAxis.Scale.MinAuto = true;
            spO2Pane.YAxis.Scale.MaxAuto = true;

            // Scale the axes
            zedGraphControl1.AxisChange();
            zedGraphControl2.AxisChange();
            zedGraphControl3.AxisChange();
            zedGraphControl4.AxisChange();
            zedGraphControl5.AxisChange();
        }
        #endregion

               
        private void btn_StartSimulation_Click(object sender, EventArgs e)
        {
            firstRun = true;            
            startD = startDate.Value.ToShortDateString();
            startT = startTime.Value.ToLongTimeString();
            stopD = stopDate.Value.ToShortDateString();
            stopT = stopTime.Value.ToLongTimeString();
            simulationTime = Convert.ToDateTime(startD + " " + startT);
            

            if (simulationTime.CompareTo(Convert.ToDateTime(stopD + " " + stopT)) <= 0)
            {                              
                startDate.Enabled = false;
                startTime.Enabled = false;
                stopDate.Enabled = false;
                stopTime.Enabled = false;

                ResetGraphs();

                bgw = new BackgroundWorker();
                //mandatory. Otherwise will throw an exception when calling ReportProgress method  
                bgw.WorkerReportsProgress = true;
                //mandatory. Otherwise we would get an InvalidOperationException when trying to cancel the operation  
                bgw.WorkerSupportsCancellation = true;
                bgw.DoWork += bgw_Simulate;
                bgw.RunWorkerCompleted += bgw_Completed;

                groupBox_Graphs.Enabled = true;
                richTextBox_output.Text = "Time\t\tHR\tBP\tTemp\tRR\tSPo2";
                groupBox_Output.Enabled = true;

                btn_StartSimulation.Enabled = false;
                btn_StopSimulation.Enabled = true;

                t1.GlobalTick = 0;                               
                timer1.Interval = 1000;
                timer1.Start();
                Complete = false;
                initiate_graphs();
                btn_StartSimulation.Text = "Start Simulation";
                lblstatus.Visible = true;
                progressBar1.Visible = true;
            }
            else
            {
                MessageBox.Show("The STOP DATE must be greater or equal to the START DATE!");
            }          
  
        }

        public void bgw_Completed(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {        
            if ((e.Cancelled == true))
            {
                Console.WriteLine("ERROR!");
            }

            else if (!(e.Error == null))
            {
               Console.WriteLine("Error: " + e.Error.Message);
            }

            else
            {
                btn_StartSimulation.Text = "Simulating...";
                lblstatus.Text = "Simulating...";
                hrOverview.Text = hr_current.ToString("N0") + "\nBPM";
                bpOverview.Text = bp_current.ToString("N0") + "\nmmHG";
                tempOverview.Text = temp_current.ToString("N1") + "\n°C";
                rrOverview.Text = rr_current.ToString("N1") + "\nBF";
                spo2Overview.Text = spo2_current.ToString("N0") + "\n%";
                richTextBox_output.AppendText("\n" + simulationTime + "\t" + hr_current.ToString("N0") + "\t" + bp_current.ToString("N0") + "\t" + temp_current.ToString("N1") + "\t" + rr_current.ToString("N0") + "\t" + spo2_current.ToString("N0"));         
                
            }

            if (Complete == true)
            {
                btn_StartSimulation.Text = "Start Simulation";
            }     
         }
       
                          
        private void btn_StopSimulation_Click(object sender, EventArgs e)
        {
            startDate.Enabled = true;
            startTime.Enabled = true;
            stopDate.Enabled = true;
            stopTime.Enabled = true;

            btn_StartSimulation.Text = "Start Simulation";
            lblstatus.Text = "Initialising...";

            btn_StartSimulation.Enabled = true;
            btn_StopSimulation.Enabled = false;
            timer1.Enabled = false;           
            bgw.Dispose();
            lblstatus.Visible = false;
            progressBar1.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (bgw.IsBusy != true)
            {
                bgw.RunWorkerAsync();
                
                
                #region Output to Statistical Display
                if (firstRun == true)
                {
                    btn_StartSimulation.Text = "Initialising...";
                    lblstatus.Text = "Initialising...";
                }
              
                if (Normal == true)
                {
                    combo_Scenario.SelectedIndex = 0;
                }

                if (Complete == true)
                {
                    timer1.Stop();               
                    bgw.Dispose();   

                    startDate.Enabled = true;
                    startTime.Enabled = true;
                    stopDate.Enabled = true;
                    stopTime.Enabled = true;

                    btn_StartSimulation.Enabled = true;
                    btn_StartSimulation.Text = "Start Simulation";
                    btn_StopSimulation.Enabled = false;
                    lblstatus.Visible = false;
                    progressBar1.Visible = false;                           
                }
                #endregion
            }            
        }

        private void bgw_Simulate(object source, DoWorkEventArgs e)
        {
            int time = (System.Convert.ToInt32(t1.GlobalTick)); //used for x axis on zedgraph          
            #region Graph Curve Configurations

            // Make sure that the curvelist has at least one curve
            if (zedGraphControl1.GraphPane.CurveList.Count <= 0)
                return;

            if (zedGraphControl2.GraphPane.CurveList.Count <= 0)
                return;

            if (zedGraphControl3.GraphPane.CurveList.Count <= 0)
                return;

            if (zedGraphControl4.GraphPane.CurveList.Count <= 0)
                return;

            if (zedGraphControl5.GraphPane.CurveList.Count <= 0)
                return;


            // Get the first CurveItem in the graph
            LineItem curve = zedGraphControl1.GraphPane.CurveList[0] as LineItem;
            if (curve == null)
                return;

            LineItem curve2 = zedGraphControl2.GraphPane.CurveList[0] as LineItem;
            if (curve2 == null)
                return;

            LineItem curve3 = zedGraphControl3.GraphPane.CurveList[0] as LineItem;
            if (curve3 == null)
                return;

            LineItem curve4 = zedGraphControl4.GraphPane.CurveList[0] as LineItem;
            if (curve4 == null)
                return;

            LineItem curve5 = zedGraphControl5.GraphPane.CurveList[0] as LineItem;
            if (curve5 == null)
                return;


            // Get the PointPairList
            IPointListEdit list = curve.Points as IPointListEdit;
            // If this is null, it means the reference at curve.Points does not
            // support IPointListEdit, so we won't be able to modify it
            if (list == null)
                return;

            IPointListEdit list2 = curve2.Points as IPointListEdit;
            if (list2 == null)
                return;

            IPointListEdit list3 = curve3.Points as IPointListEdit;
            if (list3 == null)
                return;

            IPointListEdit list4 = curve4.Points as IPointListEdit;
            if (list4 == null)
                return;

            IPointListEdit list5 = curve5.Points as IPointListEdit;
            if (list5 == null)
                return;

            #endregion
            #region Graph Scaling
          Scale xScale1 = zedGraphControl1.GraphPane.XAxis.Scale;
            if ((time + _x) > xScale1.Max - xScale1.MajorStep)
           {
             xScale1.Max = (time + _x) + xScale1.MajorStep;
             xScale1.Min = xScale1.Max - 10.0;
           }

            Scale xScale2 = zedGraphControl2.GraphPane.XAxis.Scale;
            if (time > xScale2.Max - xScale2.MajorStep)
            {
                xScale2.Max = time + xScale2.MajorStep;
                xScale2.Min = xScale2.Max - 60.0;
            }

            Scale xScale3 = zedGraphControl3.GraphPane.XAxis.Scale;
            if (time > xScale3.Max - xScale3.MajorStep)
            {
                xScale3.Max = time + xScale3.MajorStep;
                xScale3.Min = xScale3.Max - 60.0;
            }

            Scale xScale4 = zedGraphControl4.GraphPane.XAxis.Scale;
            if (time > xScale4.Max - xScale4.MajorStep)
            {
                xScale4.Max = time + xScale4.MajorStep;
                xScale4.Min = xScale4.Max - 60.0;
            }

            Scale xScale5 = zedGraphControl5.GraphPane.XAxis.Scale;
            if (time > xScale5.Max - xScale5.MajorStep)
            {
                xScale5.Max = time + xScale5.MajorStep;
                xScale5.Min = xScale5.Max - 60.0;
            }

            // Make sure the Y axis is rescaled to accommodate actual data
            zedGraphControl1.AxisChange();
            // Force a redraw
            zedGraphControl1.Invalidate();

            zedGraphControl2.AxisChange();
            zedGraphControl2.Invalidate();

            zedGraphControl3.AxisChange();
            zedGraphControl3.Invalidate();

            zedGraphControl4.AxisChange();
            zedGraphControl4.Invalidate();

            zedGraphControl5.AxisChange();
            zedGraphControl5.Invalidate();
            #endregion
            #region scenario check
            if (MI == true)
            {
                sim_MyocardialInfarction();
            }

            if (GI == true)
            {
                sim_GI();
            }

            if (Stroke == true)
            {
                sim_Stroke();
            }
            #endregion
            #region Generation of Physiological Vital Signs
            hr_current = hr.Simulate(4, hr_);
            bp_current = bp.Simulate(10, bp_);
            temp_current = temp.Simulate(0.01, temp_);
            rr_current = rr.Simulate(1, rr_);
            spo2_current = spo.Simulate(0.6, spo2_);  

            if (firstRun == true)
            {
                //do nothing
            }
            else
            {
                double li = 30.0 / hr_current;
                double range = 0.01;

                while (range < 1)
                {
                    double ecg = (ec.P_WAV(range, a_pwav, d_pwav, t_pwav, li) + ec.QRS_WAV(range, a_qrswav, d_qrswav, li) + ec.T_WAV(range, a_twav, d_twav, t_twav, li) + ec.S_WAV(range, a_swav, d_swav, t_swav, li) + ec.Q_WAV(range, a_qwav, d_qwav, t_qwav, li) + ec.U_WAV(range, a_uwav, d_uwav, t_uwav, li));

                    range += 0.01;

                    _x = Convert.ToDouble(Math.Round(range, 4));
                    double _y = Convert.ToDouble(ecg);
              
                    list.Add(_x + time, _y);    
                }         
  
            list3.Add(time, Math.Round(bp_current, 0));
            list2.Add(time, Math.Round(temp_current, 1));
            list4.Add(time, Math.Round(rr_current, 0));
            list5.Add(time, Math.Round(spo2_current, 0));
            }
            #endregion
          
            t1.GlobalTick++;        
            simulationTime = simulationTime.AddSeconds(1);
            firstRun = false;            
            if (simulationTime > Convert.ToDateTime(stopD + " " + stopT))
            {
                Complete = true;          
            }
        }

        #region add minus buttons
        private void btn_MinusHR_Click(object sender, EventArgs e)
        {            
            hr_ -= 1;
            txtBox_CurrentHR.Text = hr_.ToString();

        }

        private void btn_AddHR_Click(object sender, EventArgs e)
        {
            hr_ += 1;
            txtBox_CurrentHR.Text = hr_.ToString();
        }

        private void btn_MinusBP_Click(object sender, EventArgs e)
        {
            bp_ -= 1;
            txtBox_CurrentBP.Text = bp_.ToString();
        }

        private void btn_AddBP_Click(object sender, EventArgs e)
        {
            bp_ += 1;
            txtBox_CurrentBP.Text = bp_.ToString();
        }

        private void btn_MinusTemp_Click(object sender, EventArgs e)
        {
            temp_ -= 0.1;
            txtBox_CurrentTemp.Text = temp_.ToString();
        }

        private void btn_AddTemp_Click(object sender, EventArgs e)
        {
            temp_ += 0.1;
            txtBox_CurrentTemp.Text = temp_.ToString();
        }

        private void btn_MinusRR_Click(object sender, EventArgs e)
        {
            rr_ -= 1;
            txtBox_CurrentRR.Text = rr_.ToString();
        }

        private void btn_AddRR_Click(object sender, EventArgs e)
        {
            rr_ += 1;
            txtBox_CurrentRR.Text = rr_.ToString();
        }

        private void btn_MinusSpo2_Click(object sender, EventArgs e)
        {
            spo2_ -= 1;
            txtBox_CurrentSpo2.Text = spo2_.ToString();
        }

        private void btn_AddSpo2_Click(object sender, EventArgs e)
        {
            spo2_ += 1;
            txtBox_CurrentSpo2.Text = spo2_.ToString();
        }
        #endregion

        private void ResetGraphs()
        {
            zedGraphControl1.GraphPane.CurveList.Clear();
            zedGraphControl2.GraphPane.CurveList.Clear();
            zedGraphControl3.GraphPane.CurveList.Clear();
            zedGraphControl4.GraphPane.CurveList.Clear();
            zedGraphControl5.GraphPane.CurveList.Clear();
        }

        private void combo_Scenario_SelectedIndexChanged(object sender, EventArgs e)
        {
            captured_time = Convert.ToInt32(t1.GlobalTick);

            if (combo_Scenario.SelectedIndex.Equals(0))
            {
                Normal = true;
                sim_Normal();
                MI = false;
                GI = false;
                Stroke = false;
            }
            if (combo_Scenario.SelectedIndex.Equals(1))
            {
                Normal = false;
                MI = true;
                GI = false;
                Stroke = false;
            }
            else if (combo_Scenario.SelectedIndex.Equals(2))
            {
                Normal = false;
                MI = false;
                GI = false;
                Stroke = true;
            }
            else if (combo_Scenario.SelectedIndex.Equals(3))
            {
                Normal = false;
                Stroke = false;
                MI = false;
                GI = true;
            }
        }

        #region Scripts for simulation of scenarios
        private void sim_Normal()
        {
            hr_ = 80;
            bp_ = 120;
            rr_ = 12;
            spo2_ = 98;
            temp_ = 36.8;
 
        }

        private void sim_MyocardialInfarction()
        {
            if ((Convert.ToInt32(t1.GlobalTick) - captured_time) <= 24)
            {
                bp_ = 160;
                hr_ = 120;
                temp_ = 37;
                spo2_ = 96;
                rr_ = 12;            
            }
            else if ((Convert.ToInt32(t1.GlobalTick) - captured_time) > 24 && (Convert.ToInt32(t1.GlobalTick) - captured_time) <= 48)
            {
                bp_ = 160;
                hr_ = 110;
                temp_ = 36.9;
                spo2_ = 96;
                rr_ = 14;
            }
            else if ((Convert.ToInt32(t1.GlobalTick) - captured_time) > 48 && (Convert.ToInt32(t1.GlobalTick) - captured_time) <= 72)
            {
                bp_ = 160;
                hr_ = 110;
                temp_ = 36.9;
                spo2_ = 96;
                rr_ = 16;             
            }
            else if ((Convert.ToInt32(t1.GlobalTick) - captured_time) > 72 && (Convert.ToInt32(t1.GlobalTick) - captured_time) <= 96)
            {
                bp_ = 120;
                hr_ = 120;
                temp_ = 36.9;
                spo2_ = 96;
                rr_ = 18;
            }
            else if ((Convert.ToInt32(t1.GlobalTick) - captured_time) > 96 && (Convert.ToInt32(t1.GlobalTick) - captured_time) <= 120)
            {
                bp_ = 90;
                hr_ = 40;
                temp_ = 36.9;
                spo2_ = 99;
                rr_ = 18;              
            }
            else if ((Convert.ToInt32(t1.GlobalTick) - captured_time) > 120 && (Convert.ToInt32(t1.GlobalTick) - captured_time) <= 144)
            {
                bp_ = 80;
                hr_ = 50;
                temp_ = 36.9;
                spo2_ = 99;
                rr_ = 18;
            }

            else if ((Convert.ToInt32(t1.GlobalTick) - captured_time) > 144 && (Convert.ToInt32(t1.GlobalTick) - captured_time) <= 168)
            {
                bp_ = 80;
                hr_ = 50;
                temp_ = 36.9;
                spo2_ = 99;
                rr_ = 16;               
            }
            else if ((Convert.ToInt32(t1.GlobalTick) - captured_time) > 168 && (Convert.ToInt32(t1.GlobalTick) - captured_time) <= 240)
            {
                bp_ = 80;
                hr_ = 48;
                temp_ = 36.9;
                spo2_ = 99;
                rr_ = 14;
            }
            else
            {
                Normal = true;
                sim_Normal();                    
                MI = false;
            }

        }

        private void sim_Stroke()
        {
            if ((Convert.ToInt32(t1.GlobalTick) - captured_time) <= 24)
            {
                bp_ = 225;
                hr_ = 60;
                temp_ = 37;
                spo2_ = 97;
                rr_ = 12;
            }
            else if ((Convert.ToInt32(t1.GlobalTick) - captured_time) > 24 && (Convert.ToInt32(t1.GlobalTick) - captured_time) <= 72)
            {
                bp_ = 230;
                hr_ = 60;
                temp_ = 37;
                spo2_ = 98;
                rr_ = 7;              
            }
            else if ((Convert.ToInt32(t1.GlobalTick) - captured_time) > 72 && (Convert.ToInt32(t1.GlobalTick) - captured_time) <= 96)
            {
                bp_ = 235;
                hr_ = 60;
                temp_ = 37;
                spo2_ = 97;
                rr_ = 7;
            }
            else
            {
                Normal = true;
                sim_Normal();                         
                Stroke = false;
            }


        }

        private void sim_GI()
        {
            if ((Convert.ToInt32(t1.GlobalTick) - captured_time) <= 72)
            {
                bp_ = 100;
                hr_ = 100;
                temp_ = 36.8;
                spo2_ = 98;
                rr_ = 12;               
            }
            else if ((Convert.ToInt32(t1.GlobalTick) - captured_time) > 72 && (Convert.ToInt32(t1.GlobalTick) - captured_time) <= 96)
            {
                bp_ = 90;
                hr_ = 98;
                temp_ = 36.8;
                spo2_ = 98;
                rr_ = 12;              

            }
            else if ((Convert.ToInt32(t1.GlobalTick) - captured_time) > 96 && (Convert.ToInt32(t1.GlobalTick) - captured_time) <= 120)
            {
                bp_ = 90;
                hr_ = 120;
                temp_ = 36.8;
                spo2_ = 96;
                rr_ = 16;             
            }
            else if ((Convert.ToInt32(t1.GlobalTick) - captured_time) > 120 && (Convert.ToInt32(t1.GlobalTick) - captured_time) <= 144)
            {
                bp_ = 100;
                hr_ = 100;
                temp_ = 36.7;
                spo2_ = 99;
                rr_ = 12;              
            }
            else if ((Convert.ToInt32(t1.GlobalTick) - captured_time) > 144 && (Convert.ToInt32(t1.GlobalTick) - captured_time) <= 168)
            {
                bp_ = 104;
                hr_ = 96;
                temp_ = 36.6;
                spo2_ = 99;
                rr_ = 12;         
            }
            else if ((Convert.ToInt32(t1.GlobalTick) - captured_time) > 168 && (Convert.ToInt32(t1.GlobalTick) - captured_time) <= 216)
            {
                bp_ = 110;
                hr_ = 90;
                temp_ = 36.7;
                spo2_ = 99;
                rr_ = 12;
              
            }
            else if ((Convert.ToInt32(t1.GlobalTick) - captured_time) > 216 && (Convert.ToInt32(t1.GlobalTick) - captured_time) <= 240)
            {
                bp_ = 110;
                hr_ = 88;
                temp_ = 36.7;
                spo2_ = 99;
                rr_ = 12;                
            }
            else
            {
                Normal = true;
                sim_Normal();                    
                GI = false;
            }
        }    
        #endregion                  
      
        }
    }

