namespace Tutorial_2_4
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.finlandPictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.finlandPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // finlandPictureBox1
            // 
            this.finlandPictureBox1.Image = global::Tutorial_2_4.Properties.Resources.Finland;
            this.finlandPictureBox1.Location = new System.Drawing.Point(94, 80);
            this.finlandPictureBox1.Name = "finlandPictureBox1";
            this.finlandPictureBox1.Size = new System.Drawing.Size(274, 157);
            this.finlandPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.finlandPictureBox1.TabIndex = 0;
            this.finlandPictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.finlandPictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.finlandPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox finlandPictureBox1;
    }
}

