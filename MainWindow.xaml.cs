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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            
            InitializeComponent();
            comboBox.Items.Add("+");
            comboBox.Items.Add("-");
            comboBox.Items.Add("*");
            comboBox.Items.Add("/");

        }
         private void CheckBalance_btn(object sender, RoutedEventArgs e)
        {
            double a = Convert.ToDouble(firstVar_txtb.Text);
            double b = Convert.ToDouble(secondVar_txtb.Text);
            switch (Convert.ToString(comboBox.SelectedItem))
            {
                case "+":
                    resul_txtb.Text = Convert.ToString(a + b);
                    break;
                case "-":
                    resul_txtb.Text = Convert.ToString(a - b);
                    break;
                case "*":
                    resul_txtb.Text = Convert.ToString(a * b);
                    break;
                case "/":
                    resul_txtb.Text = Convert.ToString(a / b);
                    break;
            }

        }
    }
}
