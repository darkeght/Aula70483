using BancoDeDadosinnerJoin.Model;
using Newtonsoft.Json;
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
using System.IO;

namespace BancoDeDadosinnerJoin
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        InnerJoinContext ctx = new InnerJoinContext();

        public MainWindow()
        {
            InitializeComponent();

            var vendas = ctx.Vendas;
            var carros = ctx.Carros;
            var marcas = ctx.Marcas;

            dataGrid.ItemsSource = (from ven in vendas
                                   join car in carros on ven.Carro equals car.Id
                                   join mar in marcas on car.Marca equals mar.Id
                                   select new
                                   {
                                       ven.Id,
                                       car.Modelo,
                                       Fabricante = mar.Nome,
                                       ValorTotal = ven.Quantidade * ven.Valor
                                   }).ToList();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            var template = @"
<html xmlns:o='urn: schemas - microsoft - com:office: office' xmlns:x='urn: schemas - microsoft - com:office: excel' xmlns='http://www.w3.org/TR/REC-html40'>
    < body>
        <table>
            <tr>
                <th>ID</th><th>Modelo</th><th>Fabricante</th><th>Valor Total</th>
            </tr>
            {0}
        </table>
    </body>
</html>";

            var templateDados = "<tr><td>{0}</td><td>{1}</td><td>{2}</td><td>{3}</td></tr>";
            var concatstring = "";

            var vendas = ctx.Vendas;
            var carros = ctx.Carros;
            var marcas = ctx.Marcas;

            var itemexportacao = (from ven in vendas
                                  join car in carros on ven.Carro equals car.Id
                                  join mar in marcas on car.Marca equals mar.Id
                                  select new
                                  {
                                      ven.Id,
                                      car.Modelo,
                                      Fabricante = mar.Nome,
                                      ValorTotal = ven.Quantidade * ven.Valor
                                  });

            foreach (var item in itemexportacao)
            {
                concatstring += string.Format(templateDados, item.Id, item.Modelo, item.Fabricante, item.ValorTotal);
            }

            File.WriteAllText(path + "//ExportacaoExcel.xls", string.Format(template, concatstring));
        }
    }
}
