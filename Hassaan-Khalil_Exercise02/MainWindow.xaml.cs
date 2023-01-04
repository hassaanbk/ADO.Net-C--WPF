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

namespace Hassaan_Khalil_Exercise02
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double subtotal = 0;
        private double discount = 0;
        private double tax = 0;


        public MainWindow()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            output.Content = $"{name.Text} you will be charged ${subtotal*discount*tax}";
        }

        private void seniorRadio_Checked(object sender, RoutedEventArgs e)
        {
            discount = 0.90;
        }

        private void province_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (province.SelectedItem.ToString() == "Ontario 13%")
                tax = 1.13;
            else if (province.SelectedItem.ToString() == "Alberta 7%")
                tax = 1.07;
            else
                tax = 1.06;
        }

        private void youthRadio_Checked(object sender, RoutedEventArgs e)
        {
            discount = 0.85;
        }

        private void adultRadio_Checked(object sender, RoutedEventArgs e)
        {
            discount = 1;
        }

        private void flossingCheck_Checked(object sender, RoutedEventArgs e)
        {
            subtotal += 20;
        }

        private void fillingCheck_Checked(object sender, RoutedEventArgs e)
        {
            subtotal += 75;
        }

        private void rootCheck_Checked(object sender, RoutedEventArgs e)
        {
            subtotal += 150;
        }
    }
}
