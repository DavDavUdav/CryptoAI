using CryptoAI.Page;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CryptoAI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btn_site_Click()
        {

        }

        private void btn_site_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_language_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_License_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_My_Bots_Click(object sender, RoutedEventArgs e)
        {
            ErrorSectionWindow errorSectionWindow = new ErrorSectionWindow();
            errorSectionWindow.WindowStartupLocation= WindowStartupLocation.CenterScreen;
            errorSectionWindow.Show();
        }

        private void btn_Profile_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_Login_Click(object sender, RoutedEventArgs e)
        {
            LogInWindow logInWindow = new LogInWindow();
            logInWindow.WindowStartupLocation= WindowStartupLocation.CenterScreen;
            logInWindow.Show();

        }

        private void btn_info_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_HelpCenter_Click(object sender, RoutedEventArgs e)
        {
            HelpingCenterWindow helpingCenterWindow = new HelpingCenterWindow();
            helpingCenterWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            helpingCenterWindow.Show();
        }
    }
}
