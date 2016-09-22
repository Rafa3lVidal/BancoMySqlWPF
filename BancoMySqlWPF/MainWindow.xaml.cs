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
/// <summary>
using System.Data;
using MySql.Data.MySqlClient; 
    
    /// </summary>

namespace BancoMySqlWPF
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnTestar_Click(object sender, RoutedEventArgs e)
        {
            string cs = @"server=localhost;
                         userid=root;
                         password=;
                         database=bacon";
        }
    }
}
