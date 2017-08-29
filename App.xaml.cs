using EducationalApp.SQLite;
using EducationalApp.Views;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EducationalApp
{
    public partial class App : Application
    {

        static SQLiteDataAccess dbUtils;
        static Application app;
        public static Application CurrentApp
        {
            get { return app; }
        }
        public App()
        {
            InitializeComponent();

            app = this;

            GotoLogInPage();

        }

        public static SQLiteDataAccess DAUtil
        {
            get
            {
                if (dbUtils == null)
                {
                    dbUtils = new SQLiteDataAccess();
                }
                return dbUtils;
            }
        }

        private void GotoLogInPage()
        {

            //string url = string.Format(@"https://translation.googleapis.com/language/translate/v2/?q={0}&source=en&target=nl&key={1}",
            //                            "Hello World", "AIzaSyCIzoE6ruZTVlr8JF9HZn93XdPbYIRD2PY");
            //string html = string.Empty;

            //HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            ////  request.AutomaticDecompression = DecompressionMethods.GZip;

            ////  using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())

            //request.Method = "GET";
            //request.ContentType = "application/json";
            //Task<WebResponse> task = Task.Factory.FromAsync(request.BeginGetResponse,
            //    asyncResult => request.EndGetResponse(asyncResult),
            //    (object)null);

            //var k = task.ContinueWith(t => ReadStreamFromResponse(t.Result));

            MainPage = new LogInPage();
        }

        //private static string ReadStreamFromResponse(WebResponse response)
        //{
        //    using (Stream responseStream = response.GetResponseStream())
        //    using (StreamReader sr = new StreamReader(responseStream))
        //    {
        //        //Need to return this response 
        //        string strContent = sr.ReadToEnd();
        //        return strContent;
        //    }
        //}

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
