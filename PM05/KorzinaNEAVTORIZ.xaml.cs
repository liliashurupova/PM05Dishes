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

namespace PM05
{
    /// <summary>
    /// Логика взаимодействия для KorzinaNEAVTORIZ.xaml
    /// </summary>
    public partial class KorzinaNEAVTORIZ : Window
    {
        public KorzinaNEAVTORIZ()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow wnd = new MainWindow();
            wnd.Show();
            this.Hide();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Vxod wnd = new Vxod();
            wnd.Show();
            this.Hide();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Vxod wnd = new Vxod();
            wnd.Show();
            this.Hide();
        }
    }
}
