﻿namespace KW_Guidebook_UI
{
    partial class Yeongu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Yeongu));
            this.information_btn = new System.Windows.Forms.Button();
            this.Hwado_Lab_btn = new System.Windows.Forms.Button();
            this.yeongu_label = new System.Windows.Forms.Label();
            this.Hwado_Map = new System.Windows.Forms.PictureBox();
            this.KWImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Hwado_Map)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KWImage)).BeginInit();
            this.SuspendLayout();
            // 
            // information_btn
            // 
            this.information_btn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.information_btn.Font = new System.Drawing.Font("Ink Free", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.information_btn.Image = ((System.Drawing.Image)(resources.GetObject("information_btn.Image")));
            this.information_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.information_btn.Location = new System.Drawing.Point(1089, 576);
            this.information_btn.Name = "information_btn";
            this.information_btn.Size = new System.Drawing.Size(158, 85);
            this.information_btn.TabIndex = 9;
            this.information_btn.Text = "Class\r\nDetails";
            this.information_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.information_btn.UseVisualStyleBackColor = false;
            this.information_btn.Click += new System.EventHandler(this.information_btn_Click);
            // 
            // Hwado_Lab_btn
            // 
            this.Hwado_Lab_btn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Hwado_Lab_btn.Font = new System.Drawing.Font("Ink Free", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hwado_Lab_btn.Image = ((System.Drawing.Image)(resources.GetObject("Hwado_Lab_btn.Image")));
            this.Hwado_Lab_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Hwado_Lab_btn.Location = new System.Drawing.Point(1089, 462);
            this.Hwado_Lab_btn.Name = "Hwado_Lab_btn";
            this.Hwado_Lab_btn.Size = new System.Drawing.Size(158, 85);
            this.Hwado_Lab_btn.TabIndex = 8;
            this.Hwado_Lab_btn.Text = "Lab";
            this.Hwado_Lab_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Hwado_Lab_btn.UseVisualStyleBackColor = false;
            this.Hwado_Lab_btn.Click += new System.EventHandler(this.Hwado_Lab_btn_Click);
            // 
            // yeongu_label
            // 
            this.yeongu_label.AutoSize = true;
            this.yeongu_label.Font = new System.Drawing.Font("Ink Free", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yeongu_label.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.yeongu_label.Location = new System.Drawing.Point(542, 36);
            this.yeongu_label.Name = "yeongu_label";
            this.yeongu_label.Size = new System.Drawing.Size(278, 99);
            this.yeongu_label.TabIndex = 7;
            this.yeongu_label.Text = "Yeongu";
            // 
            // Hwado_Map
            // 
            this.Hwado_Map.Image = ((System.Drawing.Image)(resources.GetObject("Hwado_Map.Image")));
            this.Hwado_Map.Location = new System.Drawing.Point(37, 174);
            this.Hwado_Map.Name = "Hwado_Map";
            this.Hwado_Map.Size = new System.Drawing.Size(1016, 487);
            this.Hwado_Map.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Hwado_Map.TabIndex = 6;
            this.Hwado_Map.TabStop = false;
            // 
            // KWImage
            // 
            this.KWImage.Image = ((System.Drawing.Image)(resources.GetObject("KWImage.Image")));
            this.KWImage.Location = new System.Drawing.Point(1155, 17);
            this.KWImage.Name = "KWImage";
            this.KWImage.Size = new System.Drawing.Size(121, 118);
            this.KWImage.TabIndex = 11;
            this.KWImage.TabStop = false;
            // 
            // Yeongu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1288, 713);
            this.Controls.Add(this.KWImage);
            this.Controls.Add(this.information_btn);
            this.Controls.Add(this.Hwado_Lab_btn);
            this.Controls.Add(this.yeongu_label);
            this.Controls.Add(this.Hwado_Map);
            this.Name = "Yeongu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeongu";
            ((System.ComponentModel.ISupportInitialize)(this.Hwado_Map)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KWImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button information_btn;
        private System.Windows.Forms.Button Hwado_Lab_btn;
        private System.Windows.Forms.Label yeongu_label;
        private System.Windows.Forms.PictureBox Hwado_Map;
        private System.Windows.Forms.PictureBox KWImage;
    }
}