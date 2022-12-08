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

namespace WpfAppBinding
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        UserData user;
        List<UserData> users;
        public MainWindow()
        {
            user = new UserData()
            {
                UserId = 1,
                Name = "user 1",
                Login = "user1",
                Birth = DateTime.Now
            };
            users = new List<UserData>();

            InitializeComponent();

            userGrid.DataContext = user;
            users.Add(user);
            users.Add(user);
            users.Add(user);
            listUserData.ItemsSource = users;

            ////Binding b = new Binding("Value");
            //Binding b = new Binding();
            //b.ElementName = "slider";
            //b.Path = new PropertyPath("Value");

            //text.SetBinding(TextBlock.FontSizeProperty, b);
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            //BindingOperations.ClearBinding(text, TextBlock.TextProperty);
            //text.Text = "Binding Clear!";
        }
    }
}
