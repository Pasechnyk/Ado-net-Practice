﻿
namespace ShopAdministration
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
            this.shopListBox = new System.Windows.Forms.ListBox();
            this.productInfoBtn = new System.Windows.Forms.Button();
            this.shopList = new System.Windows.Forms.ListBox();
            this.workerInfoBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(151, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Shop Administration";
            // 
            // shopListBox
            // 
            this.shopListBox.FormattingEnabled = true;
            this.shopListBox.ItemHeight = 20;
            this.shopListBox.Location = new System.Drawing.Point(55, 172);
            this.shopListBox.Name = "shopListBox";
            this.shopListBox.Size = new System.Drawing.Size(472, 244);
            this.shopListBox.TabIndex = 1;
            // 
            // productInfoBtn
            // 
            this.productInfoBtn.Location = new System.Drawing.Point(151, 107);
            this.productInfoBtn.Name = "productInfoBtn";
            this.productInfoBtn.Size = new System.Drawing.Size(130, 50);
            this.productInfoBtn.TabIndex = 2;
            this.productInfoBtn.Text = "DIsplay Product Information";
            this.productInfoBtn.UseVisualStyleBackColor = true;
            this.productInfoBtn.Click += new System.EventHandler(this.ProductInfoBtnClick);
            // 
            // shopList
            // 
            this.shopList.FormattingEnabled = true;
            this.shopList.ItemHeight = 20;
            this.shopList.Items.AddRange(new object[] {
            "Trash"});
            this.shopList.Location = new System.Drawing.Point(106, 66);
            this.shopList.Name = "shopList";
            this.shopList.Size = new System.Drawing.Size(353, 24);
            this.shopList.TabIndex = 3;
            this.shopList.SelectedIndexChanged += new System.EventHandler(this.ShopListSelectedIndexChanged);
            // 
            // workerInfoBtn
            // 
            this.workerInfoBtn.Location = new System.Drawing.Point(299, 107);
            this.workerInfoBtn.Name = "workerInfoBtn";
            this.workerInfoBtn.Size = new System.Drawing.Size(130, 50);
            this.workerInfoBtn.TabIndex = 4;
            this.workerInfoBtn.Text = "DIsplay Worker Information";
            this.workerInfoBtn.UseVisualStyleBackColor = true;
            this.workerInfoBtn.Click += new System.EventHandler(this.WorkerInfoBtnClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 450);
            this.Controls.Add(this.workerInfoBtn);
            this.Controls.Add(this.shopList);
            this.Controls.Add(this.productInfoBtn);
            this.Controls.Add(this.shopListBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox shopListBox;
        private System.Windows.Forms.Button productInfoBtn;
        private System.Windows.Forms.ListBox shopList;
        private System.Windows.Forms.Button workerInfoBtn;
    }
}

