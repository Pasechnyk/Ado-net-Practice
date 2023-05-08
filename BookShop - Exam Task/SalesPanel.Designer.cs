
namespace BookShop
{
    partial class SalesPanel
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.amountNumeric = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.bookTitleTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.clientTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.resetBtn = new System.Windows.Forms.Button();
            this.booksSaleListBox = new System.Windows.Forms.ListBox();
            this.addToBillBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.discountedBooksList = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.discountGroupBox = new System.Windows.Forms.GroupBox();
            this.twentyPercentBtn = new System.Windows.Forms.RadioButton();
            this.fifteenPercentBtn = new System.Windows.Forms.RadioButton();
            this.tenPercentBtn = new System.Windows.Forms.RadioButton();
            this.fivePercentBtn = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountNumeric)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.discountGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Snow;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1106, 49);
            this.panel1.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(387, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(388, 31);
            this.label2.TabIndex = 9;
            this.label2.Text = "Sale Configuration Panel (Manager)";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Snow;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.amountNumeric);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.bookTitleTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.clientTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(71, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(391, 148);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Book Reservation";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Amount:";
            // 
            // amountNumeric
            // 
            this.amountNumeric.Location = new System.Drawing.Point(127, 106);
            this.amountNumeric.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.amountNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.amountNumeric.Name = "amountNumeric";
            this.amountNumeric.Size = new System.Drawing.Size(77, 27);
            this.amountNumeric.TabIndex = 4;
            this.amountNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Book Title:";
            // 
            // bookTitleTextBox
            // 
            this.bookTitleTextBox.Location = new System.Drawing.Point(127, 70);
            this.bookTitleTextBox.Name = "bookTitleTextBox";
            this.bookTitleTextBox.Size = new System.Drawing.Size(184, 27);
            this.bookTitleTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Client Name:";
            // 
            // clientTextBox
            // 
            this.clientTextBox.Location = new System.Drawing.Point(127, 36);
            this.clientTextBox.Name = "clientTextBox";
            this.clientTextBox.Size = new System.Drawing.Size(184, 27);
            this.clientTextBox.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SeaShell;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.resetBtn);
            this.panel2.Controls.Add(this.booksSaleListBox);
            this.panel2.Controls.Add(this.addToBillBtn);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(12, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(535, 461);
            this.panel2.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(202, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Billing Information";
            // 
            // resetBtn
            // 
            this.resetBtn.BackColor = System.Drawing.Color.Snow;
            this.resetBtn.Location = new System.Drawing.Point(292, 197);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(107, 29);
            this.resetBtn.TabIndex = 16;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = false;
            this.resetBtn.Click += new System.EventHandler(this.ResetBtnClick);
            // 
            // booksSaleListBox
            // 
            this.booksSaleListBox.FormattingEnabled = true;
            this.booksSaleListBox.ItemHeight = 20;
            this.booksSaleListBox.Location = new System.Drawing.Point(25, 246);
            this.booksSaleListBox.Name = "booksSaleListBox";
            this.booksSaleListBox.Size = new System.Drawing.Size(483, 184);
            this.booksSaleListBox.TabIndex = 0;
            // 
            // addToBillBtn
            // 
            this.addToBillBtn.BackColor = System.Drawing.Color.Snow;
            this.addToBillBtn.Location = new System.Drawing.Point(124, 197);
            this.addToBillBtn.Name = "addToBillBtn";
            this.addToBillBtn.Size = new System.Drawing.Size(151, 29);
            this.addToBillBtn.TabIndex = 15;
            this.addToBillBtn.Text = "Print and Save Bill";
            this.addToBillBtn.UseVisualStyleBackColor = false;
            this.addToBillBtn.Click += new System.EventHandler(this.PrintBillBtnClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SeaShell;
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.discountedBooksList);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.discountGroupBox);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(564, 75);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(535, 461);
            this.panel3.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(134, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(268, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "(Choose the book from the list to access)";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Snow;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(22, 401);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 29);
            this.button2.TabIndex = 4;
            this.button2.Text = "Reset Discounts";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.ResetDiscountsBtnClick);
            // 
            // discountedBooksList
            // 
            this.discountedBooksList.FormattingEnabled = true;
            this.discountedBooksList.ItemHeight = 20;
            this.discountedBooksList.Location = new System.Drawing.Point(22, 211);
            this.discountedBooksList.Name = "discountedBooksList";
            this.discountedBooksList.Size = new System.Drawing.Size(490, 184);
            this.discountedBooksList.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Snow;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(147, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add Discounted Book";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.AddDiscountBtnClick);
            // 
            // discountGroupBox
            // 
            this.discountGroupBox.Controls.Add(this.twentyPercentBtn);
            this.discountGroupBox.Controls.Add(this.fifteenPercentBtn);
            this.discountGroupBox.Controls.Add(this.tenPercentBtn);
            this.discountGroupBox.Controls.Add(this.fivePercentBtn);
            this.discountGroupBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.discountGroupBox.Location = new System.Drawing.Point(91, 68);
            this.discountGroupBox.Name = "discountGroupBox";
            this.discountGroupBox.Size = new System.Drawing.Size(348, 88);
            this.discountGroupBox.TabIndex = 1;
            this.discountGroupBox.TabStop = false;
            this.discountGroupBox.Text = "Discount Choice";
            // 
            // twentyPercentBtn
            // 
            this.twentyPercentBtn.AutoSize = true;
            this.twentyPercentBtn.Location = new System.Drawing.Point(251, 31);
            this.twentyPercentBtn.Name = "twentyPercentBtn";
            this.twentyPercentBtn.Size = new System.Drawing.Size(58, 24);
            this.twentyPercentBtn.TabIndex = 3;
            this.twentyPercentBtn.TabStop = true;
            this.twentyPercentBtn.Text = "20%";
            this.twentyPercentBtn.UseVisualStyleBackColor = true;
            // 
            // fifteenPercentBtn
            // 
            this.fifteenPercentBtn.AutoSize = true;
            this.fifteenPercentBtn.Location = new System.Drawing.Point(177, 31);
            this.fifteenPercentBtn.Name = "fifteenPercentBtn";
            this.fifteenPercentBtn.Size = new System.Drawing.Size(58, 24);
            this.fifteenPercentBtn.TabIndex = 2;
            this.fifteenPercentBtn.TabStop = true;
            this.fifteenPercentBtn.Text = "15%";
            this.fifteenPercentBtn.UseVisualStyleBackColor = true;
            // 
            // tenPercentBtn
            // 
            this.tenPercentBtn.AutoSize = true;
            this.tenPercentBtn.Location = new System.Drawing.Point(106, 31);
            this.tenPercentBtn.Name = "tenPercentBtn";
            this.tenPercentBtn.Size = new System.Drawing.Size(58, 24);
            this.tenPercentBtn.TabIndex = 1;
            this.tenPercentBtn.TabStop = true;
            this.tenPercentBtn.Text = "10%";
            this.tenPercentBtn.UseVisualStyleBackColor = true;
            // 
            // fivePercentBtn
            // 
            this.fivePercentBtn.AutoSize = true;
            this.fivePercentBtn.Location = new System.Drawing.Point(43, 31);
            this.fivePercentBtn.Name = "fivePercentBtn";
            this.fivePercentBtn.Size = new System.Drawing.Size(50, 24);
            this.fivePercentBtn.TabIndex = 0;
            this.fivePercentBtn.TabStop = true;
            this.fivePercentBtn.Text = "5%";
            this.fivePercentBtn.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(174, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "Discount Configuration";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Snow;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(156, 401);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 29);
            this.button3.TabIndex = 6;
            this.button3.Text = "Save Discount List";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.SaveDiscountsBtnClick);
            // 
            // SalesPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1111, 569);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "SalesPanel";
            this.Text = "SalesPanel";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountNumeric)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.discountGroupBox.ResumeLayout(false);
            this.discountGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox clientTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown amountNumeric;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox bookTitleTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button addToBillBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.ListBox booksSaleListBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox discountGroupBox;
        private System.Windows.Forms.RadioButton twentyPercentBtn;
        private System.Windows.Forms.RadioButton fifteenPercentBtn;
        private System.Windows.Forms.RadioButton tenPercentBtn;
        private System.Windows.Forms.RadioButton fivePercentBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox discountedBooksList;
        private System.Windows.Forms.Button button3;
    }
}