
namespace BookShop
{
    partial class MainPanel
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.searchByNameBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.idNumeric = new System.Windows.Forms.NumericUpDown();
            this.genreNumeric = new System.Windows.Forms.NumericUpDown();
            this.authorNumeric = new System.Windows.Forms.NumericUpDown();
            this.sagaCheckBox = new System.Windows.Forms.CheckBox();
            this.yearNumeric = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.priceNumeric = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.publisherNumeric = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pagesNumeric = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.searchByAuthorBtn = new System.Windows.Forms.Button();
            this.searchByGenreBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.booksListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genreNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publisherNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagesNumeric)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Tan;
            this.button1.Location = new System.Drawing.Point(38, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add a Book";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.AddBookBtnClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Tan;
            this.button2.Location = new System.Drawing.Point(38, 434);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 37);
            this.button2.TabIndex = 2;
            this.button2.Text = "Remove a Book";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.RemoveBookBtnClick);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Tan;
            this.button3.Location = new System.Drawing.Point(38, 477);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 37);
            this.button3.TabIndex = 3;
            this.button3.Text = "Edit Existing Book";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.EditBookBtnClick);
            // 
            // searchByNameBtn
            // 
            this.searchByNameBtn.BackColor = System.Drawing.Color.Tan;
            this.searchByNameBtn.Location = new System.Drawing.Point(180, 46);
            this.searchByNameBtn.Name = "searchByNameBtn";
            this.searchByNameBtn.Size = new System.Drawing.Size(142, 37);
            this.searchByNameBtn.TabIndex = 4;
            this.searchByNameBtn.Text = "Name";
            this.searchByNameBtn.UseVisualStyleBackColor = false;
            this.searchByNameBtn.Click += new System.EventHandler(this.FindByParameter);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FloralWhite;
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.idNumeric);
            this.groupBox1.Controls.Add(this.genreNumeric);
            this.groupBox1.Controls.Add(this.authorNumeric);
            this.groupBox1.Controls.Add(this.sagaCheckBox);
            this.groupBox1.Controls.Add(this.yearNumeric);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.priceNumeric);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.publisherNumeric);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.pagesNumeric);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.titleTextBox);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(30, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 565);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Books Configuration";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 20);
            this.label8.TabIndex = 38;
            this.label8.Text = "Book ID";
            // 
            // idNumeric
            // 
            this.idNumeric.Location = new System.Drawing.Point(108, 32);
            this.idNumeric.Minimum = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this.idNumeric.Name = "idNumeric";
            this.idNumeric.Size = new System.Drawing.Size(93, 27);
            this.idNumeric.TabIndex = 37;
            this.idNumeric.Value = new decimal(new int[] {
            11,
            0,
            0,
            0});
            // 
            // genreNumeric
            // 
            this.genreNumeric.Location = new System.Drawing.Point(86, 113);
            this.genreNumeric.Name = "genreNumeric";
            this.genreNumeric.Size = new System.Drawing.Size(115, 27);
            this.genreNumeric.TabIndex = 36;
            // 
            // authorNumeric
            // 
            this.authorNumeric.Location = new System.Drawing.Point(86, 182);
            this.authorNumeric.Name = "authorNumeric";
            this.authorNumeric.Size = new System.Drawing.Size(115, 27);
            this.authorNumeric.TabIndex = 35;
            // 
            // sagaCheckBox
            // 
            this.sagaCheckBox.AutoSize = true;
            this.sagaCheckBox.Location = new System.Drawing.Point(55, 350);
            this.sagaCheckBox.Name = "sagaCheckBox";
            this.sagaCheckBox.Size = new System.Drawing.Size(108, 24);
            this.sagaCheckBox.TabIndex = 34;
            this.sagaCheckBox.Text = "Part of saga";
            this.sagaCheckBox.UseVisualStyleBackColor = true;
            // 
            // yearNumeric
            // 
            this.yearNumeric.Location = new System.Drawing.Point(58, 244);
            this.yearNumeric.Maximum = new decimal(new int[] {
            2023,
            0,
            0,
            0});
            this.yearNumeric.Minimum = new decimal(new int[] {
            1990,
            0,
            0,
            0});
            this.yearNumeric.Name = "yearNumeric";
            this.yearNumeric.Size = new System.Drawing.Size(143, 27);
            this.yearNumeric.TabIndex = 33;
            this.yearNumeric.Value = new decimal(new int[] {
            1990,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 20);
            this.label6.TabIndex = 32;
            this.label6.Text = "Year:";
            // 
            // priceNumeric
            // 
            this.priceNumeric.Location = new System.Drawing.Point(75, 310);
            this.priceNumeric.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.priceNumeric.Name = "priceNumeric";
            this.priceNumeric.Size = new System.Drawing.Size(126, 27);
            this.priceNumeric.TabIndex = 31;
            this.priceNumeric.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 312);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 20);
            this.label13.TabIndex = 30;
            this.label13.Text = "Price($):";
            // 
            // publisherNumeric
            // 
            this.publisherNumeric.Location = new System.Drawing.Point(107, 277);
            this.publisherNumeric.Name = "publisherNumeric";
            this.publisherNumeric.Size = new System.Drawing.Size(94, 27);
            this.publisherNumeric.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 20);
            this.label7.TabIndex = 28;
            this.label7.Text = "Publisher ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "Author ID:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 20);
            this.label9.TabIndex = 25;
            this.label9.Text = "Pages amount:";
            // 
            // pagesNumeric
            // 
            this.pagesNumeric.Location = new System.Drawing.Point(123, 146);
            this.pagesNumeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.pagesNumeric.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.pagesNumeric.Name = "pagesNumeric";
            this.pagesNumeric.Size = new System.Drawing.Size(78, 27);
            this.pagesNumeric.TabIndex = 24;
            this.pagesNumeric.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 115);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 20);
            this.label12.TabIndex = 23;
            this.label12.Text = "Genre ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Title";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(58, 65);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(143, 27);
            this.titleTextBox.TabIndex = 4;
            // 
            // searchByAuthorBtn
            // 
            this.searchByAuthorBtn.BackColor = System.Drawing.Color.Tan;
            this.searchByAuthorBtn.Location = new System.Drawing.Point(328, 46);
            this.searchByAuthorBtn.Name = "searchByAuthorBtn";
            this.searchByAuthorBtn.Size = new System.Drawing.Size(142, 37);
            this.searchByAuthorBtn.TabIndex = 5;
            this.searchByAuthorBtn.Text = "Author(by ID)";
            this.searchByAuthorBtn.UseVisualStyleBackColor = false;
            this.searchByAuthorBtn.Click += new System.EventHandler(this.FindByParameter);
            // 
            // searchByGenreBtn
            // 
            this.searchByGenreBtn.BackColor = System.Drawing.Color.Tan;
            this.searchByGenreBtn.Location = new System.Drawing.Point(476, 46);
            this.searchByGenreBtn.Name = "searchByGenreBtn";
            this.searchByGenreBtn.Size = new System.Drawing.Size(142, 37);
            this.searchByGenreBtn.TabIndex = 6;
            this.searchByGenreBtn.Text = "Genre(by ID)";
            this.searchByGenreBtn.UseVisualStyleBackColor = false;
            this.searchByGenreBtn.Click += new System.EventHandler(this.FindByParameter);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FloralWhite;
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.searchTextBox);
            this.groupBox2.Controls.Add(this.searchByNameBtn);
            this.groupBox2.Controls.Add(this.searchByAuthorBtn);
            this.groupBox2.Controls.Add(this.searchByGenreBtn);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(270, 77);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(644, 121);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Find By:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Enter word to search:";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(23, 51);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(142, 27);
            this.searchTextBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(372, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(429, 31);
            this.label2.TabIndex = 9;
            this.label2.Text = "Book Shop Configuration Panel (Admin)";
            // 
            // booksListBox
            // 
            this.booksListBox.FormattingEnabled = true;
            this.booksListBox.ItemHeight = 20;
            this.booksListBox.Location = new System.Drawing.Point(270, 258);
            this.booksListBox.Name = "booksListBox";
            this.booksListBox.Size = new System.Drawing.Size(644, 384);
            this.booksListBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(270, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Books Available:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tan;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1164, 49);
            this.panel1.TabIndex = 12;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Tan;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(808, 212);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(106, 31);
            this.button4.TabIndex = 13;
            this.button4.Text = "Refresh";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.RefreshList);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(933, 77);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(207, 121);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Publisher IDs";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label24);
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.groupBox4.Location = new System.Drawing.Point(933, 212);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(207, 256);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Author IDs";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label30);
            this.groupBox5.Controls.Add(this.label29);
            this.groupBox5.Controls.Add(this.label28);
            this.groupBox5.Controls.Add(this.label27);
            this.groupBox5.Controls.Add(this.label26);
            this.groupBox5.Controls.Add(this.label25);
            this.groupBox5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.groupBox5.Location = new System.Drawing.Point(933, 478);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(207, 164);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Genre IDs";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(185, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "1 - Penguin Random House";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 58);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 20);
            this.label11.TabIndex = 1;
            this.label11.Text = "2 - Macmillian";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 84);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(156, 20);
            this.label14.TabIndex = 2;
            this.label14.Text = "3 - Simon and Schuster";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(14, 34);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(114, 20);
            this.label15.TabIndex = 0;
            this.label15.Text = "1 - Stephen King";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(14, 54);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(130, 20);
            this.label16.TabIndex = 1;
            this.label16.Text = "2 - Agatha Christie";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(14, 76);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(120, 20);
            this.label17.TabIndex = 2;
            this.label17.Text = "3 - Henric Middle";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(14, 96);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(111, 20);
            this.label18.TabIndex = 3;
            this.label18.Text = "4 - Jenna Taylor";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(13, 116);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(128, 20);
            this.label19.TabIndex = 4;
            this.label19.Text = "5 - Matthew Smith";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(14, 136);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(116, 20);
            this.label20.TabIndex = 5;
            this.label20.Text = "6 - Vanessa Mint";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(12, 156);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(111, 20);
            this.label21.TabIndex = 6;
            this.label21.Text = "7 - George Print";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(13, 176);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(117, 20);
            this.label22.TabIndex = 7;
            this.label22.Text = "8 - Nicolas Thick";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(14, 196);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(109, 20);
            this.label23.TabIndex = 8;
            this.label23.Text = "9 - Momo Mimi";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(6, 215);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(103, 20);
            this.label24.TabIndex = 9;
            this.label24.Text = "10 - Josuke Jos";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(14, 27);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(95, 20);
            this.label25.TabIndex = 0;
            this.label25.Text = "1 - Adventure";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(14, 47);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(84, 20);
            this.label26.TabIndex = 1;
            this.label26.Text = "2 - Comedy";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(14, 67);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(91, 20);
            this.label27.TabIndex = 2;
            this.label27.Text = "3 - Detective";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(14, 88);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(118, 20);
            this.label28.TabIndex = 3;
            this.label28.Text = "4 - Documentary";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(14, 108);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(76, 20);
            this.label29.TabIndex = 4;
            this.label29.Text = "5 - Drama";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(14, 128);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(73, 20);
            this.label30.TabIndex = 5;
            this.label30.Text = "6 - Horror";
            // 
            // MainPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1166, 662);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.booksListBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainPanel";
            this.Text = "MainPanel";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genreNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publisherNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagesNumeric)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button searchByNameBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button searchByAuthorBtn;
        private System.Windows.Forms.Button searchByGenreBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox booksListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown pagesNumeric;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown publisherNumeric;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown priceNumeric;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown yearNumeric;
        private System.Windows.Forms.CheckBox sagaCheckBox;
        private System.Windows.Forms.NumericUpDown authorNumeric;
        private System.Windows.Forms.NumericUpDown genreNumeric;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown idNumeric;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
    }
}