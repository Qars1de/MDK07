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
    /// Логика взаимодействия для PageBugai.xaml
    /// </summary>
    public partial class PageBugai : Window
    {
        public PageBugai()
        {
            InitializeComponent();
        }

        private void Kirillov_Click(object sender, RoutedEventArgs e)
        {
            PageTikhonov tichonov = new PageTikhonov();
            tichonov.Show();
            this.Close();
        }

        private void Tichonov_Click(object sender, RoutedEventArgs e)
        {
            PageTikhonov tichonov = new PageTikhonov();
            tichonov.Show();
            this.Close();
        }
    }
}
