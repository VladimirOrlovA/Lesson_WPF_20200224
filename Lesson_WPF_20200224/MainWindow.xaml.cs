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

namespace Lesson_WPF_20200224
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TabItem_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void TabItem_PreviewMouseUp_1(object sender, MouseButtonEventArgs e)
        {
            second.Content = first.Content;


            // WPF <--> BLL (buisness logic level) <--> DAL (data access level)
            // WPF <--> BLL (buisness logic level) WPFname.BLL <--> DAL (data access level) WPFname.DAL
            // Repository Metanit читать!!! DTO  ---- https://metanit.com/sharp/articles/mvc/11.php

            // ctrl tab - между вкладками

            // liteDB viewer - программа просмотра
            #region
//wwwwwwwwwwwwwwwww
//                wwwwwwwwwwwwww
//                wwwwwwwwwwwww
//                wwwwwwwwwww

            #endregion

        }
    }
}
