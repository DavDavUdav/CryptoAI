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
    /// Логика взаимодействия для SuccessLoginWindow.xaml
    /// </summary>
    public partial class SuccessLoginWindow : Window
    {
        public SuccessLoginWindow()
        {
            InitializeComponent();
            this.Deactivated += SuccessLoginWindow_Deactivated;
        }

        private void SuccessLoginWindow_Deactivated(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
