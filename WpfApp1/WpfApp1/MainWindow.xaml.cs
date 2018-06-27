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
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        int P = 0;
        int N = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Plusbtn_MouseDown(object sender, MouseButtonEventArgs e)
        {
            PlusItem item = new PlusItem();

            // 將項目加入名單
            TodoList.Children.Add(item);

            //自動輸入日期
            item.date.Text = DateTime.Now.ToString("M / dd");
        }

        private void close_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void Window_Closed(object sender, EventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Window_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {

            foreach ((PlusItem item in TodoList.Children)
            {
                P += item.PPri;
            }

        }


        private void Minusbtn_MouseDown(object sender, MouseButtonEventArgs e)

        {
        MinusItem item = new MinusItem();

        // 將項目加入名單
        TodoList.Children.Add(item);

        //自動輸入日期
        item.date.Text = DateTime.Now.ToString("M / dd");

        }


        private void Window_GotFocus(object sender, RoutedEventArgs e)
        {

            foreach (MinusItem item in TodoList.Children)

            {
                N -= item.MPri;
            }

            // 寫到總支出

            Money.Text = (P + N).ToString();

        }
    }
}
