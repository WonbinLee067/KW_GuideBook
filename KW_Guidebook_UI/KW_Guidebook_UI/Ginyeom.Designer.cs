﻿namespace KW_Guidebook_UI
{
    partial class Ginyeom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ginyeom));
            this.information_btn = new System.Windows.Forms.Button();
            this.Ginyeom_Lab_btn = new System.Windows.Forms.Button();
            this.ginyeom_label = new System.Windows.Forms.Label();
            this.Ginyeom_Map = new System.Windows.Forms.PictureBox();
            this.KWImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Ginyeom_Map)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KWImage)).BeginInit();
            this.SuspendLayout();
            // 
            // information_btn
            // 
            this.information_btn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.information_btn.Font = new System.Drawing.Font("Ink Free", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.information_btn.Image = ((System.Drawing.Image)(resources.GetObject("information_btn.Image")));
            this.information_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.information_btn.Location = new System.Drawing.Point(1094, 592);
            this.information_btn.Name = "information_btn";
            this.information_btn.Size = new System.Drawing.Size(158, 85);
            this.information_btn.TabIndex = 9;
            this.information_btn.Text = "Class\r\nDetails";
            this.information_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.information_btn.UseVisualStyleBackColor = false;
            this.information_btn.Click += new System.EventHandler(this.information_btn_Click);
            // 
            // Ginyeom_Lab_btn
            // 
            this.Ginyeom_Lab_btn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Ginyeom_Lab_btn.Font = new System.Drawing.Font("Ink Free", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ginyeom_Lab_btn.Image = ((System.Drawing.Image)(resources.GetObject("Ginyeom_Lab_btn.Image")));
            this.Ginyeom_Lab_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Ginyeom_Lab_btn.Location = new System.Drawing.Point(1094, 478);
            this.Ginyeom_Lab_btn.Name = "Ginyeom_Lab_btn";
            this.Ginyeom_Lab_btn.Size = new System.Drawing.Size(158, 85);
            this.Ginyeom_Lab_btn.TabIndex = 8;
            this.Ginyeom_Lab_btn.Text = "Lab";
            this.Ginyeom_Lab_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Ginyeom_Lab_btn.UseVisualStyleBackColor = false;
            this.Ginyeom_Lab_btn.Click += new System.EventHandler(this.Ginyeom_Lab_btn_Click);
            // 
            // ginyeom_label
            // 
            this.ginyeom_label.AutoSize = true;
            this.ginyeom_label.Font = new System.Drawing.Font("Ink Free", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ginyeom_label.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.ginyeom_label.Location = new System.Drawing.Point(492, 40);
            this.ginyeom_label.Name = "ginyeom_label";
            this.ginyeom_label.Size = new System.Drawing.Size(326, 99);
            this.ginyeom_label.TabIndex = 7;
            this.ginyeom_label.Text = "Ginyeom";
            // 
            // Ginyeom_Map
            // 
            this.Ginyeom_Map.Image = ((System.Drawing.Image)(resources.GetObject("Ginyeom_Map.Image")));
            this.Ginyeom_Map.Location = new System.Drawing.Point(50, 192);
            this.Ginyeom_Map.Name = "Ginyeom_Map";
            this.Ginyeom_Map.Size = new System.Drawing.Size(1017, 485);
            this.Ginyeom_Map.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ginyeom_Map.TabIndex = 6;
            this.Ginyeom_Map.TabStop = false;
            // 
            // KWImage
            // 
            this.KWImage.Image = ((System.Drawing.Image)(resources.GetObject("KWImage.Image")));
            this.KWImage.Location = new System.Drawing.Point(1155, 12);
            this.KWImage.Name = "KWImage";
            this.KWImage.Size = new System.Drawing.Size(121, 118);
            this.KWImage.TabIndex = 11;
            this.KWImage.TabStop = false;
            // 
            // Ginyeom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1288, 713);
            this.Controls.Add(this.KWImage);
            this.Controls.Add(this.information_btn);
            this.Controls.Add(this.Ginyeom_Lab_btn);
            this.Controls.Add(this.ginyeom_label);
            this.Controls.Add(this.Ginyeom_Map);
            this.Name = "Ginyeom";
            this.Text = "Ginyeom";
            ((System.ComponentModel.ISupportInitialize)(this.Ginyeom_Map)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KWImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button information_btn;
        private System.Windows.Forms.Button Ginyeom_Lab_btn;
        private System.Windows.Forms.Label ginyeom_label;
        private System.Windows.Forms.PictureBox Ginyeom_Map;
        private System.Windows.Forms.PictureBox KWImage;
    }
}