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
    /// Логика взаимодействия для GlavnayaSTR.xaml
    /// </summary>
    public partial class GlavnayaSTR : Window
    {
        public GlavnayaSTR()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            KorzinaAVTORIZ wnd = new KorzinaAVTORIZ();
            wnd.Show();
            this.Hide();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            PVZ wnd = new PVZ();
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
