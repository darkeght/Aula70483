using ExercicioPessoaMaiorIdade.CLasses;
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

namespace ExercicioPessoaMaiorIdade
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            dataGrid.ItemsSource = Pessoas;
        }

        List<Pessoa> Pessoas = new List<Pessoa>
        {
            new Pessoa()
            {
                NomeCompleto = "Felipe Junir Machado",
                DataNascimento = DateTime.Parse("08/03/1992")
            },
            new Pessoa()
            {
                NomeCompleto = "Josevaldo Irneudson Adagoberto",
                DataNascimento = DateTime.Parse("08/03/1982")
            },
            new Pessoa()
            {
                NomeCompleto = "Xiaomi Lite 6 Mi8 128g",
                DataNascimento = DateTime.Parse("08/03/2015")
            }
        };
    }
}
