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

namespace WpfAppStylesDynamic
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            List<string> styles = new List<string>();
            styles.Add("light");
            styles.Add("dark");

            InitializeComponent();
            cmbSwitchTheme.SelectionChanged += CmbSwitchTheme_SelectionChanged;
            cmbSwitchTheme.ItemsSource = styles;
            cmbSwitchTheme.SelectedItem = "dark";
        }

        private void CmbSwitchTheme_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string style = cmbSwitchTheme.SelectedItem.ToString();
            Uri uri = new Uri(style + ".xaml", UriKind.Relative);
            // load resources
            ResourceDictionary dictionary = Application.LoadComponent(uri) as ResourceDictionary;
            // clear old resources
            Application.Current.Resources.Clear();
            // apply new resources
            Application.Current.Resources.MergedDictionaries.Add(dictionary);
        }
    }
}
