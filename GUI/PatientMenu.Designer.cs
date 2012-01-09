namespace PatientSimulator
{
    partial class PatientMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientMenu));
            this.label12 = new System.Windows.Forms.Label();
            this.txtBox_Title = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBox_lName = new System.Windows.Forms.TextBox();
            this.txtBox_fName = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox_Gender = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBox_Bloodtype = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBox_DOB = new System.Windows.Forms.TextBox();
            this.patientPortrait = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.combo_Scenario = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_AddRR = new System.Windows.Forms.Button();
            this.txtBox_CurrentRR = new System.Windows.Forms.TextBox();
            this.btn_AddTemp = new System.Windows.Forms.Button();
            this.btn_MinusRR = new System.Windows.Forms.Button();
            this.btn_AddSpo2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_MinusSpo2 = new System.Windows.Forms.Button();
            this.btn_MinusTemp = new System.Windows.Forms.Button();
            this.txtBox_CurrentSpo2 = new System.Windows.Forms.TextBox();
            this.txtBox_CurrentTemp = new System.Windows.Forms.TextBox();
            this.btn_AddHR = new System.Windows.Forms.Button();
            this.txtBox_CurrentHR = new System.Windows.Forms.TextBox();
            this.txtBox_CurrentBP = new System.Windows.Forms.TextBox();
            this.btn_MinusHR = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_AddBP = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_MinusBP = new System.Windows.Forms.Button();
            this.groupBox_Graphs = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.zedGraphControl3 = new ZedGraph.ZedGraphControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.zedGraphControl2 = new ZedGraph.ZedGraphControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.zedGraphControl4 = new ZedGraph.ZedGraphControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.zedGraphControl5 = new ZedGraph.ZedGraphControl();
            this.groupBox_Output = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.spo2Overview = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.rrOverview = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.tempOverview = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.bpOverview = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.hrOverview = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.richTextBox_output = new System.Windows.Forms.RichTextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.start_Label = new System.Windows.Forms.Label();
            this.stopTime = new System.Windows.Forms.DateTimePicker();
            this.stopDate = new System.Windows.Forms.DateTimePicker();
            this.startTime = new System.Windows.Forms.DateTimePicker();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.btn_StopSimulation = new System.Windows.Forms.Button();
            this.btn_StartSimulation = new System.Windows.Forms.Button();
            this.lblstatus = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientPortrait)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox_Graphs.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.groupBox_Output.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(27, 125);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 13);
            this.label12.TabIndex = 102;
            this.label12.Text = "Title:";
            // 
            // txtBox_Title
            // 
            this.txtBox_Title.Location = new System.Drawing.Point(27, 141);
            this.txtBox_Title.MaxLength = 327679;
            this.txtBox_Title.Name = "txtBox_Title";
            this.txtBox_Title.ReadOnly = true;
            this.txtBox_Title.Size = new System.Drawing.Size(100, 20);
            this.txtBox_Title.TabIndex = 101;
            this.txtBox_Title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 100;
            this.label9.Text = "Forname(s):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 99;
            this.label7.Text = "Surname:";
            // 
            // txtBox_lName
            // 
            this.txtBox_lName.Location = new System.Drawing.Point(27, 219);
            this.txtBox_lName.Name = "txtBox_lName";
            this.txtBox_lName.ReadOnly = true;
            this.txtBox_lName.Size = new System.Drawing.Size(100, 20);
            this.txtBox_lName.TabIndex = 98;
            this.txtBox_lName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBox_fName
            // 
            this.txtBox_fName.Location = new System.Drawing.Point(27, 180);
            this.txtBox_fName.Name = "txtBox_fName";
            this.txtBox_fName.ReadOnly = true;
            this.txtBox_fName.Size = new System.Drawing.Size(100, 20);
            this.txtBox_fName.TabIndex = 97;
            this.txtBox_fName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 105;
            this.label1.Text = "Gender:";
            // 
            // txtBox_Gender
            // 
            this.txtBox_Gender.Location = new System.Drawing.Point(139, 177);
            this.txtBox_Gender.Name = "txtBox_Gender";
            this.txtBox_Gender.ReadOnly = true;
            this.txtBox_Gender.Size = new System.Drawing.Size(100, 20);
            this.txtBox_Gender.TabIndex = 104;
            this.txtBox_Gender.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 109;
            this.label2.Text = "Blood Type:";
            // 
            // txtBox_Bloodtype
            // 
            this.txtBox_Bloodtype.Location = new System.Drawing.Point(139, 219);
            this.txtBox_Bloodtype.Name = "txtBox_Bloodtype";
            this.txtBox_Bloodtype.ReadOnly = true;
            this.txtBox_Bloodtype.Size = new System.Drawing.Size(100, 20);
            this.txtBox_Bloodtype.TabIndex = 108;
            this.txtBox_Bloodtype.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 111;
            this.label3.Text = "Date of Birth:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBox_DOB);
            this.groupBox1.Controls.Add(this.patientPortrait);
            this.groupBox1.Controls.Add(this.txtBox_fName);
            this.groupBox1.Controls.Add(this.txtBox_lName);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtBox_Title);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtBox_Bloodtype);
            this.groupBox1.Controls.Add(this.txtBox_Gender);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 265);
            this.groupBox1.TabIndex = 116;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Patient Details";
            // 
            // txtBox_DOB
            // 
            this.txtBox_DOB.Location = new System.Drawing.Point(138, 141);
            this.txtBox_DOB.Name = "txtBox_DOB";
            this.txtBox_DOB.ReadOnly = true;
            this.txtBox_DOB.Size = new System.Drawing.Size(100, 20);
            this.txtBox_DOB.TabIndex = 118;
            this.txtBox_DOB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // patientPortrait
            // 
            this.patientPortrait.Image = global::PatientSimulator.Properties.Resources.male;
            this.patientPortrait.Location = new System.Drawing.Point(71, 16);
            this.patientPortrait.Name = "patientPortrait";
            this.patientPortrait.Size = new System.Drawing.Size(103, 103);
            this.patientPortrait.TabIndex = 115;
            this.patientPortrait.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.combo_Scenario);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btn_AddRR);
            this.groupBox2.Controls.Add(this.txtBox_CurrentRR);
            this.groupBox2.Controls.Add(this.btn_AddTemp);
            this.groupBox2.Controls.Add(this.btn_MinusRR);
            this.groupBox2.Controls.Add(this.btn_AddSpo2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btn_MinusSpo2);
            this.groupBox2.Controls.Add(this.btn_MinusTemp);
            this.groupBox2.Controls.Add(this.txtBox_CurrentSpo2);
            this.groupBox2.Controls.Add(this.txtBox_CurrentTemp);
            this.groupBox2.Controls.Add(this.btn_AddHR);
            this.groupBox2.Controls.Add(this.txtBox_CurrentHR);
            this.groupBox2.Controls.Add(this.txtBox_CurrentBP);
            this.groupBox2.Controls.Add(this.btn_MinusHR);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.btn_AddBP);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.btn_MinusBP);
            this.groupBox2.Location = new System.Drawing.Point(13, 284);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(254, 167);
            this.groupBox2.TabIndex = 117;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vital Sign Parameters";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(136, 124);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 115;
            this.label11.Text = "Scenario:";
            // 
            // combo_Scenario
            // 
            this.combo_Scenario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_Scenario.FormattingEnabled = true;
            this.combo_Scenario.Items.AddRange(new object[] {
            "Normal",
            "MI",
            "Stroke",
            "GI"});
            this.combo_Scenario.Location = new System.Drawing.Point(139, 138);
            this.combo_Scenario.Name = "combo_Scenario";
            this.combo_Scenario.Size = new System.Drawing.Size(107, 21);
            this.combo_Scenario.TabIndex = 114;
            this.combo_Scenario.SelectedIndexChanged += new System.EventHandler(this.combo_Scenario_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(6, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 104;
            this.label4.Text = "HR:";
            // 
            // btn_AddRR
            // 
            this.btn_AddRR.Location = new System.Drawing.Point(217, 90);
            this.btn_AddRR.Name = "btn_AddRR";
            this.btn_AddRR.Size = new System.Drawing.Size(30, 20);
            this.btn_AddRR.TabIndex = 110;
            this.btn_AddRR.Text = "+";
            this.btn_AddRR.UseVisualStyleBackColor = false;
            this.btn_AddRR.Click += new System.EventHandler(this.btn_AddRR_Click);
            // 
            // txtBox_CurrentRR
            // 
            this.txtBox_CurrentRR.Location = new System.Drawing.Point(138, 91);
            this.txtBox_CurrentRR.Name = "txtBox_CurrentRR";
            this.txtBox_CurrentRR.ReadOnly = true;
            this.txtBox_CurrentRR.Size = new System.Drawing.Size(47, 20);
            this.txtBox_CurrentRR.TabIndex = 109;
            this.txtBox_CurrentRR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_AddTemp
            // 
            this.btn_AddTemp.Location = new System.Drawing.Point(217, 38);
            this.btn_AddTemp.Name = "btn_AddTemp";
            this.btn_AddTemp.Size = new System.Drawing.Size(30, 20);
            this.btn_AddTemp.TabIndex = 99;
            this.btn_AddTemp.Text = "+";
            this.btn_AddTemp.UseVisualStyleBackColor = false;
            this.btn_AddTemp.Click += new System.EventHandler(this.btn_AddTemp_Click);
            // 
            // btn_MinusRR
            // 
            this.btn_MinusRR.Location = new System.Drawing.Point(188, 90);
            this.btn_MinusRR.Name = "btn_MinusRR";
            this.btn_MinusRR.Size = new System.Drawing.Size(30, 20);
            this.btn_MinusRR.TabIndex = 111;
            this.btn_MinusRR.Text = "-";
            this.btn_MinusRR.UseVisualStyleBackColor = false;
            this.btn_MinusRR.Click += new System.EventHandler(this.btn_MinusRR_Click);
            // 
            // btn_AddSpo2
            // 
            this.btn_AddSpo2.Location = new System.Drawing.Point(88, 139);
            this.btn_AddSpo2.Name = "btn_AddSpo2";
            this.btn_AddSpo2.Size = new System.Drawing.Size(30, 20);
            this.btn_AddSpo2.TabIndex = 102;
            this.btn_AddSpo2.Text = "+";
            this.btn_AddSpo2.UseVisualStyleBackColor = false;
            this.btn_AddSpo2.Click += new System.EventHandler(this.btn_AddSpo2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(135, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 107;
            this.label5.Text = "Respiration:";
            // 
            // btn_MinusSpo2
            // 
            this.btn_MinusSpo2.Location = new System.Drawing.Point(59, 139);
            this.btn_MinusSpo2.Name = "btn_MinusSpo2";
            this.btn_MinusSpo2.Size = new System.Drawing.Size(30, 20);
            this.btn_MinusSpo2.TabIndex = 103;
            this.btn_MinusSpo2.Text = "-";
            this.btn_MinusSpo2.UseVisualStyleBackColor = false;
            this.btn_MinusSpo2.Click += new System.EventHandler(this.btn_MinusSpo2_Click);
            // 
            // btn_MinusTemp
            // 
            this.btn_MinusTemp.Location = new System.Drawing.Point(188, 38);
            this.btn_MinusTemp.Name = "btn_MinusTemp";
            this.btn_MinusTemp.Size = new System.Drawing.Size(30, 20);
            this.btn_MinusTemp.TabIndex = 100;
            this.btn_MinusTemp.Text = "-";
            this.btn_MinusTemp.UseVisualStyleBackColor = false;
            this.btn_MinusTemp.Click += new System.EventHandler(this.btn_MinusTemp_Click);
            // 
            // txtBox_CurrentSpo2
            // 
            this.txtBox_CurrentSpo2.Location = new System.Drawing.Point(9, 140);
            this.txtBox_CurrentSpo2.Name = "txtBox_CurrentSpo2";
            this.txtBox_CurrentSpo2.ReadOnly = true;
            this.txtBox_CurrentSpo2.Size = new System.Drawing.Size(47, 20);
            this.txtBox_CurrentSpo2.TabIndex = 101;
            this.txtBox_CurrentSpo2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBox_CurrentTemp
            // 
            this.txtBox_CurrentTemp.Location = new System.Drawing.Point(138, 39);
            this.txtBox_CurrentTemp.Name = "txtBox_CurrentTemp";
            this.txtBox_CurrentTemp.ReadOnly = true;
            this.txtBox_CurrentTemp.Size = new System.Drawing.Size(47, 20);
            this.txtBox_CurrentTemp.TabIndex = 98;
            this.txtBox_CurrentTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_AddHR
            // 
            this.btn_AddHR.Location = new System.Drawing.Point(88, 39);
            this.btn_AddHR.Name = "btn_AddHR";
            this.btn_AddHR.Size = new System.Drawing.Size(30, 19);
            this.btn_AddHR.TabIndex = 92;
            this.btn_AddHR.Text = "+";
            this.btn_AddHR.UseVisualStyleBackColor = false;
            this.btn_AddHR.Click += new System.EventHandler(this.btn_AddHR_Click);
            // 
            // txtBox_CurrentHR
            // 
            this.txtBox_CurrentHR.Location = new System.Drawing.Point(9, 38);
            this.txtBox_CurrentHR.Name = "txtBox_CurrentHR";
            this.txtBox_CurrentHR.ReadOnly = true;
            this.txtBox_CurrentHR.Size = new System.Drawing.Size(47, 20);
            this.txtBox_CurrentHR.TabIndex = 95;
            this.txtBox_CurrentHR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBox_CurrentBP
            // 
            this.txtBox_CurrentBP.Location = new System.Drawing.Point(9, 92);
            this.txtBox_CurrentBP.Name = "txtBox_CurrentBP";
            this.txtBox_CurrentBP.ReadOnly = true;
            this.txtBox_CurrentBP.Size = new System.Drawing.Size(47, 20);
            this.txtBox_CurrentBP.TabIndex = 94;
            this.txtBox_CurrentBP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_MinusHR
            // 
            this.btn_MinusHR.Location = new System.Drawing.Point(58, 39);
            this.btn_MinusHR.Name = "btn_MinusHR";
            this.btn_MinusHR.Size = new System.Drawing.Size(30, 19);
            this.btn_MinusHR.TabIndex = 93;
            this.btn_MinusHR.Text = "-";
            this.btn_MinusHR.UseVisualStyleBackColor = false;
            this.btn_MinusHR.Click += new System.EventHandler(this.btn_MinusHR_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(135, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 106;
            this.label6.Text = "Temp:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(5, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 105;
            this.label8.Text = "BP (Systolic):";
            // 
            // btn_AddBP
            // 
            this.btn_AddBP.Location = new System.Drawing.Point(88, 91);
            this.btn_AddBP.Name = "btn_AddBP";
            this.btn_AddBP.Size = new System.Drawing.Size(30, 20);
            this.btn_AddBP.TabIndex = 96;
            this.btn_AddBP.Text = "+";
            this.btn_AddBP.UseVisualStyleBackColor = false;
            this.btn_AddBP.Click += new System.EventHandler(this.btn_AddBP_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(6, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 108;
            this.label10.Text = "SpO2:";
            // 
            // btn_MinusBP
            // 
            this.btn_MinusBP.Location = new System.Drawing.Point(58, 91);
            this.btn_MinusBP.Name = "btn_MinusBP";
            this.btn_MinusBP.Size = new System.Drawing.Size(30, 20);
            this.btn_MinusBP.TabIndex = 97;
            this.btn_MinusBP.Text = "-";
            this.btn_MinusBP.UseVisualStyleBackColor = false;
            this.btn_MinusBP.Click += new System.EventHandler(this.btn_MinusBP_Click);
            // 
            // groupBox_Graphs
            // 
            this.groupBox_Graphs.Controls.Add(this.tabControl1);
            this.groupBox_Graphs.Enabled = false;
            this.groupBox_Graphs.Location = new System.Drawing.Point(274, 13);
            this.groupBox_Graphs.Name = "groupBox_Graphs";
            this.groupBox_Graphs.Size = new System.Drawing.Size(506, 264);
            this.groupBox_Graphs.TabIndex = 118;
            this.groupBox_Graphs.TabStop = false;
            this.groupBox_Graphs.Text = "Simulation Visualisation";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 16);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(500, 245);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.zedGraphControl1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(492, 219);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ECG";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedGraphControl1.Location = new System.Drawing.Point(3, 3);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(486, 213);
            this.zedGraphControl1.TabIndex = 9;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.zedGraphControl3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(492, 219);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "BP (Plot)";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // zedGraphControl3
            // 
            this.zedGraphControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedGraphControl3.Location = new System.Drawing.Point(3, 3);
            this.zedGraphControl3.Name = "zedGraphControl3";
            this.zedGraphControl3.ScrollGrace = 0D;
            this.zedGraphControl3.ScrollMaxX = 0D;
            this.zedGraphControl3.ScrollMaxY = 0D;
            this.zedGraphControl3.ScrollMaxY2 = 0D;
            this.zedGraphControl3.ScrollMinX = 0D;
            this.zedGraphControl3.ScrollMinY = 0D;
            this.zedGraphControl3.ScrollMinY2 = 0D;
            this.zedGraphControl3.Size = new System.Drawing.Size(486, 213);
            this.zedGraphControl3.TabIndex = 15;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.zedGraphControl2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(492, 219);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "TEMP (Plot)";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // zedGraphControl2
            // 
            this.zedGraphControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedGraphControl2.Location = new System.Drawing.Point(0, 0);
            this.zedGraphControl2.Name = "zedGraphControl2";
            this.zedGraphControl2.ScrollGrace = 0D;
            this.zedGraphControl2.ScrollMaxX = 0D;
            this.zedGraphControl2.ScrollMaxY = 0D;
            this.zedGraphControl2.ScrollMaxY2 = 0D;
            this.zedGraphControl2.ScrollMinX = 0D;
            this.zedGraphControl2.ScrollMinY = 0D;
            this.zedGraphControl2.ScrollMinY2 = 0D;
            this.zedGraphControl2.Size = new System.Drawing.Size(492, 219);
            this.zedGraphControl2.TabIndex = 16;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.zedGraphControl4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(492, 219);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "RR (Plot)";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // zedGraphControl4
            // 
            this.zedGraphControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedGraphControl4.Location = new System.Drawing.Point(0, 0);
            this.zedGraphControl4.Name = "zedGraphControl4";
            this.zedGraphControl4.ScrollGrace = 0D;
            this.zedGraphControl4.ScrollMaxX = 0D;
            this.zedGraphControl4.ScrollMaxY = 0D;
            this.zedGraphControl4.ScrollMaxY2 = 0D;
            this.zedGraphControl4.ScrollMinX = 0D;
            this.zedGraphControl4.ScrollMinY = 0D;
            this.zedGraphControl4.ScrollMinY2 = 0D;
            this.zedGraphControl4.Size = new System.Drawing.Size(492, 219);
            this.zedGraphControl4.TabIndex = 12;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.zedGraphControl5);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(492, 219);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "SpO2 (Plot)";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // zedGraphControl5
            // 
            this.zedGraphControl5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedGraphControl5.Location = new System.Drawing.Point(0, 0);
            this.zedGraphControl5.Name = "zedGraphControl5";
            this.zedGraphControl5.ScrollGrace = 0D;
            this.zedGraphControl5.ScrollMaxX = 0D;
            this.zedGraphControl5.ScrollMaxY = 0D;
            this.zedGraphControl5.ScrollMaxY2 = 0D;
            this.zedGraphControl5.ScrollMinX = 0D;
            this.zedGraphControl5.ScrollMinY = 0D;
            this.zedGraphControl5.ScrollMinY2 = 0D;
            this.zedGraphControl5.Size = new System.Drawing.Size(492, 219);
            this.zedGraphControl5.TabIndex = 11;
            // 
            // groupBox_Output
            // 
            this.groupBox_Output.Controls.Add(this.groupBox8);
            this.groupBox_Output.Controls.Add(this.groupBox7);
            this.groupBox_Output.Controls.Add(this.groupBox6);
            this.groupBox_Output.Controls.Add(this.groupBox4);
            this.groupBox_Output.Controls.Add(this.groupBox3);
            this.groupBox_Output.Controls.Add(this.panel1);
            this.groupBox_Output.Enabled = false;
            this.groupBox_Output.Location = new System.Drawing.Point(273, 284);
            this.groupBox_Output.Name = "groupBox_Output";
            this.groupBox_Output.Size = new System.Drawing.Size(339, 167);
            this.groupBox_Output.TabIndex = 118;
            this.groupBox_Output.TabStop = false;
            this.groupBox_Output.Text = "Simulation Output";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.spo2Overview);
            this.groupBox8.Location = new System.Drawing.Point(270, 18);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(66, 59);
            this.groupBox8.TabIndex = 54;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "SpO2";
            // 
            // spo2Overview
            // 
            this.spo2Overview.AutoSize = true;
            this.spo2Overview.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spo2Overview.Location = new System.Drawing.Point(23, 19);
            this.spo2Overview.Name = "spo2Overview";
            this.spo2Overview.Size = new System.Drawing.Size(16, 32);
            this.spo2Overview.TabIndex = 49;
            this.spo2Overview.Text = "0\r\n%";
            this.spo2Overview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.rrOverview);
            this.groupBox7.Location = new System.Drawing.Point(204, 18);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(66, 59);
            this.groupBox7.TabIndex = 53;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "RR";
            // 
            // rrOverview
            // 
            this.rrOverview.AutoSize = true;
            this.rrOverview.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rrOverview.Location = new System.Drawing.Point(19, 19);
            this.rrOverview.Name = "rrOverview";
            this.rrOverview.Size = new System.Drawing.Size(24, 32);
            this.rrOverview.TabIndex = 48;
            this.rrOverview.Text = "0\r\nBF";
            this.rrOverview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.tempOverview);
            this.groupBox6.Location = new System.Drawing.Point(138, 18);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(66, 59);
            this.groupBox6.TabIndex = 53;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "TEMP";
            // 
            // tempOverview
            // 
            this.tempOverview.AutoSize = true;
            this.tempOverview.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempOverview.Location = new System.Drawing.Point(19, 19);
            this.tempOverview.Name = "tempOverview";
            this.tempOverview.Size = new System.Drawing.Size(24, 32);
            this.tempOverview.TabIndex = 47;
            this.tempOverview.Text = "0\r\n°C";
            this.tempOverview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.bpOverview);
            this.groupBox4.Location = new System.Drawing.Point(72, 18);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(66, 59);
            this.groupBox4.TabIndex = 52;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "BP";
            // 
            // bpOverview
            // 
            this.bpOverview.AutoSize = true;
            this.bpOverview.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bpOverview.Location = new System.Drawing.Point(14, 16);
            this.bpOverview.Name = "bpOverview";
            this.bpOverview.Size = new System.Drawing.Size(40, 32);
            this.bpOverview.TabIndex = 46;
            this.bpOverview.Text = "0\r\nmmHG";
            this.bpOverview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.hrOverview);
            this.groupBox3.Location = new System.Drawing.Point(6, 18);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(66, 59);
            this.groupBox3.TabIndex = 51;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "HR";
            // 
            // hrOverview
            // 
            this.hrOverview.AutoSize = true;
            this.hrOverview.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hrOverview.Location = new System.Drawing.Point(18, 16);
            this.hrOverview.Name = "hrOverview";
            this.hrOverview.Size = new System.Drawing.Size(32, 32);
            this.hrOverview.TabIndex = 45;
            this.hrOverview.Text = "0\r\nBPM";
            this.hrOverview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.richTextBox_output);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 81);
            this.panel1.TabIndex = 50;
            // 
            // richTextBox_output
            // 
            this.richTextBox_output.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox_output.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox_output.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_output.Location = new System.Drawing.Point(0, 0);
            this.richTextBox_output.Name = "richTextBox_output";
            this.richTextBox_output.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox_output.Size = new System.Drawing.Size(333, 81);
            this.richTextBox_output.TabIndex = 23;
            this.richTextBox_output.Text = "Output Log";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.start_Label);
            this.groupBox5.Controls.Add(this.stopTime);
            this.groupBox5.Controls.Add(this.stopDate);
            this.groupBox5.Controls.Add(this.startTime);
            this.groupBox5.Controls.Add(this.startDate);
            this.groupBox5.Controls.Add(this.btn_StopSimulation);
            this.groupBox5.Controls.Add(this.btn_StartSimulation);
            this.groupBox5.Location = new System.Drawing.Point(618, 284);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(162, 167);
            this.groupBox5.TabIndex = 119;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Simulation Control";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 67);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 13);
            this.label14.TabIndex = 111;
            this.label14.Text = "Stop:";
            // 
            // start_Label
            // 
            this.start_Label.AutoSize = true;
            this.start_Label.Location = new System.Drawing.Point(6, 23);
            this.start_Label.Name = "start_Label";
            this.start_Label.Size = new System.Drawing.Size(32, 13);
            this.start_Label.TabIndex = 110;
            this.start_Label.Text = "Start:";
            // 
            // stopTime
            // 
            this.stopTime.CustomFormat = "HH:mm:ss";
            this.stopTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.stopTime.Location = new System.Drawing.Point(91, 83);
            this.stopTime.Name = "stopTime";
            this.stopTime.ShowUpDown = true;
            this.stopTime.Size = new System.Drawing.Size(65, 20);
            this.stopTime.TabIndex = 109;
            this.stopTime.Value = new System.DateTime(2011, 4, 5, 0, 0, 0, 0);
            // 
            // stopDate
            // 
            this.stopDate.CustomFormat = "dd/MM/yyyy";
            this.stopDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.stopDate.Location = new System.Drawing.Point(8, 83);
            this.stopDate.Name = "stopDate";
            this.stopDate.Size = new System.Drawing.Size(83, 20);
            this.stopDate.TabIndex = 108;
            this.stopDate.Value = new System.DateTime(2011, 4, 5, 0, 0, 0, 0);
            // 
            // startTime
            // 
            this.startTime.CustomFormat = "HH:mm:ss";
            this.startTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startTime.Location = new System.Drawing.Point(91, 39);
            this.startTime.Name = "startTime";
            this.startTime.ShowUpDown = true;
            this.startTime.Size = new System.Drawing.Size(65, 20);
            this.startTime.TabIndex = 107;
            this.startTime.Value = new System.DateTime(2011, 4, 5, 0, 0, 0, 0);
            // 
            // startDate
            // 
            this.startDate.CustomFormat = "dd/MM/yyyy";
            this.startDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDate.Location = new System.Drawing.Point(9, 39);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(83, 20);
            this.startDate.TabIndex = 106;
            this.startDate.Value = new System.DateTime(2011, 4, 5, 0, 0, 0, 0);
            // 
            // btn_StopSimulation
            // 
            this.btn_StopSimulation.BackColor = System.Drawing.SystemColors.Control;
            this.btn_StopSimulation.Enabled = false;
            this.btn_StopSimulation.Location = new System.Drawing.Point(35, 138);
            this.btn_StopSimulation.Name = "btn_StopSimulation";
            this.btn_StopSimulation.Size = new System.Drawing.Size(107, 23);
            this.btn_StopSimulation.TabIndex = 105;
            this.btn_StopSimulation.Text = "Stop Simulation";
            this.btn_StopSimulation.UseVisualStyleBackColor = false;
            this.btn_StopSimulation.Click += new System.EventHandler(this.btn_StopSimulation_Click);
            // 
            // btn_StartSimulation
            // 
            this.btn_StartSimulation.BackColor = System.Drawing.SystemColors.Control;
            this.btn_StartSimulation.Location = new System.Drawing.Point(35, 114);
            this.btn_StartSimulation.Name = "btn_StartSimulation";
            this.btn_StartSimulation.Size = new System.Drawing.Size(107, 23);
            this.btn_StartSimulation.TabIndex = 104;
            this.btn_StartSimulation.Text = "Start Simulation";
            this.btn_StartSimulation.UseVisualStyleBackColor = false;
            this.btn_StartSimulation.Click += new System.EventHandler(this.btn_StartSimulation_Click);
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.Location = new System.Drawing.Point(625, 452);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(64, 13);
            this.lblstatus.TabIndex = 128;
            this.lblstatus.Text = "Initialising....";
            this.lblstatus.Visible = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(691, 454);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(85, 10);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 127;
            this.progressBar1.Visible = false;
            // 
            // PatientMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 468);
            this.Controls.Add(this.lblstatus);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox_Output);
            this.Controls.Add(this.groupBox_Graphs);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PatientMenu";
            this.Text = "PatientMenu";            
            this.Load += new System.EventHandler(this.PatientMenu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientPortrait)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox_Graphs.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.groupBox_Output.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtBox_Title;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBox_lName;
        private System.Windows.Forms.TextBox txtBox_fName;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBox_Gender;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBox_Bloodtype;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox patientPortrait;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox_Graphs;
        private System.Windows.Forms.GroupBox groupBox_Output;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_AddRR;
        private System.Windows.Forms.TextBox txtBox_CurrentRR;
        private System.Windows.Forms.Button btn_AddTemp;
        private System.Windows.Forms.Button btn_MinusRR;
        private System.Windows.Forms.Button btn_AddSpo2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_MinusSpo2;
        private System.Windows.Forms.Button btn_MinusTemp;
        private System.Windows.Forms.TextBox txtBox_CurrentSpo2;
        private System.Windows.Forms.TextBox txtBox_CurrentTemp;
        private System.Windows.Forms.Button btn_AddHR;
        private System.Windows.Forms.TextBox txtBox_CurrentHR;
        private System.Windows.Forms.TextBox txtBox_CurrentBP;
        private System.Windows.Forms.Button btn_MinusHR;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_AddBP;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_MinusBP;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTextBox_output;
        private System.Windows.Forms.Label spo2Overview;
        private System.Windows.Forms.Label rrOverview;
        private System.Windows.Forms.Label hrOverview;
        private System.Windows.Forms.Label tempOverview;
        private System.Windows.Forms.Label bpOverview;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label start_Label;
        private System.Windows.Forms.DateTimePicker stopTime;
        private System.Windows.Forms.DateTimePicker stopDate;
        private System.Windows.Forms.DateTimePicker startTime;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.Button btn_StopSimulation;
        private System.Windows.Forms.Button btn_StartSimulation;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private ZedGraph.ZedGraphControl zedGraphControl4;
        private System.Windows.Forms.TabPage tabPage5;
        private ZedGraph.ZedGraphControl zedGraphControl5;
        private ZedGraph.ZedGraphControl zedGraphControl3;
        private ZedGraph.ZedGraphControl zedGraphControl2;
        private System.Windows.Forms.TextBox txtBox_DOB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox combo_Scenario;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label lblstatus;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}