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
            SetTestingTabControlsActive(false);

            Dictionary<ComboBox, string> testingKeys = new Dictionary<ComboBox, string>()
            {
                  {testComboBox1, "a) laboratory"}
                , {testComboBox1, "c) courts"} //CONTINUE
                , {testComboBox3, "b) pitch"}
                , {testComboBox4, "d) library"}
                , {testComboBox5, "b) up"}
                , {testComboBox6, "c) care of"}
                , {testComboBox7, "b) up"}
                , {testComboBox8, "c) care of"}
                , {testComboBox9, "a) part in"}
                , {testComboBox10, "d) place"}
                , {testComboBox11, "b) like"}
                , {testComboBox12, "a) go"}
                , {testComboBox13, "a) rather"}
                , {testComboBox14, "b) going"}
                , {testComboBox15, "b) watching"}
                , {testComboBox16, "b) dancing"}
                , {testComboBox17, "a) don't stand"}
                , {testComboBox18, "b) being"}
                , {testComboBox19, "a) don't"}
                , {testComboBox20, "b) going"}
            };
        }

        private void SetTestingTabControlsActive(bool value)
        {
            HomePageTab.IsEnabled = value;
            ReadingTab.IsEnabled = value;
            DictionaryTab.IsEnabled = value;
            TestingStartButton.IsEnabled = value;
            TestingInfoLabel.IsEnabled = value;

            if (value == false) 
            {
                TestingInfoLabel.Visibility = Visibility.Collapsed;
                TestingStartButton.Visibility = Visibility.Collapsed;
            }
            else
            {
                TestingInfoLabel.Visibility = Visibility.Visible;
                TestingStartButton.Visibility = Visibility.Visible;
            }
        }
    }
}
