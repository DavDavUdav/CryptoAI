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
    /// Логика взаимодействия для LogInWindow.xaml
    /// </summary>
    public partial class LogInWindow : Window
    {
        public LogInWindow()
        {
            InitializeComponent();
            this.Deactivated += LogInWindow_Deactivated;
        }

        private void LogInWindow_Deactivated(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ColdWalletLogin_Click(object sender, RoutedEventArgs e)
        {
            LogInColdWalletWindow logInColdWalletWindow = new LogInColdWalletWindow();
            logInColdWalletWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            logInColdWalletWindow.Show();
        }

        private void btn_KucoinLogin_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_KrakenLogin_Click(object sender, RoutedEventArgs e)
        {
            LogInKrakenWindow logInKrakenWindow = new LogInKrakenWindow();
            logInKrakenWindow.Show();
        }

        private void btn_BinanceLogin_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
