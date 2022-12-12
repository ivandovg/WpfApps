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

namespace WpfAppTriggers1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            if (button == null)
                return;

            string tag = button.Tag.ToString();

            switch (tag)
            {
                case "ok":
                    edText.Text += "press Ok" + Environment.NewLine;
                    break;
                case "cancel":
                    edText.Text += "press cancel" + Environment.NewLine;
                    break;
                default:
                    edText.Text += "unknown button";
                    break;
            }
        }
    }
}
