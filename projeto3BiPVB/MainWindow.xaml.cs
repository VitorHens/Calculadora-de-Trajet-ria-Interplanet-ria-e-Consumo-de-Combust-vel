using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProjetoWagner3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void calculo_Click(object sender, RoutedEventArgs e)
        {
            int totalLinhas = dados.LineCount;
            double semi = 0;
            double tempo = 0;
            double gSol = 1.327 * Math.Pow(10, 11);
            double v1 = 0;
            double v2 = 0;
            double vT = 0;
            double r1 = 0;
            double r2 = 0;
            double mN = 0;
            double massaC = 0;

            for (int i = 0; i < totalLinhas ; i++)
            {
                double n = double.Parse(dados.GetLineText(i));

                if (i == 0)
                    r1 = n * 1000000;
                else if (i == 1)
                {
                    r2 = n * 1000000;

                    semi = (r1 + r2) / 2;
                    tempo = (Math.PI * Math.Sqrt(Math.Pow(semi, 3) / gSol)) / 86400;

                    v1 = Math.Sqrt(gSol / r1) * (Math.Sqrt((2 * r2) / (r1 + r2)) - 1);
                    v2 = Math.Sqrt(gSol / r2) * (1 - Math.Sqrt((2 * r1) / (r1 + r2)));
                    vT = Math.Abs(v1) + Math.Abs(v2);



                }
                else if (i == 2)
                    mN = n;
                else if (i == 3)
                    massaC = mN * (Math.Pow(2.71828, (vT * 1000) / (n * 9.81)) - 1);
            }

            resul.Content = String.Format
                            ("Tempo:{0:0} dias  ({1:0.0} meses) ", Math.Truncate(tempo), tempo / 30) +
                            "\nDelta-V: ~" + vT.ToString("N3") +
                            " km/s\nCombustível: ~" + massaC.ToString("N2") + String.Format(" kg ({0:G} t)", Math.Round(massaC / 1000, 2));

        }

        private void limpar_Click(object sender, RoutedEventArgs e)
        {
            dados.Text = "Digite a distância do corpo de origem:\nDigite a distância do corpo de destino:\nMassa da espaçonave:\nImpulso específico do motor: ";
            resul.Content = "";

        }

        private void dados_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}