
namespace MusicApp
{
    partial class AddTrack
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
            this.addTrackBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.songNumeric = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.singerTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.genreTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rateNumeric = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.countNumeric = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.lyricsTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.songNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rateNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // addTrackBtn
            // 
            this.addTrackBtn.Location = new System.Drawing.Point(50, 410);
            this.addTrackBtn.Name = "addTrackBtn";
            this.addTrackBtn.Size = new System.Drawing.Size(113, 43);
            this.addTrackBtn.TabIndex = 0;
            this.addTrackBtn.Text = "Add a Track";
            this.addTrackBtn.UseVisualStyleBackColor = true;
            this.addTrackBtn.Click += new System.EventHandler(this.AddTrackBtnClick);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(197, 410);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(117, 43);
            this.cancelBtn.TabIndex = 1;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.CancelBtnClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(95, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Add New Track";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Title";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(95, 95);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(232, 27);
            this.titleTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Duration";
            // 
            // songNumeric
            // 
            this.songNumeric.Location = new System.Drawing.Point(123, 180);
            this.songNumeric.Name = "songNumeric";
            this.songNumeric.Size = new System.Drawing.Size(204, 27);
            this.songNumeric.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Singer";
            // 
            // singerTextBox
            // 
            this.singerTextBox.Location = new System.Drawing.Point(95, 138);
            this.singerTextBox.Name = "singerTextBox";
            this.singerTextBox.Size = new System.Drawing.Size(232, 27);
            this.singerTextBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Genre";
            // 
            // genreTextBox
            // 
            this.genreTextBox.Location = new System.Drawing.Point(95, 219);
            this.genreTextBox.Name = "genreTextBox";
            this.genreTextBox.Size = new System.Drawing.Size(232, 27);
            this.genreTextBox.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Rate";
            // 
            // rateNumeric
            // 
            this.rateNumeric.Location = new System.Drawing.Point(95, 262);
            this.rateNumeric.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.rateNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.rateNumeric.Name = "rateNumeric";
            this.rateNumeric.Size = new System.Drawing.Size(232, 27);
            this.rateNumeric.TabIndex = 12;
            this.rateNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 306);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Listening Count";
            // 
            // countNumeric
            // 
            this.countNumeric.Location = new System.Drawing.Point(165, 304);
            this.countNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.countNumeric.Name = "countNumeric";
            this.countNumeric.Size = new System.Drawing.Size(162, 27);
            this.countNumeric.TabIndex = 14;
            this.countNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 345);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Lyrics";
            // 
            // lyricsTextBox
            // 
            this.lyricsTextBox.Location = new System.Drawing.Point(95, 345);
            this.lyricsTextBox.Multiline = true;
            this.lyricsTextBox.Name = "lyricsTextBox";
            this.lyricsTextBox.Size = new System.Drawing.Size(232, 45);
            this.lyricsTextBox.TabIndex = 16;
            // 
            // AddTrack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 465);
            this.Controls.Add(this.lyricsTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.countNumeric);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rateNumeric);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.genreTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.singerTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.songNumeric);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.addTrackBtn);
            this.Name = "AddTrack";
            this.Text = "AddTrack";
            ((System.ComponentModel.ISupportInitialize)(this.songNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rateNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addTrackBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown songNumeric;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox singerTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox genreTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown rateNumeric;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown countNumeric;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox lyricsTextBox;
    }
}