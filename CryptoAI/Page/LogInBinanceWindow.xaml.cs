using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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
using Binance.Net;
using CryptoExchange.Net.Authentication;

namespace CryptoAI.Page
{
    /// <summary>
    /// Логика взаимодействия для LogInBinanceWindow.xaml
    /// </summary>
    public partial class LogInBinanceWindow : Window
    {
        public LogInBinanceWindow()
        {
            InitializeComponent();
        }

        private void tb_Secret_Key_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private async void btn_Done_Click(object sender, RoutedEventArgs e)
        {
            
        }

        
    }
}
