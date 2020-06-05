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

namespace WPFDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<string> messageHistory = new List<string>();

        public MainWindow()
        {
            InitializeComponent();
            messageHistoryBox.ItemsSource = messageHistory;
        }

        private void sendButton_Click(object sender, RoutedEventArgs e)
        {
            messageHistory.Add("You: " + messageBox.Text);
            messageHistoryBox.Items.Refresh();
            string response = determineResponse(messageBox.Text);
            messageBox.Text = "";
            messageHistory.Add("Bot: " + response);
            messageHistoryBox.Items.Refresh();
        }

        private string determineResponse(string sentMessage)
        {
            switch (sentMessage.ToLower())
            {
                case "hello":
                    return "Hello there! How are you?";
                case "good thanks":
                    return "That's brilliant!";
            }

            return "";
        }
    }
}
