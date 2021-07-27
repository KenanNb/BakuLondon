
namespace LondonBaku
{
    partial class timeLbl
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
            this.label1 = new System.Windows.Forms.Label();
            this.londonPxb = new System.Windows.Forms.PictureBox();
            this.bakuPxb = new System.Windows.Forms.PictureBox();
            this.londonBtn = new System.Windows.Forms.Button();
            this.bakuBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.londonPxb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bakuPxb)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(251, 105);
            this.label1.Margin = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Time";
            // 
            // londonPxb
            // 
            this.londonPxb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.londonPxb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.londonPxb.Cursor = System.Windows.Forms.Cursors.No;
            this.londonPxb.Image = global::LondonBaku.Properties.Resources.london_skyline;
            this.londonPxb.Location = new System.Drawing.Point(65, 177);
            this.londonPxb.Name = "londonPxb";
            this.londonPxb.Size = new System.Drawing.Size(286, 190);
            this.londonPxb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.londonPxb.TabIndex = 2;
            this.londonPxb.TabStop = false;
            this.londonPxb.Visible = false;
            // 
            // bakuPxb
            // 
            this.bakuPxb.Image = global::LondonBaku.Properties.Resources.Baku_Azerbaijan_Caspian_Sea;
            this.bakuPxb.Location = new System.Drawing.Point(449, 188);
            this.bakuPxb.Name = "bakuPxb";
            this.bakuPxb.Size = new System.Drawing.Size(268, 179);
            this.bakuPxb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bakuPxb.TabIndex = 3;
            this.bakuPxb.TabStop = false;
            this.bakuPxb.Visible = false;
            // 
            // londonBtn
            // 
            this.londonBtn.AutoSize = true;
            this.londonBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.londonBtn.Location = new System.Drawing.Point(149, 394);
            this.londonBtn.Name = "londonBtn";
            this.londonBtn.Size = new System.Drawing.Size(100, 35);
            this.londonBtn.TabIndex = 4;
            this.londonBtn.Text = "London";
            this.londonBtn.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.londonBtn.UseVisualStyleBackColor = true;
            this.londonBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.londonBtn_MouseClick);
            // 
            // bakuBtn
            // 
            this.bakuBtn.AutoSize = true;
            this.bakuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bakuBtn.Location = new System.Drawing.Point(502, 393);
            this.bakuBtn.Name = "bakuBtn";
            this.bakuBtn.Size = new System.Drawing.Size(115, 36);
            this.bakuBtn.TabIndex = 5;
            this.bakuBtn.Text = "Baku";
            this.bakuBtn.UseVisualStyleBackColor = true;
            this.bakuBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bakuBtn_MouseClick);
            // 
            // timeLbl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(29F, 55F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(790, 711);
            this.Controls.Add(this.bakuPxb);
            this.Controls.Add(this.londonPxb);
            this.Controls.Add(this.bakuBtn);
            this.Controls.Add(this.londonBtn);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(16, 13, 16, 13);
            this.Name = "timeLbl";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.timeLbl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.londonPxb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bakuPxb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox londonPxb;
        private System.Windows.Forms.PictureBox bakuPxb;
        private System.Windows.Forms.Button londonBtn;
        private System.Windows.Forms.Button bakuBtn;
    }
}

