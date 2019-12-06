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

namespace MinhaPrimeiraCLasse
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

        List<Pessoa> Pessoas = new List<Pessoa>
        {
            new Pessoa()
            {
                Nome = "Felipe",
                Idade = 27
            },
            new Pessoa()
            {
                Nome = "Giomar",
                Idade = 45
            }
        };

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            dataGrid.ItemsSource = Pessoas;
        }
    }
}
