using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Hassaan_Khalil_Exercise03
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
 
    public partial class MainWindow : Window
    {
        private ObservableCollection<MenuItem> items = new ObservableCollection<MenuItem>();
        private double bill = 0;
        public MainWindow()
        {
            InitializeComponent();
            data.ItemsSource = items;
            
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            items.Add(new MenuItem()
            {
                Name = "Buffalo Wings",
                Category = "Appetizer",
                Price = 5.96
            });
            bill += 5.96;
            bill = bill * 1.13;
            total.Content = $"Your total is ${bill}";
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            items.Add(new MenuItem()
            {
                Name = "Buffalo Fingers",
                Category = "Appetizer",
                Price = 6.95
            });
            bill += 6.95;
            bill = bill * 1.13;
            total.Content = $"Your total is ${bill}";
        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {
            items.Add(new MenuItem()
            {
                Name = "Potato Skins",
                Category = "Appetizer",
                Price = 8.95
            });
            bill += 8.95;
            bill = bill * 1.13;
            total.Content = $"Your total is ${bill}";
        }

        private void RadioButton_Checked_3(object sender, RoutedEventArgs e)
        {
            items.Add(new MenuItem()
            {
                Name = "Nachos",
                Category = "Appetizer",
                Price = 8.95
            });
            bill += 8.95;
            bill = bill * 1.13;
            total.Content = $"Your total is ${bill}";
        }

        private void RadioButton_Checked_4(object sender, RoutedEventArgs e)
        {
            items.Add(new MenuItem()
            {
                Name = "Mushroom Caps",
                Category = "Appetizer",
                Price = 10.95
            });
            bill += 10.95;
            bill = bill * 1.13;
            total.Content = $"Your total is ${bill}";
        }

        private void RadioButton_Checked_5(object sender, RoutedEventArgs e)
        {
            items.Add(new MenuItem()
            {
                Name = "Shrimp Cocktails",
                Category = "Appetizer",
                Price = 12.95
            });

            bill += 12.95;
            bill = bill * 1.13;
            total.Content = $"Your total is ${bill}";
        }

        private void RadioButton_Checked_6(object sender, RoutedEventArgs e)
        {
            items.Add(new MenuItem()
            {
                Name = "Chips and Salsa",
                Category = "Appetizer",
                Price = 6.95
            });
            bill += 6.95;
            bill = bill * 1.13;
            total.Content = $"Your total is ${bill}";
        }

        private void RadioButton_Checked_7(object sender, RoutedEventArgs e)
        {
            items.Add(new MenuItem()
            {
                Name = "Apple Pie",
                Category = "Dessert",
                Price = 5.95
            });
            bill += 5.95;
            bill = bill * 1.13;
            total.Content = $"Your total is ${bill}";
        }

        private void RadioButton_Checked_8(object sender, RoutedEventArgs e)
        {
            items.Add(new MenuItem()
            {
                Name = "Sundae",
                Category = "Dessert",
                Price = 3.95
            });
            bill += 3.95;
            bill = bill * 1.13;
            total.Content = $"Your total is ${bill}";
        }

        private void RadioButton_Checked_9(object sender, RoutedEventArgs e)
        {
            items.Add(new MenuItem()
            {
                Name = "Carrot Cake",
                Category = "Dessert",
                Price = 5.95
            });
            bill += 5.95;
            bill = bill * 1.13;
            total.Content = $"Your total is ${bill}";
        }

        private void RadioButton_Checked_10(object sender, RoutedEventArgs e)
        {
            items.Add(new MenuItem()
            {
                Name = "Mud Pie",
                Category = "Dessert",
                Price = 4.95
            });
            bill += 4.95;
            bill = bill * 1.13;
            total.Content = $"Your total is ${bill}";
        }

        private void RadioButton_Checked_11(object sender, RoutedEventArgs e)
        {
            items.Add(new MenuItem()
            {
                Name = "Apple Crisp",
                Category = "Dessert",
                Price = 5.95
            });
            bill += 5.95;
            bill = bill * 1.13;
            total.Content = $"Your total is ${bill}";
        }

        private void RadioButton_Checked_12(object sender, RoutedEventArgs e)
        {
            items.Add(new MenuItem()
            {
                Name = "Soda",
                Category = "Beverage",
                Price = 1.95
            });
            bill += 1.95;
            bill = bill * 1.13;
            total.Content = $"Your total is ${bill}";
        }

        private void RadioButton_Checked_13(object sender, RoutedEventArgs e)
        {
            items.Add(new MenuItem()
            {
                Name = "Tea",
                Category = "Beverage",
                Price = 1.50
            });
            bill += 1.50;
            bill = bill * 1.13;
            total.Content = $"Your total is ${bill}";
        }

        private void RadioButton_Checked_14(object sender, RoutedEventArgs e)
        {
            items.Add(new MenuItem()
            {
                Name = "Coffee",
                Category = "Beverage",
                Price = 1.25
            });
            bill += 1.25;
            bill = bill * 1.13;
            total.Content = $"Your total is ${bill}";
        }

        private void RadioButton_Checked_15(object sender, RoutedEventArgs e)
        {
            items.Add(new MenuItem()
            {
                Name = "Mineral Water",
                Category = "Beverage",
                Price = 2.95
            });
            bill += 2.95;
            bill = bill * 1.13;
            total.Content = $"Your total is ${bill}";
        }

        private void RadioButton_Checked_16(object sender, RoutedEventArgs e)
        {
            items.Add(new MenuItem()
            {
                Name = "Juice",
                Category = "Beverage",
                Price = 2.50
            });
            bill += 2.50;
            bill = bill * 1.13;
            total.Content = $"Your total is ${bill}";
        }

        private void RadioButton_Checked_17(object sender, RoutedEventArgs e)
        {
            items.Add(new MenuItem()
            {
                Name = "Milk",
                Category = "Beverage",
                Price = 1.50
            });
            bill += 1.50;
            bill = bill * 1.13;
            total.Content = $"Your total is ${bill}";
        }

        private void RadioButton_Checked_18(object sender, RoutedEventArgs e)
        {
            items.Add(new MenuItem()
            {
                Name = "Seafood Alfredo",
                Category = "Main Course",
                Price = 15.95
            });
            bill += 15.95;
            bill = bill * 1.13;
            total.Content = $"Your total is ${bill}";
        }

        private void RadioButton_Checked_19(object sender, RoutedEventArgs e)
        {
            items.Add(new MenuItem()
            {
                Name = "Chicken Alfredo",
                Category = "Main Course",
                Price = 13.95
            });
            bill += 13.95;
            bill = bill * 1.13;
            total.Content = $"Your total is ${bill}";
        }

        private void RadioButton_Checked_20(object sender, RoutedEventArgs e)
        {
            items.Add(new MenuItem()
            {
                Name = "Chicken Picatta",
                Category = "Main Course",
                Price = 13.95
            });
            bill += 13.95;
            bill = bill * 1.13;
            total.Content = $"Your total is ${bill}";
        }

        private void RadioButton_Checked_21(object sender, RoutedEventArgs e)
        {
            items.Add(new MenuItem()
            {
                Name = "Turkey Club",
                Category = "Main Course",
                Price = 11.95
            });
            bill += 11.95;
            bill = bill * 1.13;
            total.Content = $"Your total is ${bill}";
        }

        private void RadioButton_Checked_22(object sender, RoutedEventArgs e)
        {
            items.Add(new MenuItem()
            {
                Name = "Lobstar Pie",
                Category = "Main Course",
                Price = 19.95
            });
            bill += 19.95;
            bill = bill * 1.13;
            total.Content = $"Your total is ${bill}";
        }

        private void RadioButton_Checked_23(object sender, RoutedEventArgs e)
        {
            items.Add(new MenuItem()
            {
                Name = "Prime Rib",
                Category = "Main Course",
                Price = 20.95
            });
            bill += 20.95;
            bill = bill * 1.13;
            total.Content = $"Your total is ${bill}";
        }

        private void RadioButton_Checked_24(object sender, RoutedEventArgs e)
        {
            items.Add(new MenuItem()
            {
                Name = "Shrimp Scampi",
                Category = "Main Course",
                Price = 18.95
            });
            bill += 18.95;
            bill = bill * 1.13;
            total.Content = $"Your total is ${bill}";
        }

        private void RadioButton_Checked_25(object sender, RoutedEventArgs e)
        {
            items.Add(new MenuItem()
            {
                Name = "Turkey Dinner",
                Category = "Main Course",
                Price = 13.95
            });
            bill += 13.95;
            bill = bill * 1.13;
            total.Content = $"Your total is ${bill}";
        }

        private void RadioButton_Checked_26(object sender, RoutedEventArgs e)
        {
            items.Add(new MenuItem()
            {
                Name = "Stuffed Chicken",
                Category = "Main Course",
                Price = 14.95
            });
            bill += 14.95;
            bill = bill * 1.13;
            total.Content = $"Your total is ${bill}";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            items.Clear();
            bill = 0;
            total.Content = $"Your total is ${bill}";
        }
    }
    
}
