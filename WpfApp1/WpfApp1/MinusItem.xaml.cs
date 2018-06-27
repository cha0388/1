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
    /// MinusItem.xaml 的互動邏輯
    /// </summary>
    public partial class MinusItem : UserControl
    {
        public MinusItem()
        {
            InitializeComponent();
        }

        // 宣告變數Pri
        public int MPri
        {
            get
            {
                // 測試能否將輸入的文字轉為數字(輸入的是否是數字)
                try
                {
                    return int.Parse(MPrice.Text);
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
                MPrice.Text = value.ToString();
            }
        }
    }
}
