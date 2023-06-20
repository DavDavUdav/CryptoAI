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
    /// Логика взаимодействия для FailedLoginWindow.xaml
    /// </summary>
    public partial class FailedLoginWindow : Window
    {
        public FailedLoginWindow()
        {
            InitializeComponent();
            this.Deactivated += FailedLoginWindow_Deactivated;
        }

        private void FailedLoginWindow_Deactivated(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
