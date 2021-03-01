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

namespace GroupTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double total;
        char operation = '0';

        public MainWindow()
        {
            InitializeComponent();
        }

        private void plus_Click(object sender, RoutedEventArgs e)
        {
            // get number
            // insert control condition
            double.TryParse(input.Text, out double number);

            if (operation != '0')
            {
                // put number + sign in textbox
                results.Text = total + " " + ((Button)sender).Content + " " + number.ToString() + " =\n" + results.Text;
            }

            calculate(number, (Button)sender);

            results.Text = total + results.Text;

            input.Text = total.ToString();

            operation = '+'; //plus
        }

        private double calculate(double number, Button button)
        {
            switch (operation)
            {
                case '+':
                    total += number;
                    break;
                case '-':
                    break;
                case '*':
                    break;
                case '/':
                    break;
                case '²':
                    break;
                case 'V':
                    break;
                default:
                    break;
            }

            return total;
        }
    }
}
