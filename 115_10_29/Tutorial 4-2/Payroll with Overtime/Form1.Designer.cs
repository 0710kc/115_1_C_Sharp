        namespace Payroll_with_Overtime
{
    partial class Form1
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
        /// Required method for Designer support.
        /// </summary>
        private void InitializeComponent()
        {
            this.exitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.calculateButton = new System.Windows.Forms.Button();
            this.grossPayLabel = new System.Windows.Forms.Label();
            this.outputDescriptionLabel = new System.Windows.Forms.Label();
            this.hourlyPayRateTextBox = new System.Windows.Forms.TextBox();
            this.hoursWorkedTextBox = new System.Windows.Forms.TextBox();
            this.hourlyPayRatePromptLabel = new System.Windows.Forms.Label();
            this.hoursWorkedPromptLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft JhengHei", 18F);
            this.exitButton.Location = new System.Drawing.Point(500, 220);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(150, 55);
            this.exitButton.TabIndex = 26;
            this.exitButton.Text = "離開";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft JhengHei", 18F);
            this.clearButton.Location = new System.Drawing.Point(330, 220);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(150, 55);
            this.clearButton.TabIndex = 25;
            this.clearButton.Text = "清除";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Microsoft JhengHei", 18F);
            this.calculateButton.Location = new System.Drawing.Point(30, 220);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(280, 55);
            this.calculateButton.TabIndex = 24;
            this.calculateButton.Text = "計算總薪資";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // grossPayLabel
            // 
            this.grossPayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grossPayLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 18F);
            this.grossPayLabel.Location = new System.Drawing.Point(270, 155);
            this.grossPayLabel.Name = "grossPayLabel";
            this.grossPayLabel.Size = new System.Drawing.Size(380, 45);
            this.grossPayLabel.TabIndex = 23;
            this.grossPayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // outputDescriptionLabel
            // 
            this.outputDescriptionLabel.AutoSize = true;
            this.outputDescriptionLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 18F);
            this.outputDescriptionLabel.Location = new System.Drawing.Point(30, 160);
            this.outputDescriptionLabel.Name = "outputDescriptionLabel";
            this.outputDescriptionLabel.Size = new System.Drawing.Size(118, 31);
            this.outputDescriptionLabel.TabIndex = 22;
            this.outputDescriptionLabel.Text = "總薪資：";
            // 
            // hourlyPayRateTextBox
            // 
            this.hourlyPayRateTextBox.Font = new System.Drawing.Font("Microsoft JhengHei", 18F);
            this.hourlyPayRateTextBox.Location = new System.Drawing.Point(270, 95);
            this.hourlyPayRateTextBox.Name = "hourlyPayRateTextBox";
            this.hourlyPayRateTextBox.Size = new System.Drawing.Size(380, 39);
            this.hourlyPayRateTextBox.TabIndex = 21;
            // 
            // hoursWorkedTextBox
            // 
            this.hoursWorkedTextBox.Font = new System.Drawing.Font("Microsoft JhengHei", 18F);
            this.hoursWorkedTextBox.Location = new System.Drawing.Point(270, 35);
            this.hoursWorkedTextBox.Name = "hoursWorkedTextBox";
            this.hoursWorkedTextBox.Size = new System.Drawing.Size(380, 39);
            this.hoursWorkedTextBox.TabIndex = 20;
            // 
            // hourlyPayRatePromptLabel
            // 
            this.hourlyPayRatePromptLabel.AutoSize = true;
            this.hourlyPayRatePromptLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 18F);
            this.hourlyPayRatePromptLabel.Location = new System.Drawing.Point(30, 100);
            this.hourlyPayRatePromptLabel.Name = "hourlyPayRatePromptLabel";
            this.hourlyPayRatePromptLabel.Size = new System.Drawing.Size(202, 31);
            this.hourlyPayRatePromptLabel.TabIndex = 19;
            this.hourlyPayRatePromptLabel.Text = "每小時薪資：";
            // 
            // hoursWorkedPromptLabel
            // 
            this.hoursWorkedPromptLabel.AutoSize = true;
            this.hoursWorkedPromptLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 18F);
            this.hoursWorkedPromptLabel.Location = new System.Drawing.Point(30, 40);
            this.hoursWorkedPromptLabel.Name = "hoursWorkedPromptLabel";
            this.hoursWorkedPromptLabel.Size = new System.Drawing.Size(154, 31);
            this.hoursWorkedPromptLabel.TabIndex = 18;
            this.hoursWorkedPromptLabel.Text = "工作時數：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 320);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.grossPayLabel);
            this.Controls.Add(this.outputDescriptionLabel);
            this.Controls.Add(this.hourlyPayRateTextBox);
            this.Controls.Add(this.hoursWorkedTextBox);
            this.Controls.Add(this.hourlyPayRatePromptLabel);
            this.Controls.Add(this.hoursWorkedPromptLabel);
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 18F);
            this.Name = "Form1";
            this.Text = "加班薪資計算";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        internal System.Windows.Forms.Button exitButton;
        internal System.Windows.Forms.Button clearButton;
        internal System.Windows.Forms.Button calculateButton;
        internal System.Windows.Forms.Label grossPayLabel;
        internal System.Windows.Forms.Label outputDescriptionLabel;
        internal System.Windows.Forms.TextBox hourlyPayRateTextBox;
        internal System.Windows.Forms.TextBox hoursWorkedTextBox;
        internal System.Windows.Forms.Label hourlyPayRatePromptLabel;
        internal System.Windows.Forms.Label hoursWorkedPromptLabel;
    }
}

