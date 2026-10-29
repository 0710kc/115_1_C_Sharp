namespace Loan_Qualifier
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.salaryPromptLabel = new System.Windows.Forms.Label();
            this.yearsPromptLabel = new System.Windows.Forms.Label();
            this.salaryTextBox = new System.Windows.Forms.TextBox();
            this.yearsTextBox = new System.Windows.Forms.TextBox();
            this.outputDescriptionLabel = new System.Windows.Forms.Label();
            this.decisionLabel = new System.Windows.Forms.Label();
            this.checkButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // salaryPromptLabel
            // 
            this.salaryPromptLabel.AutoSize = true;
            this.salaryPromptLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F);
            this.salaryPromptLabel.Location = new System.Drawing.Point(40, 30);
            this.salaryPromptLabel.Name = "salaryPromptLabel";
            this.salaryPromptLabel.Size = new System.Drawing.Size(110, 30);
            this.salaryPromptLabel.TabIndex = 0;
            this.salaryPromptLabel.Text = "年收入：";
            // 
            // yearsPromptLabel
            // 
            this.yearsPromptLabel.AutoSize = true;
            this.yearsPromptLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F);
            this.yearsPromptLabel.Location = new System.Drawing.Point(40, 90);
            this.yearsPromptLabel.Name = "yearsPromptLabel";
            this.yearsPromptLabel.Size = new System.Drawing.Size(206, 30);
            this.yearsPromptLabel.TabIndex = 1;
            this.yearsPromptLabel.Text = "目前工作年資：";
            // 
            // salaryTextBox
            // 
            this.salaryTextBox.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F);
            this.salaryTextBox.Location = new System.Drawing.Point(270, 24);
            this.salaryTextBox.Name = "salaryTextBox";
            this.salaryTextBox.Size = new System.Drawing.Size(280, 38);
            this.salaryTextBox.TabIndex = 2;
            // 
            // yearsTextBox
            // 
            this.yearsTextBox.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F);
            this.yearsTextBox.Location = new System.Drawing.Point(270, 84);
            this.yearsTextBox.Name = "yearsTextBox";
            this.yearsTextBox.Size = new System.Drawing.Size(280, 38);
            this.yearsTextBox.TabIndex = 3;
            // 
            // outputDescriptionLabel
            // 
            this.outputDescriptionLabel.AutoSize = true;
            this.outputDescriptionLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F);
            this.outputDescriptionLabel.Location = new System.Drawing.Point(40, 150);
            this.outputDescriptionLabel.Name = "outputDescriptionLabel";
            this.outputDescriptionLabel.Size = new System.Drawing.Size(158, 30);
            this.outputDescriptionLabel.TabIndex = 4;
            this.outputDescriptionLabel.Text = "貸款決定：";
            // 
            // decisionLabel
            // 
            this.decisionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.decisionLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F);
            this.decisionLabel.Location = new System.Drawing.Point(40, 195);
            this.decisionLabel.Name = "decisionLabel";
            this.decisionLabel.Size = new System.Drawing.Size(510, 55);
            this.decisionLabel.TabIndex = 5;
            this.decisionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkButton
            // 
            this.checkButton.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F);
            this.checkButton.Location = new System.Drawing.Point(40, 280);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(170, 60);
            this.checkButton.TabIndex = 6;
            this.checkButton.Text = "檢查資格";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F);
            this.clearButton.Location = new System.Drawing.Point(225, 280);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(140, 60);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "清除";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F);
            this.exitButton.Location = new System.Drawing.Point(380, 280);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(170, 60);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "離開";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 380);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.decisionLabel);
            this.Controls.Add(this.outputDescriptionLabel);
            this.Controls.Add(this.yearsTextBox);
            this.Controls.Add(this.salaryTextBox);
            this.Controls.Add(this.yearsPromptLabel);
            this.Controls.Add(this.salaryPromptLabel);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F);
            this.Name = "Form1";
            this.Text = "貸款資格審核";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label salaryPromptLabel;
        private System.Windows.Forms.Label yearsPromptLabel;
        private System.Windows.Forms.TextBox salaryTextBox;
        private System.Windows.Forms.TextBox yearsTextBox;
        private System.Windows.Forms.Label outputDescriptionLabel;
        private System.Windows.Forms.Label decisionLabel;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

