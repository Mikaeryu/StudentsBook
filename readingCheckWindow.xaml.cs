﻿using System;
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
using System.Windows.Shapes;

namespace StudentsBook
{
    /// <summary>
    /// Interaction logic for readingCheckWindow.xaml
    /// </summary>
    public partial class readingCheckWindow : Window
    {
        public readingCheckWindow()
        {
            InitializeComponent();

            if (MainWindow.rightAnswersCounter == 3)
            {
                readingCheckTextBlock.Text = $"{MainWindow.rightAnswersCounter} out of 5. Nice try!";
            }
            else if (MainWindow.rightAnswersCounter == 4)
            {
                readingCheckTextBlock.Text = $"{MainWindow.rightAnswersCounter} out of 5. Good result!";
            }
            else if (MainWindow.rightAnswersCounter == 5)
            {
                readingCheckTextBlock.Text = $"{MainWindow.rightAnswersCounter} out of 5. Perfect result!";
            }
            else
            {
                readingCheckTextBlock.Text = $"{MainWindow.rightAnswersCounter} out of 5. You should try better!";
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
