using Microsoft.Toolkit.Uwp.Notifications;
using System;
using System.Windows;
using Windows.UI.Notifications;

namespace windows_notifications_toast
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ToastContent toastContent = new ToastContentBuilder()
                .AddToastActivationInfo("action=viewConversation&conversationId=5", ToastActivationType.Foreground)
                .AddText("Hello world!")
                .GetToastContent();

            // And create the toast notification
            var toast = new ToastNotification(toastContent.GetXml());

            // And then show it
            DesktopNotificationManagerCompat.CreateToastNotifier().Show(toast);
        }
    }
}
