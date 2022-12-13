﻿using System;
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

namespace WpfAppTemplates1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<ToDoClass> listToDo;
        public MainWindow()
        {
            listToDo = new ObservableCollection<ToDoClass>();
            MakeTemplatesData();
            InitializeComponent();

            lstToDo.ItemsSource = listToDo;
        }

        private void MakeTemplatesData()
        {
            for (int i = 0; i < 5; i++)
            {
                listToDo.Add(
                    new ToDoClass()
                    {
                        Id = i + 1,
                        Title = "Task " + (i + 1),
                        Description = $"Make templates in WPF ({i})",
                        Deadline = DateTime.Now
                    });
            }
        }
    }
}
