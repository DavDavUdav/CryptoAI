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

namespace CryptoAI.Page
{
    /// <summary>
    /// Логика взаимодействия для ErrorSectionWindow.xaml
    /// </summary>
    public partial class ErrorSectionWindow : Window
    {
        public ErrorSectionWindow()
        {
            InitializeComponent();
            this.Deactivated += ErrorSectionWindow_Deactivated;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            LogInWindow logInWindow = new LogInWindow();
            logInWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            logInWindow.Show();
        }

        private void ErrorSectionWindow_Deactivated(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
