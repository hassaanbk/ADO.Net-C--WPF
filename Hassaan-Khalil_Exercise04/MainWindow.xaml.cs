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

namespace Hassaan_Khalil_Exercise04
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var dbContext = new BooksEntities();

            var authorsAndTitles =
                from author in dbContext.Authors
                from book in author.Titles
                orderby book.Title1
                select new { book.Title1, book.EditionNumber, author.AuthorID, author.FirstName };
            outputTextBox.AppendText("Authors and Titles: ");

            foreach (var element in authorsAndTitles)
            {
                outputTextBox.AppendText($"\r\n\t{element.Title1,-50} {element.EditionNumber,30} {element.FirstName,-10} {element.AuthorID,-10}");
            }

            var authorsGrouped =
                from books in dbContext.Titles
                orderby books.Title1
                select new { Title = books.Title1,
                    Authors =
                        from author in books.Authors
                        orderby author.LastName, author.FirstName
                        select author.FirstName + " " + author.LastName

                };


            outputTextBox.AppendText("\r\n\r\nTitles and their Authors");

            foreach (var element in authorsGrouped)
            {

                outputTextBox.AppendText($"\r\n\t{element.Title}");

                foreach (var author in element.Authors)
                    outputTextBox.AppendText($"\r\n\t\t{author}");
            }
        }
    }
}
