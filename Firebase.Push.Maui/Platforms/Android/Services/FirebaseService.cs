using Android.App;
using Firebase.Messaging;

namespace Firebase.Push.Maui.Platforms.Android.Services
{
    [Service(Exported = true)]
    [IntentFilter(new[] {"com.google.firebase.MESSAGING_EVENT"})]
    internal class FirebaseService : FirebaseMessagingService
    {
        public FirebaseService() { }

        public override void OnNewToken(string token)
        {
            System.Diagnostics.Debug.WriteLine("FCM token: " + token);
            base.OnNewToken(token);
        }

        public override void OnMessageReceived(RemoteMessage message)
        {
            base.OnMessageReceived(message);
        }

    }
}
