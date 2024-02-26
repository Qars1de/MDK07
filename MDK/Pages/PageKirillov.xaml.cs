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
using System.Windows.Shapes;

namespace MDK.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageKirillov.xaml
    /// </summary>
    public partial class PageKirillov : Window
    {
        public PageKirillov()
        {
            InitializeComponent();
        }

        private void Bugai_Click(object sender, RoutedEventArgs e)
        {
            PageBugai bugai = new PageBugai();
            bugai.Show();
            this.Close();
        }

        private void Tikhonov_Click(object sender, RoutedEventArgs e)
        {
            PageTikhonov tichonov = new PageTikhonov();
            tichonov.Show();
            this.Close();
        }
    }
}
