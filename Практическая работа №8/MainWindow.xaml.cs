using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static Практическая_работа__8.MainWindow;
using Практическая_работа__8;

namespace Практическая_работа__8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Модуль для закрытия программы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Модуль для вывода сообщения с информацией о разработчике программы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InfoSozdButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Студент группы ИСП-31\nЖаров Артём Андреевич", "О создателе:", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        /// <summary>
        /// Модуль для вывода сообщения с заданием для разработки программы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InfoProgaButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Создать интерфейсы - работник и отец-семейства.\nСоздать класс работника-отца семейства. Класс " +
                "\nдолжен включать конструктор, функцию для фор-\nмирования строки информации о работнике. " +
                "\nСравнение производить по фамилии.", "О программе:", MessageBoxButton.OK);
        }

        Father father;
        Worker worker;

        /// <summary>
        /// Модуль для создания объекта "отец" и добавления объекта на форму для визуализации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateFatherButton_Click(object sender, RoutedEventArgs e)
        {
            string lastName = LastNameTextBox.Text.Trim();
            string firstName = FirstNameTextBox.Text.Trim();

            if (lastName != "" && firstName != "")
            {
                if (father == null)
                {
                    father = new Father(lastName, firstName);
                    OutListBox.Items.Add(father.GetInfo() + " - " + father.Role());
                }
                else MessageBox.Show("Отец семейства уже создан", "Ошибка: ", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else MessageBox.Show("Заполните все необходимые поля", "Ошибка: ", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        /// <summary>
        /// Модуль для создания объекта "работник" и добавления объекта на форму для визуализации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateWorkerButton_Click(object sender, RoutedEventArgs e)
        {
            string lastName = LastNameTextBox.Text.Trim();
            string firstName = FirstNameTextBox.Text.Trim();
            string position = PositionTextBox.Text.Trim();

            if (lastName != "" && firstName != "" && position != "")
            {
                if (worker == null)
                {
                    worker = new Worker(lastName, firstName, position);
                    OutListBox.Items.Add(worker.GetInfo() + " - " + worker.Role());
                }
                else MessageBox.Show("Работник уже создан", "Ошибка: ", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else MessageBox.Show("Заполните все необходимые поля", "Ошибка: ", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        /// <summary>
        /// Модуль для сравнения двух объектов и вывод сообщения с результатом
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SravnButton_Click(object sender, RoutedEventArgs e)
        {
            if (father != null && worker != null)
            {
                if (worker.CompareTo(father) == 0)
                {
                    MessageBox.Show("Фамилии одинаковые", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else MessageBox.Show("Фамилии разные", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        /// <summary>
        /// Модуль очищает все поля ввода и список результатов, а так же сбрасывает ссылки на объекты
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            father = null;
            worker = null;
            LastNameTextBox.Clear();
            FirstNameTextBox.Clear();
            PositionTextBox.Clear();
            OutListBox.Items.Clear();
        }
    }
}