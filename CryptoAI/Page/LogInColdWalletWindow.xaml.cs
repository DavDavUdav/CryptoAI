using Nethereum.HdWallet;
using Nethereum.Web3.Accounts;
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
    /// Логика взаимодействия для LogInColdWalletWindow.xaml
    /// </summary>
    public partial class LogInColdWalletWindow : Window
    {
        public LogInColdWalletWindow()
        {
            InitializeComponent();
        }

        private void btn_Done_Click(object sender, RoutedEventArgs e)
        {
            string mnemonicPhrase = tb_mnemonicPhraze.Text;

            GetAccount(mnemonicPhrase);
        }

        // Получение данных от аккаунта
        public void GetAccount(string mnemonicPhrase)
        {
            // Созданике массива байтов из мнемонической фразы.
            byte[] seed = Encoding.UTF8.GetBytes(tb_mnemonicPhraze.Text);
            
            // Создание кошелька на основе мнемонической фразы
            var wallet = new Wallet(seed);

            // Получение адреса первого кошелька
            var address = wallet.GetAddresses(3);

            Console.WriteLine($"Адрес кошелька: {address}");

            // Создание объекта Account с использованием мнемонической фразы
            var account = new Account(mnemonicPhrase);

            this.Close();
        }
    }
}
