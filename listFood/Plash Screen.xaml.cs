using listFood;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
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
        ObservableCollection<string> newChecked = new ObservableCollection<string>();
        string dataFile = "";
        public MainWindow()
        {
            string folder = AppDomain.CurrentDomain.BaseDirectory; // "C:\Users\dev\"
            dataFile = $"{folder}data.txt";
            var isChecked = File.ReadAllText(dataFile);
            InitializeComponent();
            if(isChecked == "false")
            {
                dt.Tick += new EventHandler(dT_Tick);
                dt.Interval = new TimeSpan(0, 0, 5);
                dt.Start();
            }
            else
            {
                Home hr = new Home();
                hr.Show();
                this.Close();
            }
           
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
           if(Change.IsChecked == true)
            {
                string newData = "true";
                File.WriteAllText(dataFile, newData);
            }
            else
            {
                string newData = "fasle";
                File.WriteAllText(dataFile, newData);
            }
        }



        private void Window_Closing(object sender, EventArgs e)
        {
            
        }
    }
}
