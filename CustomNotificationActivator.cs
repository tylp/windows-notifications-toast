using Microsoft.Toolkit.Uwp.Notifications;
using System;
using System.Runtime.InteropServices;
namespace windows_notifications_toast
{
    [ClassInterface(ClassInterfaceType.None)]
    [ComSourceInterfaces(typeof(INotificationActivationCallback))]
    [Guid("85FE8C51-9C15-4B67-8BC3-1F692F69CC90"), ComVisible(true)]
    class CustomNotificationActivator : NotificationActivator
    {
        public override void OnActivated(string arguments, NotificationUserInput userInput, string appUserModelId)
        {
            // Register COM server and activator type
            DesktopNotificationManagerCompat.RegisterActivator<CustomNotificationActivator>();
        }
    }
}
