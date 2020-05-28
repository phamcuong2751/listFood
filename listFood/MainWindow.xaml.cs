﻿using Syncfusion.XlsIO;
using System;
using System.Collections.Generic;
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
namespace listFood
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Home : Window
    {
        public class Food
        {
            public int ID { get; set; }
            public string nameOfFood { get; set; }
            public string howToFood { get; set; }
        }
        public Home()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// new code




        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            List<Food> listFoods = new List<Food>();
            try
            {
                // mở file excel
                var package = new ExcelPackage(new FileInfo("\\data\\listFood.xlsx"));
                // lấy ra sheet đầu tiên để thao tác
                ExcelWorksheet workSheet = package.Workbook.Worksheets[1];
            }
        }
    }
}

