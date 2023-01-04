using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
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

namespace Hassaan_Khalil_Exercise05
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

        private BooksEntities dbContext = new BooksEntities();
        private ObservableCollection<Title> books= new ObservableCollection<Title>();

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            dbContext.Authors
                .OrderBy(author => author.LastName)
                .ThenBy(author => author.FirstName)
                .Load();

            authorBindingSource.ItemsSource = dbContext.Authors.Local;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //string comb = comboBox.SelectedIndex;
            if (comboBox.SelectedIndex == 0)
            {
                //dbContext.Titles
                //                    .Where(book => book.EditionNumber > 5)
                //                    .Load();
               // authorBindingSource.ItemsSource = dbContext.Titles.Local;
               // authorBindingSource.ItemsSource = dbContext.Titles.Where(book => book.EditionNumber >= 5).ToList<Title>;
               books.Clear();
               var filter = from book in dbContext.Titles
                            where book.EditionNumber >= 5
                            select book;
                foreach(var title in filter)
                    books.Add(title);
                authorBindingSource.ItemsSource = books;

                
            }

            else
            {
                //dbContext.Titles
                //                    .Where(titles => titles.Title1.Contains("Java"))
                //                    .Load();
                //authorBindingSource.ItemsSource = dbContext.Titles.Local;
                books.Clear();
                var filter = from book in dbContext.Titles
                             where book.Title1.Contains("Java")
                             select book;
                foreach (var title in filter)
                    books.Add(title);
                authorBindingSource.ItemsSource = books;
            }

        }
    }
}
