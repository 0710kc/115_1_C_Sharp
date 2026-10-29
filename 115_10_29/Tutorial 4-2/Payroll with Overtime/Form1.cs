using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll_with_Overtime
{
    public partial class Form1 : Form
    {
        // 建立表單並初始化所有元件。
        public Form1()
        {
            InitializeComponent();
        }

        // 計算員工的總薪資。
        private void calculateButton_Click(object sender, EventArgs e)
        {
            const int BASE_HOURS = 40; // 基本工時。
            const decimal OVERTIME_RATE = 1.5m; // 加班費率。
            decimal hoursWorked; // 工作時數。
            decimal hourlyPayRate; // 每小時薪資。
            decimal grossPay; // 總薪資。
            
            try
            {
                hoursWorked = decimal.Parse(hoursWorkedTextBox.Text);
                hourlyPayRate = decimal.Parse(hourlyPayRateTextBox.Text);

                // 計算總薪資。
                if (hoursWorked <= BASE_HOURS)
                {
                    grossPay = hoursWorked * hourlyPayRate;
                }
                else
                    {
                    decimal overtimeHours = hoursWorked - BASE_HOURS;
                    grossPay = (BASE_HOURS * hourlyPayRate) + (overtimeHours * hourlyPayRate * OVERTIME_RATE);
                }

                grossPayLabel.Text = grossPay.ToString("C");
            }
            catch (FormatException)
            {
                MessageBox.Show("請輸入有效的數字。", "輸入錯誤");
            }

        }

        // 清除輸入資料與計算結果。
        private void clearButton_Click(object sender, EventArgs e)
        {
            // 清除工作時數、每小時薪資與總薪資。
            hoursWorkedTextBox.Text = "";
            hourlyPayRateTextBox.Text = "";
            grossPayLabel.Text = "";

            // 將游標移回工作時數輸入框。
            hoursWorkedTextBox.Focus();
        }

        // 關閉目前的表單。
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉程式視窗。
            this.Close();
        }
    }
}
