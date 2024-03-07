namespace Velodrome
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            label5 = new Label();
            cBoxParityBits = new ComboBox();
            label4 = new Label();
            cBoxStopBits = new ComboBox();
            label3 = new Label();
            cBoxDataBits = new ComboBox();
            label2 = new Label();
            cBoxBaudRate = new ComboBox();
            label1 = new Label();
            cBoxCOMPORT = new ComboBox();
            groupBox2 = new GroupBox();
            btnOpen = new Button();
            lblOnline = new Label();
            lblOffline = new Label();
            btnClose = new Button();
            groupBox4 = new GroupBox();
            label11 = new Label();
            tBoxCadence = new TextBox();
            label10 = new Label();
            tBoxAdjSpeed = new TextBox();
            label9 = new Label();
            tBoxSpeed = new TextBox();
            label8 = new Label();
            tBoxPower = new TextBox();
            label7 = new Label();
            groupBox5 = new GroupBox();
            label6 = new Label();
            btnBack = new Button();
            btnThird = new Button();
            btnSecond = new Button();
            btnFront = new Button();
            groupBox6 = new GroupBox();
            btnClearSpeed = new Button();
            btnEnterSpeed = new Button();
            label13 = new Label();
            tBoxTargetSpeed = new TextBox();
            label12 = new Label();
            btnCalibration = new Button();
            panel1 = new Panel();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cBoxParityBits);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(cBoxStopBits);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cBoxDataBits);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cBoxBaudRate);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cBoxCOMPORT);
            groupBox1.Location = new Point(526, 4);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(246, 184);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Com Port Control";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 140);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(79, 17);
            label5.TabIndex = 9;
            label5.Text = "PARITY BITS";
            // 
            // cBoxParityBits
            // 
            cBoxParityBits.FormattingEnabled = true;
            cBoxParityBits.Items.AddRange(new object[] { "None", "Odd", "Even" });
            cBoxParityBits.Location = new Point(107, 138);
            cBoxParityBits.Margin = new Padding(2);
            cBoxParityBits.Name = "cBoxParityBits";
            cBoxParityBits.Size = new Size(117, 25);
            cBoxParityBits.TabIndex = 8;
            cBoxParityBits.Text = "None";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 113);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(69, 17);
            label4.TabIndex = 7;
            label4.Text = "STOP BITS";
            // 
            // cBoxStopBits
            // 
            cBoxStopBits.FormattingEnabled = true;
            cBoxStopBits.Items.AddRange(new object[] { "One", "Two" });
            cBoxStopBits.Location = new Point(107, 111);
            cBoxStopBits.Margin = new Padding(2);
            cBoxStopBits.Name = "cBoxStopBits";
            cBoxStopBits.Size = new Size(117, 25);
            cBoxStopBits.TabIndex = 6;
            cBoxStopBits.Text = "One";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 86);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(70, 17);
            label3.TabIndex = 5;
            label3.Text = "DATA BITS";
            // 
            // cBoxDataBits
            // 
            cBoxDataBits.FormattingEnabled = true;
            cBoxDataBits.Items.AddRange(new object[] { "6", "7", "8" });
            cBoxDataBits.Location = new Point(107, 84);
            cBoxDataBits.Margin = new Padding(2);
            cBoxDataBits.Name = "cBoxDataBits";
            cBoxDataBits.Size = new Size(117, 25);
            cBoxDataBits.TabIndex = 4;
            cBoxDataBits.Text = "8";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 60);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(76, 17);
            label2.TabIndex = 3;
            label2.Text = "BAUD RATE";
            // 
            // cBoxBaudRate
            // 
            cBoxBaudRate.FormattingEnabled = true;
            cBoxBaudRate.Items.AddRange(new object[] { "2400", "4800", "9600", "115200" });
            cBoxBaudRate.Location = new Point(107, 57);
            cBoxBaudRate.Margin = new Padding(2);
            cBoxBaudRate.Name = "cBoxBaudRate";
            cBoxBaudRate.Size = new Size(117, 25);
            cBoxBaudRate.TabIndex = 2;
            cBoxBaudRate.Text = "115200";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 33);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(74, 17);
            label1.TabIndex = 1;
            label1.Text = "COM PORT";
            // 
            // cBoxCOMPORT
            // 
            cBoxCOMPORT.FormattingEnabled = true;
            cBoxCOMPORT.Location = new Point(107, 30);
            cBoxCOMPORT.Margin = new Padding(2);
            cBoxCOMPORT.Name = "cBoxCOMPORT";
            cBoxCOMPORT.Size = new Size(117, 25);
            cBoxCOMPORT.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnOpen);
            groupBox2.Controls.Add(lblOnline);
            groupBox2.Controls.Add(lblOffline);
            groupBox2.Controls.Add(btnClose);
            groupBox2.Location = new Point(526, 192);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(156, 125);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Cycler linking Status";
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(18, 81);
            btnOpen.Margin = new Padding(2);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(59, 24);
            btnOpen.TabIndex = 10;
            btnOpen.Text = "OPEN";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // lblOnline
            // 
            lblOnline.AutoSize = true;
            lblOnline.Font = new Font("Britannic Bold", 30F, FontStyle.Regular, GraphicsUnit.Point);
            lblOnline.Location = new Point(13, 26);
            lblOnline.Name = "lblOnline";
            lblOnline.Size = new Size(133, 44);
            lblOnline.TabIndex = 9;
            lblOnline.Text = "Online";
            // 
            // lblOffline
            // 
            lblOffline.AutoSize = true;
            lblOffline.Font = new Font("Britannic Bold", 30F, FontStyle.Regular, GraphicsUnit.Point);
            lblOffline.Location = new Point(13, 26);
            lblOffline.Name = "lblOffline";
            lblOffline.Size = new Size(136, 44);
            lblOffline.TabIndex = 8;
            lblOffline.Text = "Offline";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(81, 81);
            btnClose.Margin = new Padding(2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(59, 24);
            btnClose.TabIndex = 11;
            btnClose.Text = "CLOSE";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label11);
            groupBox4.Controls.Add(tBoxCadence);
            groupBox4.Controls.Add(label10);
            groupBox4.Controls.Add(tBoxAdjSpeed);
            groupBox4.Controls.Add(label9);
            groupBox4.Controls.Add(tBoxSpeed);
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(tBoxPower);
            groupBox4.Controls.Add(label7);
            groupBox4.Location = new Point(251, 3);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(269, 185);
            groupBox4.TabIndex = 5;
            groupBox4.TabStop = false;
            groupBox4.Text = "Status";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(14, 33);
            label11.Name = "label11";
            label11.Size = new Size(222, 17);
            label11.TabIndex = 8;
            label11.Text = "Display the status of the cycler here: ";
            // 
            // tBoxCadence
            // 
            tBoxCadence.Enabled = false;
            tBoxCadence.Location = new Point(144, 143);
            tBoxCadence.Name = "tBoxCadence";
            tBoxCadence.ReadOnly = true;
            tBoxCadence.Size = new Size(100, 23);
            tBoxCadence.TabIndex = 7;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(31, 118);
            label10.Name = "label10";
            label10.Size = new Size(107, 17);
            label10.TabIndex = 6;
            label10.Text = "Adjusted Speed: ";
            // 
            // tBoxAdjSpeed
            // 
            tBoxAdjSpeed.Enabled = false;
            tBoxAdjSpeed.Location = new Point(144, 114);
            tBoxAdjSpeed.Name = "tBoxAdjSpeed";
            tBoxAdjSpeed.ReadOnly = true;
            tBoxAdjSpeed.Size = new Size(100, 23);
            tBoxAdjSpeed.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(31, 146);
            label9.Name = "label9";
            label9.Size = new Size(65, 17);
            label9.TabIndex = 4;
            label9.Text = "Cadence: ";
            // 
            // tBoxSpeed
            // 
            tBoxSpeed.Enabled = false;
            tBoxSpeed.Location = new Point(144, 85);
            tBoxSpeed.Name = "tBoxSpeed";
            tBoxSpeed.ReadOnly = true;
            tBoxSpeed.Size = new Size(100, 23);
            tBoxSpeed.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(31, 89);
            label8.Name = "label8";
            label8.Size = new Size(52, 17);
            label8.TabIndex = 2;
            label8.Text = "Speed: ";
            // 
            // tBoxPower
            // 
            tBoxPower.Enabled = false;
            tBoxPower.Location = new Point(144, 53);
            tBoxPower.Name = "tBoxPower";
            tBoxPower.ReadOnly = true;
            tBoxPower.Size = new Size(100, 23);
            tBoxPower.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(31, 60);
            label7.Name = "label7";
            label7.Size = new Size(47, 17);
            label7.TabIndex = 0;
            label7.Text = "Power:";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(label6);
            groupBox5.Controls.Add(btnBack);
            groupBox5.Controls.Add(btnThird);
            groupBox5.Controls.Add(btnSecond);
            groupBox5.Controls.Add(btnFront);
            groupBox5.Location = new Point(4, 3);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(241, 314);
            groupBox5.TabIndex = 0;
            groupBox5.TabStop = false;
            groupBox5.Text = "Position";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 33);
            label6.Name = "label6";
            label6.Size = new Size(200, 17);
            label6.TabIndex = 8;
            label6.Text = "Adjust the cycler's position here: ";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(27, 250);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(192, 38);
            btnBack.TabIndex = 7;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnThird
            // 
            btnThird.Location = new Point(27, 186);
            btnThird.Name = "btnThird";
            btnThird.Size = new Size(192, 38);
            btnThird.TabIndex = 6;
            btnThird.Text = "3rd";
            btnThird.UseVisualStyleBackColor = true;
            btnThird.Click += btnThird_Click;
            // 
            // btnSecond
            // 
            btnSecond.Location = new Point(27, 122);
            btnSecond.Name = "btnSecond";
            btnSecond.Size = new Size(192, 38);
            btnSecond.TabIndex = 5;
            btnSecond.Text = "2nd";
            btnSecond.UseVisualStyleBackColor = true;
            btnSecond.Click += btnSecond_Click;
            // 
            // btnFront
            // 
            btnFront.Location = new Point(27, 59);
            btnFront.Name = "btnFront";
            btnFront.Size = new Size(192, 38);
            btnFront.TabIndex = 4;
            btnFront.Text = "Front";
            btnFront.UseVisualStyleBackColor = true;
            btnFront.Click += btnFront_Click;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(btnClearSpeed);
            groupBox6.Controls.Add(btnEnterSpeed);
            groupBox6.Controls.Add(label13);
            groupBox6.Controls.Add(tBoxTargetSpeed);
            groupBox6.Controls.Add(label12);
            groupBox6.Location = new Point(251, 191);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(270, 126);
            groupBox6.TabIndex = 6;
            groupBox6.TabStop = false;
            groupBox6.Text = "Adjust Speed";
            // 
            // btnClearSpeed
            // 
            btnClearSpeed.Location = new Point(141, 84);
            btnClearSpeed.Name = "btnClearSpeed";
            btnClearSpeed.Size = new Size(75, 23);
            btnClearSpeed.TabIndex = 14;
            btnClearSpeed.Text = "Clear";
            btnClearSpeed.UseVisualStyleBackColor = true;
            btnClearSpeed.Click += btnClearSpeed_Click;
            // 
            // btnEnterSpeed
            // 
            btnEnterSpeed.Location = new Point(54, 84);
            btnEnterSpeed.Name = "btnEnterSpeed";
            btnEnterSpeed.Size = new Size(75, 23);
            btnEnterSpeed.TabIndex = 13;
            btnEnterSpeed.Text = "Enter";
            btnEnterSpeed.UseVisualStyleBackColor = true;
            btnEnterSpeed.Click += btnEnterSpeed_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(14, 31);
            label13.Name = "label13";
            label13.Size = new Size(218, 17);
            label13.TabIndex = 9;
            label13.Text = "Adjust the speed of the cycler here: ";
            // 
            // tBoxTargetSpeed
            // 
            tBoxTargetSpeed.Location = new Point(133, 55);
            tBoxTargetSpeed.Name = "tBoxTargetSpeed";
            tBoxTargetSpeed.Size = new Size(100, 23);
            tBoxTargetSpeed.TabIndex = 12;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(38, 58);
            label12.Name = "label12";
            label12.Size = new Size(93, 17);
            label12.TabIndex = 11;
            label12.Text = "Target speed: ";
            // 
            // btnCalibration
            // 
            btnCalibration.Location = new Point(687, 198);
            btnCalibration.Name = "btnCalibration";
            btnCalibration.Size = new Size(85, 118);
            btnCalibration.TabIndex = 7;
            btnCalibration.Text = "Calibration";
            btnCalibration.UseVisualStyleBackColor = true;
            btnCalibration.Click += btnCalibration_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox5);
            panel1.Controls.Add(btnCalibration);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(groupBox6);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox4);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 320);
            panel1.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(776, 320);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Velodrome";
            Load += Form1_Load;
            Resize += Form1_Resize;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label5;
        private ComboBox cBoxParityBits;
        private Label label4;
        private ComboBox cBoxStopBits;
        private Label label3;
        private ComboBox cBoxDataBits;
        private Label label2;
        private ComboBox cBoxBaudRate;
        private Label label1;
        private ComboBox cBoxCOMPORT;
        private GroupBox groupBox2;
        private GroupBox groupBox4;
        private Label label7;
        private GroupBox groupBox5;
        private Label label6;
        private Button btnBack;
        private Button btnThird;
        private Button btnSecond;
        private Button btnFront;
        private Label label11;
        private TextBox tBoxCadence;
        private Label label10;
        private TextBox tBoxAdjSpeed;
        private Label label9;
        private TextBox tBoxSpeed;
        private Label label8;
        private TextBox tBoxPower;
        private GroupBox groupBox6;
        private Button btnClearSpeed;
        private Button btnEnterSpeed;
        private Label label13;
        private TextBox tBoxTargetSpeed;
        private Label label12;
        private Button btnCalibration;
        private Label lblOffline;
        private Label lblOnline;
        private Button btnOpen;
        private Button btnClose;
        private Panel panel1;
    }
}