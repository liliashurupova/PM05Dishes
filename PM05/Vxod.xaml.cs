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
    /// Логика взаимодействия для Vxod.xaml
    /// </summary>
    public partial class Vxod : Window
    {
        public Vxod()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            KorzinaNEAVTORIZ wnd = new KorzinaNEAVTORIZ();
            wnd.Show();
            this.Hide();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (TextBox.Text == "281av0@gmail.com" && TextBox1.Text == "LdNyos")
            {
                GlavnayaSTR main = new GlavnayaSTR();
                main.Show();
                this.Hide();
            }
            else if (TextBox.Text == "281av0@gmail.com" && TextBox1.Text != "LdNyos")
            {
                MessageBox.Show("Неверный логин и пароль!");
            }
            else if (TextBox.Text == "281av0@gmail.com" && TextBox1.Text == "LdNyos")
            {
                MessageBox.Show("Неверный логин и пароль!");
            }
            else if (TextBox.Text == "281av0@gmail.com" && TextBox1.Text != "LdNyos")
            {
                MessageBox.Show("Неверный логин и пароль!");
            }


            if (TextBox.Text == "8edmfh@outlook.com" && TextBox1.Text == "gynQMT")
            {
                GlavnayaSTR main = new GlavnayaSTR();
                main.Show();
                this.Hide();
            }
            else if (TextBox.Text == "8edmfh@outlook.com" && TextBox1.Text != "gynQMT")
            {
                MessageBox.Show("Неверный логин и пароль!");
            }
            else if (TextBox.Text == "8edmfh@outlook.com" && TextBox1.Text == "gynQMT")
            {
                MessageBox.Show("Неверный логин и пароль!");
            }
            else if (TextBox.Text == "8edmfh@outlook.com" && TextBox1.Text != "gynQMT")
            {
                MessageBox.Show("Неверный логин и пароль!");
            }


            if (TextBox.Text == "sfn13i@mail.ru" && TextBox1.Text == "AtnDjr")
            {
                GlavnayaSTR main = new GlavnayaSTR();
                main.Show();
                this.Hide();
            }
            else if (TextBox.Text == "sfn13i@mail.ru" && TextBox1.Text != "AtnDjr")
            {
                MessageBox.Show("Неверный логин и пароль!");
            }
            else if (TextBox.Text == "sfn13i@mail.ru" && TextBox1.Text == "AtnDjr")
            {
                MessageBox.Show("Неверный логин и пароль!");
            }
            else if (TextBox.Text == "sfn13i@mail.ru" && TextBox1.Text != "AtnDjr")
            {
                MessageBox.Show("Неверный логин и пароль!");
            }


            if (TextBox.Text == "sfn13i@mail.ru" && TextBox1.Text == "JlFRCZ")
            {
                GlavnayaSTR main = new GlavnayaSTR();
                main.Show();
                this.Hide();
            }
            else if (TextBox.Text == "g0orc3x1@outlook.com" && TextBox1.Text != "JlFRCZ")
            {
                MessageBox.Show("Неверный логин и пароль!");
            }
            else if (TextBox.Text == "g0orc3x1@outlook.com" && TextBox1.Text == "JlFRCZ")
            {
                MessageBox.Show("Неверный логин и пароль!");
            }
            else if (TextBox.Text == "g0orc3x1@outlook.com" && TextBox1.Text != "JlFRCZ")
            {
                MessageBox.Show("Неверный логин и пароль!");
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MainWindow wnd = new MainWindow();
            wnd.Show();
            this.Hide();
        }
    }
}
