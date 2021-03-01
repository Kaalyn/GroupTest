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
        double calculatedValue;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void plus_Click(object sender, RoutedEventArgs e)
        {
            double input1 = Convert.ToInt32(value1.Text);
            double input2 = Convert.ToInt32(value2.Text);

            calculatedValue = input1 + input2;

            results.Text = calculatedValue.ToString();
        }
    }
}
