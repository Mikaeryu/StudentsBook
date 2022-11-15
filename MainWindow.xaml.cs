using System;
using System.Collections.Generic;
using System.Data;
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
        public static int rightAnswersCounter = 0; //поле с счётчиком ответов

        public MainWindow()
        {
            InitializeComponent();

            //привязка словарного списка к DataGrid
            DictionaryDataGrid.ItemsSource = RusEngDictionary.GetDictionaryList();

            //добавление форматированного текста в текстовые блоки главной страницы
            TextFormatting.EnglishTextFormatting(EnglishTextBlock);
            TextFormatting.RussianTextFormatting(RussianTextBlock);
        }

        private void TabItem_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            rightAnswersCounter = 0; //обнуление счётчика правильных ответов

            // Словарь, в котором содержатся ответы на вопросы по чтению 
            Dictionary<ComboBox, string> readingKeys = new Dictionary<ComboBox, string>()
            {
                  {keyComboBox1, "d) general information"}
                , {keyComboBox2, "e) the first school"}
                , {keyComboBox3, "b) free-time activities"}
                , {keyComboBox4, "c) houses"}
                , {keyComboBox5, "a) fees"}
            };

            foreach (ComboBox comboBox in readingKeys.Keys)
            {
                if(comboBox.Text == readingKeys[comboBox]) 
                {
                    rightAnswersCounter++;
                }
            }

            new readingCheckWindow().ShowDialog();
        }

        private void TestingStartButton_Click(object sender, RoutedEventArgs e)
        {
            SetTestingTabControls(false);

        }

        private void SetTestingTabControls(bool value)
        {
            HomePageTab.IsEnabled = value;
            ReadingTab.IsEnabled = value;
            DictionaryTab.IsEnabled = value;
            TestingStartButton.IsEnabled = value;
            TetingInfoLabel.IsEnabled = value;
        }
    }
}
