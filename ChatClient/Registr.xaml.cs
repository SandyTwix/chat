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

namespace ChatClient
{
    /// <summary>
    /// Логика взаимодействия для Registr.xaml
    /// </summary>
    public partial class Registr : Window
    {
        MainWindow mainWindow = new MainWindow();
        MessageBoxPassword1 messageBoxPassword1 = new MessageBoxPassword1();
        MessageBoxPasswordExeption messageBoxPasswordExeption = new MessageBoxPasswordExeption();
        MessageBoxLoginExeption messageBoxLoginExeption = new MessageBoxLoginExeption();

        public Registr()
        {
            InitializeComponent();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void ButtonLogin_Click(object sender, RoutedEventArgs e)
        {
            if (LoginBox.Text.Length > 0)
            {
                if (PasswordBox.Password.Length > 0)      
                {

                    if (PasswordBox.Password == "12345")
                    {
                        mainWindow.Show();
                        this.Close();
                    }
                    else
                    {
                        messageBoxPassword1.Show();
                    }

                }
                else messageBoxPasswordExeption.Show(); 
            }

            else messageBoxLoginExeption.Show(); 

        }

        private void OnPreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            LoginBox.Text = "";
        }

        private void OnPreviewMouseDown1(object sender, MouseButtonEventArgs e)
        {
            PasswordBox.Password = "";
        }

        private void OnPreviewMouseDown2(object sender, MouseButtonEventArgs e)
        {
            ServerBox.Text = "";
        }

        private void OnPreviewMouseDown3(object sender, MouseButtonEventArgs e)
        {
            ClientBox.Text = "";
        }
    }
}
