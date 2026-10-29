using System;
using System.Windows.Forms;

namespace Loan_Qualifier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            // 初始化表單上的所有元件。
            InitializeComponent();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
           const decimal MIN_SALARY = 40000m; // 最低年收入
           const int MIN_YEARS = 2; // 最低工作年資
            // 取得使用者輸入的年收入及工作年資。
            decimal salary;
            int yearsOnJob;
            
            try
            {
                salary = decimal.Parse(salaryTextBox.Text);
                yearsOnJob = int.Parse(yearsTextBox.Text);

                // 判斷使用者是否符合貸款資格。
                if (salary >= MIN_SALARY)
                                    {
                    if (yearsOnJob >= MIN_YEARS)
                    {
                        decisionLabel.Text = "符合貸款資格";
                    }
                    else
                    {
                        decisionLabel.Text = "薪資符合但年資不符合貸款資格";
                    }
                }
                else
                {
                    decisionLabel.Text = "薪資不符合貸款資格";
                }

            }
            catch (Exception ex)
            {
                // 顯示錯誤訊息。
                MessageBox.Show(ex.Message);
            }

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // 清除年收入、工作年資及貸款決定結果。
            salaryTextBox.Text = "";
            yearsTextBox.Text = "";
            decisionLabel.Text = "";

            // 將游標移回年收入輸入框。
            salaryTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉目前的表單。
            Close();
        }
    }
}

/// <summary>
/// 設計工具所需的元件變數。
/// </summary>

/// <summary>
/// 釋放使用中的資源。
/// </summary>

/// <param name="disposing">指定是否要釋放受管理的資源。</param>

#region Windows Form 設計工具產生的程式碼

/// <summary>
/// 設計工具支援所需的方法。
/// </summary>
/// <remarks>
/// 請勿使用程式碼編輯器修改此方法的內容。
/// </remarks>
#endregion