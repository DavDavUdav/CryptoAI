using Kucoin.Net.Clients;
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
    /// Логика взаимодействия для LogInKucoinWindow.xaml
    /// </summary>
    public partial class LogInKucoinWindow : Window
    {
        public LogInKucoinWindow()
        {
            InitializeComponent();
        }

        private async void btn_Done_Click(object sender, RoutedEventArgs e)
        {
            
            GetAccount(tb_API_Key.Text, tb_Secret_Key.Text, tb_Api_Passphraze.Text);
        }

        // Получение данных аккаунта
        public async void GetAccount(string apiKey, string secretKey, string apiPassphraze)
        {
            var kucoinRestClient = new KucoinRestClient(options =>
            {
                options.ApiCredentials = new Kucoin.Net.Objects.KucoinApiCredentials(apiKey, secretKey, apiPassphraze);
            });

            var accountData = await kucoinRestClient.SpotApi.Account.GetAccountsAsync();

            //todo: убрать MessageBox.
            MessageBox.Show(accountData.Data.ToString());
        }
    }
}
