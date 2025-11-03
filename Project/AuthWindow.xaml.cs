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

namespace Project
{
    /// <summary>
    /// Логика взаимодействия для AuthWindows.xaml
    /// </summary>
    public partial class AuthWindows : Window
    {
        public AuthWindows()
        {
            InitializeComponent();
        }

        private void LeftBtnMousePositionWindow(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void BtnAuthorization(object sender, RoutedEventArgs e)
        {

            var btn = sender as Button;
            btn.IsDefault = false; // сбросить состояние



            if (TextBoxLogin.Text == "admin" && TextBoxPassword.Password == "admin")
            {
                ToolWindow toolWindow = new ToolWindow();

                this.Close();
                toolWindow.Show();
            }
            else
            {
                MessageBox.Show("Вы не вошли!");
            }

            btn.IsDefault = true;

        }
    }
}