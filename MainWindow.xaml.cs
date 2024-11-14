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

namespace IncrementDecrement
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Counter counter1 = new Counter();
            counter1.Count = 0;

        }

        private void DecBtn_Click(object sender, RoutedEventArgs e)
        {
            int textval = Convert.ToInt32(CountTextBox.Text);
            --textval;
            CountTextBox.Text = Convert.ToString(textval);
        }

        private void IncBtn_Click(object sender, RoutedEventArgs e)
        {
            int textval = Convert.ToInt32(CountTextBox.Text);
            ++textval;
            CountTextBox.Text = Convert.ToString(textval);
        }

        public class Counter
        {
            private int _counter;

            public int Count
            {
                get
                {
                    return _counter;
                }
                set
                {
                    _counter = value;
                }
            }
        }
    }
}