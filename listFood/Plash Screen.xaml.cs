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
            folder = folder.Remove(folder.IndexOf("bin"));
            dataFile = $"{folder}Data\\data.txt";
            var isChecked = File.ReadAllText(dataFile);
            InitializeComponent();
            if(isChecked == "true")
            {
                Home hr = new Home();
                hr.Show();
                this.Close();
            }
            else
            {
                dt.Tick += new EventHandler(dT_Tick);
                dt.Interval = new TimeSpan(0, 0, 5);
                dt.Start();
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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_StylusButtonDown(object sender, StylusButtonEventArgs e)
        {

        }

        private void ProgressBar_ColorChanged(object sender, RoutedPropertyChangedEventArgs<Color> e)
        {

        }
    }
}
