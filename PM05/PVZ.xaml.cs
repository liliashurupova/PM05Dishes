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
    /// Логика взаимодействия для PVZ.xaml
    /// </summary>
    public partial class PVZ : Window
    {
        public PVZ()
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
            GlavnayaSTR wnd = new GlavnayaSTR();
            wnd.Show();
            this.Hide();
        }
    }
}
