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

namespace HostSelfDefining
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Person> People { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            People = new List<Person>();

            People.Add(new Person() { FirstName = "Mike", LastName = "Adams" });
            People.Add(new Person() { FirstName = "Leslie", LastName = "Adams" });
            People.Add(new Person() { FirstName = "Bubba", LastName = "Smith" });

            myCombo.ItemsSource = People;
        }

        private void submitButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Hello {FirstNameText.Text}!");
        }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
    }
}
