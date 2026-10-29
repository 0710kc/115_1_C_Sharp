using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Score_Average
{
    /// <summary>
    /// 測驗成績平均值表單。
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// 建立表單並初始化所有視窗元件。
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 按下「計算平均值」按鈕時執行。
        /// </summary>
        /// <param name="sender">觸發事件的元件。</param>
        /// <param name="e">事件相關資料。</param>
        private void calculateButton_Click(object sender, EventArgs e)
        {
            // 此處可加入讀取三個測驗成績並計算平均值的程式碼。
        }

        /// <summary>
        /// 按下「清除」按鈕時，清除所有輸入內容與平均值。
        /// </summary>
        /// <param name="sender">觸發事件的元件。</param>
        /// <param name="e">事件相關資料。</param>
        private void clearButton_Click(object sender, EventArgs e)
        {
            // 清除三個測驗成績輸入框的內容。
            test1TextBox.Text = "";
            test2TextBox.Text = "";
            test3TextBox.Text = "";

            // 清除平均值顯示內容。
            averageLabel.Text = "";

            // 將游標移回第一個測驗成績輸入框。
            test1TextBox.Focus();
        }

        /// <summary>
        /// 按下「離開」按鈕時關閉表單。
        /// </summary>
        /// <param name="sender">觸發事件的元件。</param>
        /// <param name="e">事件相關資料。</param>
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉目前的表單。
            this.Close();
        }
    }
}
