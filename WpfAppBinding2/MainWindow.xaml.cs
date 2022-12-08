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

namespace WpfAppBinding2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private BookRepository bookRepository;
        public MainWindow()
        {
            bookRepository = new BookRepository();

            InitializeComponent();

            ObjectDataProvider provider = new ObjectDataProvider();
            provider.ObjectInstance = bookRepository;
            provider.MethodName = "GetBooks";
            Binding binding = new Binding()
            {
                Source = provider,
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged
            };

            lstBooks.SetBinding(ListBox.ItemsSourceProperty, binding);
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (lstBooks.SelectedIndex == -1)
                return;

            int id = lstBooks.SelectedIndex;
            bookRepository.GetBooks().RemoveAt(id);
            if (id > 0)
                lstBooks.SelectedIndex = id - 1;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            var books = bookRepository.GetBooks();
            int id = books.Count + 1;
            books.Add(new Book() { BookId = id, Name = "Book " + id });
            lstBooks.SelectedIndex = books.Count - 1;
        }
    }
}
