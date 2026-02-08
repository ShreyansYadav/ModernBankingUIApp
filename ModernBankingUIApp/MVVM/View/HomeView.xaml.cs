using System;
using System.Collections.Generic;
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

namespace ModernBankingUIApp.MVVM.View
{
    /// <summary>
    /// Interaction logic for HomeView.xaml
    /// </summary>
    public partial class HomeView : UserControl
    {
        public HomeView()
        {
            InitializeComponent();
        }

        private void ChatButton_Click(object sender, RoutedEventArgs e)
        {
            if (ChatBox.Visibility == Visibility.Collapsed)
            {
                ChatBox.Visibility = Visibility.Visible;
            }
            else
            {
                ChatBox.Visibility = Visibility.Collapsed;
            }
        }

        // Close the chatbox when the X button is clicked
        private void CloseChatButton_Click(object sender, RoutedEventArgs e)
        {
            ChatBox.Visibility = Visibility.Collapsed;
        }

        // Send a message when the Send button is clicked
        private void SendMessageButton_Click(object sender, RoutedEventArgs e)
        {
            string message = ChatInputTextBox.Text;

            // Check if the message is not empty
            if (!string.IsNullOrWhiteSpace(message) && message != "Type a message...")
            {
                // Create a new TextBlock for the user's message
                TextBlock userMessage = new TextBlock
                {
                    Text = "You: " + message,
                    Foreground = System.Windows.Media.Brushes.LightBlue,
                    FontSize = 14,
                    FontFamily = new System.Windows.Media.FontFamily("/Fonts/#Poppins-Regular"),
                    TextWrapping = TextWrapping.Wrap,
                    Margin = new Thickness(0, 10, 0, 0)
                };

                // Add the message to the chat panel
                ChatMessagesPanel.Children.Add(userMessage);

                // Clear the input box
                ChatInputTextBox.Text = "Type a message...";

                // Optional: Simulate a bot response after a short delay
                SimulateBotResponse();
            }
        }

        // Optional: Simulate a simple bot response
        private async void SimulateBotResponse()
        {
            // Wait for 1 second before responding
            await System.Threading.Tasks.Task.Delay(1000);

            TextBlock botMessage = new TextBlock
            {
                Text = "Support: Thank you for your message. An agent will be with you shortly.",
                Foreground = System.Windows.Media.Brushes.White,
                FontSize = 14,
                FontFamily = new System.Windows.Media.FontFamily("/Fonts/#Poppins-Regular"),
                TextWrapping = TextWrapping.Wrap,
                Margin = new Thickness(0, 10, 0, 0)
            };

            ChatMessagesPanel.Children.Add(botMessage);
        }
    }
}
    

