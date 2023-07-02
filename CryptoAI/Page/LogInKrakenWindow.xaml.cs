using CryptoExchange.Net.Authentication;
using Kraken.Net.Clients;
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
    /// Логика взаимодействия для LogInKrakenWindow.xaml
    /// </summary>
    public partial class LogInKrakenWindow : Window
    {
        public LogInKrakenWindow()
        {
            InitializeComponent();
        }

        private async void btn_Done_Click(object sender, RoutedEventArgs e)
        {
            var krakenRestClient = new KrakenRestClient(options =>
            {
                options.ApiCredentials = new ApiCredentials(tb_API_Key.Text, tb_Secret_Key.Text);
                options.RequestTimeout = TimeSpan.FromSeconds(60);
            });

            var balanceData = await krakenRestClient.SpotApi.Account.GetBalancesAsync();
            
            //todo: убрать MessageBox.
            MessageBox.Show(balanceData.Data.ToString());
        }
    }
}
