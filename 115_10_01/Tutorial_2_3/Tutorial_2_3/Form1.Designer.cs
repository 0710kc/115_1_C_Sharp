namespace Tutorial_2_3
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
            this.label1 = new System.Windows.Forms.Label();
            this.translateLabel = new System.Windows.Forms.Label();
            this.italianButton = new System.Windows.Forms.Button();
            this.germanButton = new System.Windows.Forms.Button();
            this.spanishButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1048, 110);
            this.label1.TabIndex = 0;
            this.label1.Text = "選擇一個語言，我告訴你怎麼說「早安」";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // translateLabel
            // 
            this.translateLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.translateLabel.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.translateLabel.Location = new System.Drawing.Point(179, 187);
            this.translateLabel.Name = "translateLabel";
            this.translateLabel.Size = new System.Drawing.Size(647, 111);
            this.translateLabel.TabIndex = 1;
            this.translateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // italianButton
            // 
            this.italianButton.Font = new System.Drawing.Font("微軟正黑體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.italianButton.Location = new System.Drawing.Point(179, 425);
            this.italianButton.Name = "italianButton";
            this.italianButton.Size = new System.Drawing.Size(186, 81);
            this.italianButton.TabIndex = 2;
            this.italianButton.Text = "義大利";
            this.italianButton.UseVisualStyleBackColor = true;
            this.italianButton.Click += new System.EventHandler(this.italianButton_Click);
            // 
            // germanButton
            // 
            this.germanButton.Font = new System.Drawing.Font("微軟正黑體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.germanButton.Location = new System.Drawing.Point(640, 425);
            this.germanButton.Name = "germanButton";
            this.germanButton.Size = new System.Drawing.Size(186, 81);
            this.germanButton.TabIndex = 4;
            this.germanButton.Text = "德國";
            this.germanButton.UseVisualStyleBackColor = true;
            this.germanButton.Click += new System.EventHandler(this.germanButton_Click);
            // 
            // spanishButton
            // 
            this.spanishButton.Font = new System.Drawing.Font("微軟正黑體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.spanishButton.Location = new System.Drawing.Point(410, 425);
            this.spanishButton.Name = "spanishButton";
            this.spanishButton.Size = new System.Drawing.Size(186, 81);
            this.spanishButton.TabIndex = 5;
            this.spanishButton.Text = "西班牙";
            this.spanishButton.UseVisualStyleBackColor = true;
            this.spanishButton.Click += new System.EventHandler(this.spanishButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 642);
            this.Controls.Add(this.spanishButton);
            this.Controls.Add(this.germanButton);
            this.Controls.Add(this.italianButton);
            this.Controls.Add(this.translateLabel);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label translateLabel;
        private System.Windows.Forms.Button italianButton;
        private System.Windows.Forms.Button germanButton;
        private System.Windows.Forms.Button spanishButton;
    }
}

