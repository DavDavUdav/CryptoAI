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
            string apiKey = "Your_API_Key";
            string secretKey = "Your_Secret_Key";

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
