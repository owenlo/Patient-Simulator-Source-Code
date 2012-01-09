namespace PatientSimulator
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_LoadPatient = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lName = new System.Windows.Forms.TextBox();
            this.ADDRESS = new System.Windows.Forms.TextBox();
            this.fName = new System.Windows.Forms.TextBox();
            this.DOB = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radioMale = new System.Windows.Forms.RadioButton();
            this.radioFemale = new System.Windows.Forms.RadioButton();
            this.btn_randomFemale = new System.Windows.Forms.Button();
            this.btn_RandomMale = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(3, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(370, 251);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(0, 65);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(384, 337);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.progressBar1);
            this.tabPage2.Controls.Add(this.btn_LoadPatient);
            this.tabPage2.Controls.Add(this.listBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(376, 311);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Patient List";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_LoadPatient
            // 
            this.btn_LoadPatient.BackColor = System.Drawing.SystemColors.Control;
            this.btn_LoadPatient.Location = new System.Drawing.Point(138, 258);
            this.btn_LoadPatient.Name = "btn_LoadPatient";
            this.btn_LoadPatient.Size = new System.Drawing.Size(108, 43);
            this.btn_LoadPatient.TabIndex = 1;
            this.btn_LoadPatient.Text = "Load Patient";
            this.btn_LoadPatient.UseVisualStyleBackColor = false;
            this.btn_LoadPatient.Click += new System.EventHandler(this.btn_LoadPatient_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 64);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::PatientSimulator.Properties.Resources.logo_trans;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(384, 64);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 61;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 63;
            // 
            // lName
            // 
            this.lName.Location = new System.Drawing.Point(99, 71);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(100, 20);
            this.lName.TabIndex = 58;
            // 
            // ADDRESS
            // 
            this.ADDRESS.Location = new System.Drawing.Point(99, 175);
            this.ADDRESS.Name = "ADDRESS";
            this.ADDRESS.Size = new System.Drawing.Size(100, 20);
            this.ADDRESS.TabIndex = 64;
            // 
            // fName
            // 
            this.fName.Location = new System.Drawing.Point(99, 45);
            this.fName.Name = "fName";
            this.fName.Size = new System.Drawing.Size(100, 20);
            this.fName.TabIndex = 57;
            // 
            // DOB
            // 
            this.DOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DOB.Location = new System.Drawing.Point(99, 98);
            this.DOB.Name = "DOB";
            this.DOB.ShowUpDown = true;
            this.DOB.Size = new System.Drawing.Size(100, 20);
            this.DOB.TabIndex = 65;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 56;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 67;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 54;
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(99, 19);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(100, 20);
            this.title.TabIndex = 68;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 53;                    
            // 
            // btn_randomFemale
            // 
            this.btn_randomFemale.Location = new System.Drawing.Point(0, 0);
            this.btn_randomFemale.Name = "btn_randomFemale";
            this.btn_randomFemale.Size = new System.Drawing.Size(75, 23);
            this.btn_randomFemale.TabIndex = 0;
            // 
            // btn_RandomMale
            // 
            this.btn_RandomMale.Location = new System.Drawing.Point(0, 0);
            this.btn_RandomMale.Name = "btn_RandomMale";
            this.btn_RandomMale.Size = new System.Drawing.Size(75, 23);
            this.btn_RandomMale.TabIndex = 0;
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(3, 303);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(370, 5);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 3;
            this.progressBar1.Visible = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(384, 402);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.Text = "Patient Simulator";      
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_LoadPatient;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox lName;
        private System.Windows.Forms.TextBox ADDRESS;
        private System.Windows.Forms.TextBox fName;
        private System.Windows.Forms.DateTimePicker DOB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioMale;
        private System.Windows.Forms.RadioButton radioFemale;
        private System.Windows.Forms.Button btn_randomFemale;
        private System.Windows.Forms.Button btn_RandomMale;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

