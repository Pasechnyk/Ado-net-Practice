
namespace MusicApp
{
    partial class MusicApplication
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
            this.playlistBox = new System.Windows.Forms.ListBox();
            this.addPlBtn = new System.Windows.Forms.Button();
            this.mostListenedBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.top3Btn = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(62, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Music Database Application";
            // 
            // playlistBox
            // 
            this.playlistBox.FormattingEnabled = true;
            this.playlistBox.ItemHeight = 20;
            this.playlistBox.Location = new System.Drawing.Point(31, 229);
            this.playlistBox.Name = "playlistBox";
            this.playlistBox.Size = new System.Drawing.Size(452, 184);
            this.playlistBox.TabIndex = 1;
            this.playlistBox.SelectedIndexChanged += new System.EventHandler(this.PlaylistBoxSelectedIndexChanged);
            // 
            // addPlBtn
            // 
            this.addPlBtn.Location = new System.Drawing.Point(370, 42);
            this.addPlBtn.Name = "addPlBtn";
            this.addPlBtn.Size = new System.Drawing.Size(113, 40);
            this.addPlBtn.TabIndex = 2;
            this.addPlBtn.Text = "Add Playlist";
            this.addPlBtn.UseVisualStyleBackColor = true;
            this.addPlBtn.Click += new System.EventHandler(this.AddPlBtnClick);
            // 
            // mostListenedBtn
            // 
            this.mostListenedBtn.Location = new System.Drawing.Point(50, 108);
            this.mostListenedBtn.Name = "mostListenedBtn";
            this.mostListenedBtn.Size = new System.Drawing.Size(113, 54);
            this.mostListenedBtn.TabIndex = 3;
            this.mostListenedBtn.Text = "Most Listened To Track";
            this.mostListenedBtn.UseVisualStyleBackColor = true;
            this.mostListenedBtn.Click += new System.EventHandler(this.MostListenedTrackBtnClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(343, 108);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 54);
            this.button2.TabIndex = 4;
            this.button2.Text = "Find Tracks by Word";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.FindTracksByPartBtnClick);
            // 
            // top3Btn
            // 
            this.top3Btn.Location = new System.Drawing.Point(197, 108);
            this.top3Btn.Name = "top3Btn";
            this.top3Btn.Size = new System.Drawing.Size(113, 54);
            this.top3Btn.TabIndex = 5;
            this.top3Btn.Text = "Top 3 Tracks by Singer";
            this.top3Btn.UseVisualStyleBackColor = true;
            this.top3Btn.Click += new System.EventHandler(this.Top3BtnClick);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(286, 178);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(125, 27);
            this.searchTextBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Enter names for search:";
            // 
            // MusicApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 429);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.top3Btn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.mostListenedBtn);
            this.Controls.Add(this.addPlBtn);
            this.Controls.Add(this.playlistBox);
            this.Controls.Add(this.label1);
            this.Name = "MusicApplication";
            this.Text = "Music App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox playlistBox;
        private System.Windows.Forms.Button addPlBtn;
        private System.Windows.Forms.Button mostListenedBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button top3Btn;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label label2;
    }
}

