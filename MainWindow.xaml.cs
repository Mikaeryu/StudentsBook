using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace StudentsBook
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DictionaryDataGrid.ItemsSource = Dictionary.GetDictionaryList();

            EnglishTextBlockFormatting();
            RussianTextBlockFormatting();
        }

        private void TabItem_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }


        /// <summary>
        /// Добавление форматированного текста в текстовый блок с английским текстом
        /// </summary>
        public void EnglishTextBlockFormatting()
        {
            EnglishTextBlock.Text = string.Empty;
            EnglishTextBlock.Inlines.Add("        Hello! Welcome to electronical English language learning course.\n");
            EnglishTextBlock.Inlines.Add("        This learning material helps students to develop their abilities to learn English language. ");
            EnglishTextBlock.Inlines.Add("The information-driven approach in learning inspires students to think about the world around them and building their creativity, participation and performance. ");
            EnglishTextBlock.Inlines.Add("After all, it just can be fun!");
        }

        public void RussianTextBlockFormatting()
        {
            RussianTextBlock.Text = string.Empty;
            RussianTextBlock.Inlines.Add("        Привет! Добро пожаловать на электронный курс по обучению английскому языку.\n");
            RussianTextBlock.Inlines.Add("        Данный учебный материал помогает ученикам развиваться в способности к обучению английскому языку. ");
            RussianTextBlock.Inlines.Add("Информативный подход к обучению вдохновляет учеников задуматься об окружающем мире и помогает развивать креативность, заинтересованность и прилежность. ");
            RussianTextBlock.Inlines.Add("В конце концов, такой процесс обучения может просто быть весёлым!");
        }
    }
}
