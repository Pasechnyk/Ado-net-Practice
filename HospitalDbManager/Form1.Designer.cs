
namespace HospitalDbApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.getPlacesBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.biggestDonationBtn = new System.Windows.Forms.Button();
            this.getExaminationsBtn = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.deleteExamBtn = new System.Windows.Forms.Button();
            this.deleteSponsorBtn = new System.Windows.Forms.Button();
            this.departmentBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.endDateMaskedBox = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.salaryNumeric = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.examNameBtn = new System.Windows.Forms.TextBox();
            this.startBtn = new System.Windows.Forms.TextBox();
            this.endBtn = new System.Windows.Forms.TextBox();
            this.idNumeric = new System.Windows.Forms.NumericUpDown();
            this.dayNumeric = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.salaryNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(168, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hospital Database Manager";
            // 
            // getPlacesBtn
            // 
            this.getPlacesBtn.Location = new System.Drawing.Point(429, 106);
            this.getPlacesBtn.Name = "getPlacesBtn";
            this.getPlacesBtn.Size = new System.Drawing.Size(146, 48);
            this.getPlacesBtn.TabIndex = 1;
            this.getPlacesBtn.Text = "Get Amount of Wards";
            this.getPlacesBtn.UseVisualStyleBackColor = true;
            this.getPlacesBtn.Click += new System.EventHandler(this.GetWardsByDepartmentBtnClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(426, 289);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 37);
            this.button2.TabIndex = 2;
            this.button2.Text = "Get Doctors";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.GetDoctorsBySalaryBtnClick);
            // 
            // biggestDonationBtn
            // 
            this.biggestDonationBtn.Location = new System.Drawing.Point(277, 346);
            this.biggestDonationBtn.Name = "biggestDonationBtn";
            this.biggestDonationBtn.Size = new System.Drawing.Size(186, 38);
            this.biggestDonationBtn.TabIndex = 3;
            this.biggestDonationBtn.Text = "Get Donation";
            this.biggestDonationBtn.UseVisualStyleBackColor = true;
            this.biggestDonationBtn.Click += new System.EventHandler(this.GetBiggestDonationBtnClick);
            // 
            // getExaminationsBtn
            // 
            this.getExaminationsBtn.Location = new System.Drawing.Point(306, 172);
            this.getExaminationsBtn.Name = "getExaminationsBtn";
            this.getExaminationsBtn.Size = new System.Drawing.Size(137, 34);
            this.getExaminationsBtn.TabIndex = 4;
            this.getExaminationsBtn.Text = "List";
            this.getExaminationsBtn.UseVisualStyleBackColor = true;
            this.getExaminationsBtn.Click += new System.EventHandler(this.GetExaminationsBtnClick);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(345, 533);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(188, 39);
            this.button5.TabIndex = 5;
            this.button5.Text = "Add new Examination";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.AddNewExaminationBtnClick);
            // 
            // deleteExamBtn
            // 
            this.deleteExamBtn.Location = new System.Drawing.Point(429, 216);
            this.deleteExamBtn.Name = "deleteExamBtn";
            this.deleteExamBtn.Size = new System.Drawing.Size(154, 54);
            this.deleteExamBtn.TabIndex = 6;
            this.deleteExamBtn.Text = "Delete Examination by Date";
            this.deleteExamBtn.UseVisualStyleBackColor = true;
            this.deleteExamBtn.Click += new System.EventHandler(this.DeleteExaminationBtnClick);
            // 
            // deleteSponsorBtn
            // 
            this.deleteSponsorBtn.Location = new System.Drawing.Point(318, 621);
            this.deleteSponsorBtn.Name = "deleteSponsorBtn";
            this.deleteSponsorBtn.Size = new System.Drawing.Size(232, 35);
            this.deleteSponsorBtn.TabIndex = 7;
            this.deleteSponsorBtn.Text = "Delete Sponsor";
            this.deleteSponsorBtn.UseVisualStyleBackColor = true;
            this.deleteSponsorBtn.Click += new System.EventHandler(this.DeleteSponsorBtnClick);
            // 
            // departmentBox
            // 
            this.departmentBox.Location = new System.Drawing.Point(214, 114);
            this.departmentBox.Name = "departmentBox";
            this.departmentBox.Size = new System.Drawing.Size(190, 27);
            this.departmentBox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Enter Department Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(269, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Get the list of all Examiations available:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(266, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Enter the Date in \'dd/mm/yyyy\' format:";
            // 
            // endDateMaskedBox
            // 
            this.endDateMaskedBox.Location = new System.Drawing.Point(306, 230);
            this.endDateMaskedBox.Mask = "00/00/0000";
            this.endDateMaskedBox.Name = "endDateMaskedBox";
            this.endDateMaskedBox.Size = new System.Drawing.Size(98, 27);
            this.endDateMaskedBox.TabIndex = 12;
            this.endDateMaskedBox.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(231, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Get Doctors with Salary higher of:";
            // 
            // salaryNumeric
            // 
            this.salaryNumeric.Location = new System.Drawing.Point(259, 295);
            this.salaryNumeric.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.salaryNumeric.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.salaryNumeric.Name = "salaryNumeric";
            this.salaryNumeric.Size = new System.Drawing.Size(150, 27);
            this.salaryNumeric.TabIndex = 14;
            this.salaryNumeric.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 355);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(222, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Get the biggest Donation made:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 413);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Add Examination:";
            // 
            // examNameBtn
            // 
            this.examNameBtn.Location = new System.Drawing.Point(190, 443);
            this.examNameBtn.Name = "examNameBtn";
            this.examNameBtn.Size = new System.Drawing.Size(112, 27);
            this.examNameBtn.TabIndex = 18;
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(190, 512);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(112, 27);
            this.startBtn.TabIndex = 20;
            // 
            // endBtn
            // 
            this.endBtn.Location = new System.Drawing.Point(190, 545);
            this.endBtn.Name = "endBtn";
            this.endBtn.Size = new System.Drawing.Size(112, 27);
            this.endBtn.TabIndex = 21;
            // 
            // idNumeric
            // 
            this.idNumeric.Location = new System.Drawing.Point(190, 406);
            this.idNumeric.Name = "idNumeric";
            this.idNumeric.Size = new System.Drawing.Size(112, 27);
            this.idNumeric.TabIndex = 22;
            // 
            // dayNumeric
            // 
            this.dayNumeric.Location = new System.Drawing.Point(190, 476);
            this.dayNumeric.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.dayNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dayNumeric.Name = "dayNumeric";
            this.dayNumeric.Size = new System.Drawing.Size(112, 27);
            this.dayNumeric.TabIndex = 23;
            this.dayNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 628);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(261, 20);
            this.label8.TabIndex = 24;
            this.label8.Text = "Delete Sponsor without any Donation:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 684);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dayNumeric);
            this.Controls.Add(this.idNumeric);
            this.Controls.Add(this.endBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.examNameBtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.salaryNumeric);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.endDateMaskedBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.departmentBox);
            this.Controls.Add(this.deleteSponsorBtn);
            this.Controls.Add(this.deleteExamBtn);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.getExaminationsBtn);
            this.Controls.Add(this.biggestDonationBtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.getPlacesBtn);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Hospital App";
            ((System.ComponentModel.ISupportInitialize)(this.salaryNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button getPlacesBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button biggestDonationBtn;
        private System.Windows.Forms.Button getExaminationsBtn;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button deleteExamBtn;
        private System.Windows.Forms.Button deleteSponsorBtn;
        private System.Windows.Forms.TextBox departmentBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox endDateMaskedBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown salaryNumeric;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox examNameBtn;
        private System.Windows.Forms.TextBox startBtn;
        private System.Windows.Forms.TextBox endBtn;
        private System.Windows.Forms.NumericUpDown idNumeric;
        private System.Windows.Forms.NumericUpDown dayNumeric;
        private System.Windows.Forms.Label label8;
    }
}

