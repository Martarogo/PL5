using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace MathClientWpf
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Prime(object sender, RoutedEventArgs e)
        {
            // Se instancia el proxy
            MathService.MathClient client = new MathService.MathClient();

            int iValue;
            Int32.TryParse(nInput.Text, out iValue);
            
            // Se invoca el servicio
            bool result = client.Prime(iValue);
            if (result == true) resultLabel.Content = "Es primo";
            else resultLabel.Content = "No es primo";
        }

        private void Sum(object sender, RoutedEventArgs e)
        {
            MathService.MathClient client = new MathService.MathClient();

            String stringInput = tupleInput.Text;

            String spaces = @"\s+";

            stringInput = Regex.Replace(stringInput.Trim(), spaces, " ");

            String[] inputStringNumbers = stringInput.Split(new char[] { ' ' });

            double[] inputNumbers = new double[inputStringNumbers.Length];

            for (int i = 0; i < inputStringNumbers.Length; i++)
            {
                inputNumbers[i] = Double.Parse(inputStringNumbers[i]);
            }

            MathService.Tuple inputTuple = new MathClientWpf.MathService.Tuple();

            inputTuple.Data = inputNumbers;

            MathService.Tuple outputTuple = client.Sum(inputTuple);

            sumResult.Content = outputTuple.Data[0];
        }

        private void System2ec(object sender, RoutedEventArgs z)
        {
            MathService.MathClient client = new MathService.MathClient();

            int a, b, c, d, e, f;
            Int32.TryParse(a1.Text, out a);
            Int32.TryParse(b1.Text, out b);
            Int32.TryParse(c1.Text, out c);
            Int32.TryParse(d1.Text, out d);
            Int32.TryParse(e1.Text, out e);
            Int32.TryParse(f1.Text, out f);

            double[] result = client.SolveSystem(new double[] { a, b, c, d, e, f });

            label1.Content = result[0];
            label2.Content = result[1];
        }

        private void System3ec(object sender, RoutedEventArgs z)
        {
            MathService.MathClient client = new MathService.MathClient();

            int a, b, c, d, e, f, g, h, i, j, k, l;
            Int32.TryParse(a2.Text, out a);
            Int32.TryParse(b2.Text, out b);
            Int32.TryParse(c2.Text, out c);
            Int32.TryParse(d2.Text, out d);
            Int32.TryParse(e2.Text, out e);
            Int32.TryParse(f2.Text, out f);
            Int32.TryParse(g2.Text, out g);
            Int32.TryParse(h2.Text, out h);
            Int32.TryParse(i2.Text, out i);
            Int32.TryParse(j2.Text, out j);
            Int32.TryParse(k2.Text, out k);
            Int32.TryParse(l2.Text, out l);

            double[] result = client.SolveSystem(new double[] { a, b, c, d, e, f, g, h, i, j, k, l });

            label3.Content = result[0];
            label4.Content = result[1];
            label5.Content = result[2];
        }

    }
}
