using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Net;
using System.Net.Sockets;
using System.Text;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace PCKontrolAndroid
{
    public partial class App : Application
    {
        static TcpClient client;
        static NetworkStream stream;

        
        public App()
        {
            InitializeComponent();
            
            MainPage = new MainPage();
           
            
        }
        public static void Bagla(String ip,int port)
        {
            client = new TcpClient(ip, port);
        }
        public static void Gonder(String mesaj)
        {
           
            stream = client.GetStream(); //Gets The Stream of The Connection
            byte[] data; // creates a new byte without mentioning the size of it cuz its a byte used for sending
            data = Encoding.Default.GetBytes(mesaj); // put the msg in the byte ( it automaticly uses the size of the msg )
            int length = data.Length; // Gets the length of the byte data
            byte[] datalength = new byte[4]; // Creates a new byte with length of 4
            datalength = BitConverter.GetBytes(length); //put the length in a byte to send it
            stream.Write(datalength, 0, 4); // sends the data's length
            stream.Write(data, 0, data.Length); //Sends the real data
            
          
        }
        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
