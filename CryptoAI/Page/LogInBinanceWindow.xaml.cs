using System.Net.Http;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Microsoft.Extensions.Logging;
using Nethereum.HdWallet;

using Binance.Net;
using Binance.Net.Clients;
using Binance.Net.Objects;
using CryptoExchange.Net.Authentication;
using System;

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
            this.Deactivated += LogInBinance_Deactivated;
        }

        private void LogInBinance_Deactivated(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tb_Secret_Key_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private async void btn_Done_Click(object sender, RoutedEventArgs e)
        {
            string apiKey = tb_API_Key.Text;
            string secretKey = tb_Secret_Key.Text;

            GetAccount(apiKey, secretKey);
        }

        // Получение данных аккаунта
        public void GetAccount(string apiKey, string secretKey)
        {
            // Создание клиента Binance с авторизацией
            var client = new BinanceClient(new BinanceClientOptions()
            {
                ApiCredentials = new BinanceApiCredentials(apiKey, secretKey)
            });

            // Пример выполнения запроса
            var accountInfo = client.SpotApi.Account.GetAccountInfoAsync();

            //todo: убрать MessageBox.

            if (accountInfo.IsCompleted)
            {
                MessageBox.Show("Авторизация успешна!");
                // Добавьте дополнительную логику работы с данными аккаунта
            }
            else
            {
                MessageBox.Show("Ошибка авторизации: " + accountInfo.Exception.Message.ToString());
            }
        }

    }
}
