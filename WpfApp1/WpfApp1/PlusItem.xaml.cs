using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// PlusItem.xaml 的互動邏輯
    /// </summary>
    public partial class PlusItem : UserControl
    {
        public PlusItem()
        {
            InitializeComponent();
        }

        // 宣告變數Pri
        public int PPri
        {
            get
            {
                // 測試能否將輸入的文字轉為數字(輸入的是否是數字)
                try
                {
                    return int.Parse(PPrice.Text);
                }
                // 失敗後跳出提示
                catch
                {
                    MessageBox.Show("請輸入數字");
                    return 0;
                }
            }
            set
            {
                PPrice.Text = value.ToString();
            }
        }
    }
}
