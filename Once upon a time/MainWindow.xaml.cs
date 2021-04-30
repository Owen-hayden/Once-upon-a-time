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

namespace Once_upon_a_time
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

        private void button_makeStory_Click(object sender, RoutedEventArgs e)
        {
            //Enter button code here!!

            String character = textBox_inputCharacters.Text;
            String mood = textBox_inputMood.Text;

            textBlockstoryOutput.Text = string.Format("Once upon a time there was a {0}, who was in a {1} mood.", character, mood);
        }
    }
}
