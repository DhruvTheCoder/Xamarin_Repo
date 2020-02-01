using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace InsertDataUsingApi
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void InsertStudent_Clicked(object sender, EventArgs e)
        {
            Products student = new Products
            {

                name = name.Text,
                price = price.Text,
                description = description.Text
             
            };
            var httpClient = new HttpClient();
            var json = JsonConvert.SerializeObject(student);
            HttpContent httpContent = new StringContent(json);
            httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
          await  httpClient.PostAsync(String.Format("http://YourAPIkey:PortWhereServerIsRunning/API/InsertAPI/Insert2.php"), httpContent);
          await  DisplayAlert("Added", "Your data has been Updated", "ok");
        }
    }
}

