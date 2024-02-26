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
    /// Логика взаимодействия для PageTikhonov.xaml
    /// </summary>
    public partial class PageTikhonov : Window
    {
        public PageTikhonov()
        {
            InitializeComponent();
        }

        private void Bugai_Click(object sender, RoutedEventArgs e)
        {
            PageBugai bugai = new PageBugai();
            bugai.Show();
            this.Close();
        }

        private void Kirillov_Click(object sender, RoutedEventArgs e)
        {
            PageKirillov kirillov = new PageKirillov();
            kirillov.Show();
            this.Close();
        }

        

        
    }
}
