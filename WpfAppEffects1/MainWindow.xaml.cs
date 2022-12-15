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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfAppEffects1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            //DoubleAnimation daWidth = new DoubleAnimation();
            //daWidth.From = btnAnimateTest.ActualWidth;
            ////da.To = da.From + 100;
            //daWidth.By = 100;
            //daWidth.Duration = TimeSpan.FromSeconds(5);
            //daWidth.AutoReverse = true;

            //DoubleAnimation daHeight = new DoubleAnimation();
            //daHeight.From = btnAnimateTest.ActualHeight;
            //daHeight.By = 30;
            //daHeight.Duration = TimeSpan.FromSeconds(3);
            //daHeight.AutoReverse = true;

            //btnAnimateTest.BeginAnimation(Button.WidthProperty, daWidth);
            //btnAnimateTest.BeginAnimation(Button.HeightProperty, daHeight);
        }
    }
}
