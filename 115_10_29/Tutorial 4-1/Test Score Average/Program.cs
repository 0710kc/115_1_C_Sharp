using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Test_Score_Average
{
    static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            // 啟用 Windows Forms 的視覺樣式。
            Application.EnableVisualStyles();

            // 設定文字呈現方式與目前的 Windows Forms 相容。
            Application.SetCompatibleTextRenderingDefault(false);

            // 啟動主要表單。
            Application.Run(new Form1());
        }
    }
}
