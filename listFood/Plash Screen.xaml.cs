using listFood;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Windows.Threading;

namespace Test_Splash_Screen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer dt = new DispatcherTimer();

        public MainWindow()
        {
            InitializeComponent();
            dt.Tick += new EventHandler(dT_Tick);
            dt.Interval = new TimeSpan(0, 0, 3);
            dt.Start();
        }
        private void dT_Tick(object sender, EventArgs e)
        {
            Home hr = new Home();
            hr.Show();
            dt.Stop();
            this.Close();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Check(object sender, RoutedEventArgs e)
        {
           
        }
    }
}
