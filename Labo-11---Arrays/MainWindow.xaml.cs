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

namespace Labo_11___Arrays
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int[] numbers = new int[6] { 100, 50, 20, 60, 90, 80 };

        public MainWindow()
        {
            InitializeComponent();
        }

        private void outputButton_Click(object sender, RoutedEventArgs e)
        {
            int[] newArray = ReturnSmallestAndBiggest(numbers);
            outputTextBox.Text = $"In totaal zijn er 6 getallen: \r\nKleinste getal = {newArray[0]}\r\nGrootste getal = {newArray[1]}";
        }

        private int[] ReturnSmallestAndBiggest(int[] numbers)
        {
            int[] output = new int[2] {int.MaxValue, int.MinValue};

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < output[0])
                {
                    output[0] = numbers[i];
                }
                if (numbers[i] > output[1])
                {
                    output[1] = numbers[i];
                }
            }

            return output;
        }
    }
}