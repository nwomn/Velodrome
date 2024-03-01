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
            btnClose = new Button();
            progressBar1 = new ProgressBar();
            btnDisconnect = new Button();
            btnSendData = new Button();
            tBoxDataOut = new TextBox();
            groupBox3 = new GroupBox();
            chBoxAddToOldData = new CheckBox();
            chBoxAlwaysUpdate = new CheckBox();
            tBoxDataIN = new TextBox();
            groupBox4 = new GroupBox();
            label11 = new Label();
            textBox4 = new TextBox();
            label10 = new Label();
            textBox3 = new TextBox();
            label9 = new Label();
            textBox2 = new TextBox();
            label8 = new Label();
            textBox1 = new TextBox();
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
            label14 = new Label();
            groupBox7 = new GroupBox();
            btnOpen = new Button();
            btnConnect = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox7.SuspendLayout();
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
            groupBox1.Location = new Point(13, 11);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(372, 260);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Com Port Control";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 198);
            label5.Name = "label5";
            label5.Size = new Size(113, 24);
            label5.TabIndex = 9;
            label5.Text = "PARITY BITS";
            // 
            // cBoxParityBits
            // 
            cBoxParityBits.FormattingEnabled = true;
            cBoxParityBits.Items.AddRange(new object[] { "None", "Odd", "Even" });
            cBoxParityBits.Location = new Point(160, 195);
            cBoxParityBits.Name = "cBoxParityBits";
            cBoxParityBits.Size = new Size(182, 32);
            cBoxParityBits.TabIndex = 8;
            cBoxParityBits.Text = "None";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 160);
            label4.Name = "label4";
            label4.Size = new Size(97, 24);
            label4.TabIndex = 7;
            label4.Text = "STOP BITS";
            // 
            // cBoxStopBits
            // 
            cBoxStopBits.FormattingEnabled = true;
            cBoxStopBits.Items.AddRange(new object[] { "One", "Two" });
            cBoxStopBits.Location = new Point(160, 157);
            cBoxStopBits.Name = "cBoxStopBits";
            cBoxStopBits.Size = new Size(182, 32);
            cBoxStopBits.TabIndex = 6;
            cBoxStopBits.Text = "One";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 121);
            label3.Name = "label3";
            label3.Size = new Size(101, 24);
            label3.TabIndex = 5;
            label3.Text = "DATA BITS";
            // 
            // cBoxDataBits
            // 
            cBoxDataBits.FormattingEnabled = true;
            cBoxDataBits.Items.AddRange(new object[] { "6", "7", "8" });
            cBoxDataBits.Location = new Point(160, 119);
            cBoxDataBits.Name = "cBoxDataBits";
            cBoxDataBits.Size = new Size(182, 32);
            cBoxDataBits.TabIndex = 4;
            cBoxDataBits.Text = "8";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 85);
            label2.Name = "label2";
            label2.Size = new Size(111, 24);
            label2.TabIndex = 3;
            label2.Text = "BAUD RATE";
            // 
            // cBoxBaudRate
            // 
            cBoxBaudRate.FormattingEnabled = true;
            cBoxBaudRate.Items.AddRange(new object[] { "2400", "4800", "9600", "115200" });
            cBoxBaudRate.Location = new Point(160, 80);
            cBoxBaudRate.Name = "cBoxBaudRate";
            cBoxBaudRate.Size = new Size(182, 32);
            cBoxBaudRate.TabIndex = 2;
            cBoxBaudRate.Text = "115200";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 47);
            label1.Name = "label1";
            label1.Size = new Size(108, 24);
            label1.TabIndex = 1;
            label1.Text = "COM PORT";
            // 
            // cBoxCOMPORT
            // 
            cBoxCOMPORT.FormattingEnabled = true;
            cBoxCOMPORT.Location = new Point(160, 42);
            cBoxCOMPORT.Name = "cBoxCOMPORT";
            cBoxCOMPORT.Size = new Size(182, 32);
            cBoxCOMPORT.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnClose);
            groupBox2.Controls.Add(progressBar1);
            groupBox2.Location = new Point(13, 278);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(209, 116);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(108, 28);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(92, 34);
            btnClose.TabIndex = 11;
            btnClose.Text = "CLOSE";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(16, 69);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(176, 34);
            progressBar1.TabIndex = 2;
            // 
            // btnDisconnect
            // 
            btnDisconnect.Location = new Point(1100, 683);
            btnDisconnect.Name = "btnDisconnect";
            btnDisconnect.Size = new Size(144, 164);
            btnDisconnect.TabIndex = 3;
            btnDisconnect.Text = "Disconnect";
            btnDisconnect.UseVisualStyleBackColor = true;
            btnDisconnect.Click += btnClose_Click;
            // 
            // btnSendData
            // 
            btnSendData.Location = new Point(242, 292);
            btnSendData.Name = "btnSendData";
            btnSendData.Size = new Size(141, 102);
            btnSendData.TabIndex = 2;
            btnSendData.Text = "Send Data";
            btnSendData.UseVisualStyleBackColor = true;
            btnSendData.Click += btnSendData_Click;
            // 
            // tBoxDataOut
            // 
            tBoxDataOut.Location = new Point(401, 21);
            tBoxDataOut.Multiline = true;
            tBoxDataOut.Name = "tBoxDataOut";
            tBoxDataOut.Size = new Size(369, 372);
            tBoxDataOut.TabIndex = 3;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(chBoxAddToOldData);
            groupBox3.Controls.Add(chBoxAlwaysUpdate);
            groupBox3.Controls.Add(tBoxDataIN);
            groupBox3.Location = new Point(775, 21);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(464, 373);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Receiver Control";
            // 
            // chBoxAddToOldData
            // 
            chBoxAddToOldData.AutoSize = true;
            chBoxAddToOldData.Location = new Point(6, 291);
            chBoxAddToOldData.Name = "chBoxAddToOldData";
            chBoxAddToOldData.Size = new Size(182, 28);
            chBoxAddToOldData.TabIndex = 7;
            chBoxAddToOldData.Text = "Add To Old Data";
            chBoxAddToOldData.UseVisualStyleBackColor = true;
            chBoxAddToOldData.CheckedChanged += chBoxAddToOldData_CheckedChanged;
            // 
            // chBoxAlwaysUpdate
            // 
            chBoxAlwaysUpdate.AutoSize = true;
            chBoxAlwaysUpdate.Location = new Point(6, 257);
            chBoxAlwaysUpdate.Name = "chBoxAlwaysUpdate";
            chBoxAlwaysUpdate.Size = new Size(165, 28);
            chBoxAlwaysUpdate.TabIndex = 6;
            chBoxAlwaysUpdate.Text = "Always Update";
            chBoxAlwaysUpdate.UseVisualStyleBackColor = true;
            chBoxAlwaysUpdate.CheckedChanged += chBoxAlwaysUpdate_CheckedChanged;
            // 
            // tBoxDataIN
            // 
            tBoxDataIN.Enabled = false;
            tBoxDataIN.Location = new Point(6, 30);
            tBoxDataIN.Multiline = true;
            tBoxDataIN.Name = "tBoxDataIN";
            tBoxDataIN.ReadOnly = true;
            tBoxDataIN.Size = new Size(452, 221);
            tBoxDataIN.TabIndex = 5;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label11);
            groupBox4.Controls.Add(textBox4);
            groupBox4.Controls.Add(label10);
            groupBox4.Controls.Add(textBox3);
            groupBox4.Controls.Add(label9);
            groupBox4.Controls.Add(textBox2);
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(textBox1);
            groupBox4.Controls.Add(label7);
            groupBox4.Location = new Point(401, 404);
            groupBox4.Margin = new Padding(5, 4, 5, 4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(5, 4, 5, 4);
            groupBox4.Size = new Size(387, 261);
            groupBox4.TabIndex = 5;
            groupBox4.TabStop = false;
            groupBox4.Text = "Status";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(22, 47);
            label11.Margin = new Padding(5, 0, 5, 0);
            label11.Name = "label11";
            label11.Size = new Size(325, 24);
            label11.TabIndex = 8;
            label11.Text = "Display the status of the cycler here: ";
            // 
            // textBox4
            // 
            textBox4.Enabled = false;
            textBox4.Location = new Point(199, 202);
            textBox4.Margin = new Padding(5, 4, 5, 4);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(155, 30);
            textBox4.TabIndex = 7;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(49, 166);
            label10.Margin = new Padding(5, 0, 5, 0);
            label10.Name = "label10";
            label10.Size = new Size(156, 24);
            label10.TabIndex = 6;
            label10.Text = "Adjusted Speed: ";
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Location = new Point(199, 161);
            textBox3.Margin = new Padding(5, 4, 5, 4);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(155, 30);
            textBox3.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(49, 206);
            label9.Margin = new Padding(5, 0, 5, 0);
            label9.Name = "label9";
            label9.Size = new Size(93, 24);
            label9.TabIndex = 4;
            label9.Text = "Cadence: ";
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(199, 120);
            textBox2.Margin = new Padding(5, 4, 5, 4);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(155, 30);
            textBox2.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(49, 125);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(73, 24);
            label8.TabIndex = 2;
            label8.Text = "Speed: ";
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(199, 75);
            textBox1.Margin = new Padding(5, 4, 5, 4);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(155, 30);
            textBox1.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(49, 84);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(67, 24);
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
            groupBox5.Location = new Point(13, 404);
            groupBox5.Margin = new Padding(5, 4, 5, 4);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(5, 4, 5, 4);
            groupBox5.Size = new Size(379, 443);
            groupBox5.TabIndex = 0;
            groupBox5.TabStop = false;
            groupBox5.Text = "Position";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 47);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(294, 24);
            label6.TabIndex = 8;
            label6.Text = "Adjust the cycler's position here: ";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(42, 353);
            btnBack.Margin = new Padding(5, 4, 5, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(302, 54);
            btnBack.TabIndex = 7;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // btnThird
            // 
            btnThird.Location = new Point(42, 263);
            btnThird.Margin = new Padding(5, 4, 5, 4);
            btnThird.Name = "btnThird";
            btnThird.Size = new Size(302, 54);
            btnThird.TabIndex = 6;
            btnThird.Text = "3rd";
            btnThird.UseVisualStyleBackColor = true;
            // 
            // btnSecond
            // 
            btnSecond.Location = new Point(42, 172);
            btnSecond.Margin = new Padding(5, 4, 5, 4);
            btnSecond.Name = "btnSecond";
            btnSecond.Size = new Size(302, 54);
            btnSecond.TabIndex = 5;
            btnSecond.Text = "2nd";
            btnSecond.UseVisualStyleBackColor = true;
            // 
            // btnFront
            // 
            btnFront.Location = new Point(42, 83);
            btnFront.Margin = new Padding(5, 4, 5, 4);
            btnFront.Name = "btnFront";
            btnFront.Size = new Size(302, 54);
            btnFront.TabIndex = 4;
            btnFront.Text = "Front";
            btnFront.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(btnClearSpeed);
            groupBox6.Controls.Add(btnEnterSpeed);
            groupBox6.Controls.Add(label13);
            groupBox6.Controls.Add(tBoxTargetSpeed);
            groupBox6.Controls.Add(label12);
            groupBox6.Location = new Point(401, 669);
            groupBox6.Margin = new Padding(5, 4, 5, 4);
            groupBox6.Name = "groupBox6";
            groupBox6.Padding = new Padding(5, 4, 5, 4);
            groupBox6.Size = new Size(387, 178);
            groupBox6.TabIndex = 6;
            groupBox6.TabStop = false;
            groupBox6.Text = "Adjust Speed";
            // 
            // btnClearSpeed
            // 
            btnClearSpeed.Location = new Point(207, 119);
            btnClearSpeed.Margin = new Padding(5, 4, 5, 4);
            btnClearSpeed.Name = "btnClearSpeed";
            btnClearSpeed.Size = new Size(118, 32);
            btnClearSpeed.TabIndex = 14;
            btnClearSpeed.Text = "Clear";
            btnClearSpeed.UseVisualStyleBackColor = true;
            // 
            // btnEnterSpeed
            // 
            btnEnterSpeed.Location = new Point(71, 119);
            btnEnterSpeed.Margin = new Padding(5, 4, 5, 4);
            btnEnterSpeed.Name = "btnEnterSpeed";
            btnEnterSpeed.Size = new Size(118, 32);
            btnEnterSpeed.TabIndex = 13;
            btnEnterSpeed.Text = "Enter";
            btnEnterSpeed.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(22, 44);
            label13.Margin = new Padding(5, 0, 5, 0);
            label13.Name = "label13";
            label13.Size = new Size(318, 24);
            label13.TabIndex = 9;
            label13.Text = "Adjust the speed of the cycler here: ";
            // 
            // tBoxTargetSpeed
            // 
            tBoxTargetSpeed.Location = new Point(195, 78);
            tBoxTargetSpeed.Margin = new Padding(5, 4, 5, 4);
            tBoxTargetSpeed.Name = "tBoxTargetSpeed";
            tBoxTargetSpeed.Size = new Size(155, 30);
            tBoxTargetSpeed.TabIndex = 12;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(46, 82);
            label12.Margin = new Padding(5, 0, 5, 0);
            label12.Name = "label12";
            label12.Size = new Size(132, 24);
            label12.TabIndex = 11;
            label12.Text = "Target speed: ";
            // 
            // btnCalibration
            // 
            btnCalibration.Location = new Point(798, 683);
            btnCalibration.Margin = new Padding(5, 4, 5, 4);
            btnCalibration.Name = "btnCalibration";
            btnCalibration.Size = new Size(144, 164);
            btnCalibration.TabIndex = 7;
            btnCalibration.Text = "Calibration";
            btnCalibration.UseVisualStyleBackColor = true;
            btnCalibration.Click += btnCalibration_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Britannic Bold", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(122, 104);
            label14.Margin = new Padding(5, 0, 5, 0);
            label14.Name = "label14";
            label14.Size = new Size(203, 67);
            label14.TabIndex = 8;
            label14.Text = "Offline";
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(label14);
            groupBox7.Location = new Point(797, 404);
            groupBox7.Margin = new Padding(5, 4, 5, 4);
            groupBox7.Name = "groupBox7";
            groupBox7.Padding = new Padding(5, 4, 5, 4);
            groupBox7.Size = new Size(442, 261);
            groupBox7.TabIndex = 9;
            groupBox7.TabStop = false;
            groupBox7.Text = "Cycler linking Statu";
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(23, 307);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(92, 34);
            btnOpen.TabIndex = 10;
            btnOpen.Text = "OPEN";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(950, 683);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(144, 164);
            btnConnect.TabIndex = 11;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1251, 864);
            Controls.Add(btnConnect);
            Controls.Add(btnOpen);
            Controls.Add(btnDisconnect);
            Controls.Add(groupBox7);
            Controls.Add(btnCalibration);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(tBoxDataOut);
            Controls.Add(btnSendData);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "C# COM PORT SERIAL";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private Button btnDisconnect;
        private ProgressBar progressBar1;
        private Button btnSendData;
        private TextBox tBoxDataOut;
        private GroupBox groupBox3;
        private CheckBox chBoxAddToOldData;
        private CheckBox chBoxAlwaysUpdate;
        private TextBox tBoxDataIN;
        private GroupBox groupBox4;
        private Label label7;
        private GroupBox groupBox5;
        private Label label6;
        private Button btnBack;
        private Button btnThird;
        private Button btnSecond;
        private Button btnFront;
        private Label label11;
        private TextBox textBox4;
        private Label label10;
        private TextBox textBox3;
        private Label label9;
        private TextBox textBox2;
        private Label label8;
        private TextBox textBox1;
        private GroupBox groupBox6;
        private Button btnClearSpeed;
        private Button btnEnterSpeed;
        private Label label13;
        private TextBox tBoxTargetSpeed;
        private Label label12;
        private Button btnCalibration;
        private Label label14;
        private GroupBox groupBox7;
        private Button btnClose;
        private Button btnOpen;
        private Button btnConnect;
    }
}