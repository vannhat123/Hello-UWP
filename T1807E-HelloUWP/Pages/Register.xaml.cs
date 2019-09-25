using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using T1807E_HelloUWP.Empty;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace T1807E_HelloUWP.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Register : Page
    {

        private const string ApiUrl = "https://2-dot-backup-server-003.appspot.com/_api/v2/members";
        public Register()
        {
            this.InitializeComponent();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            /* var member = new Member
             {
                 Username = this.Username.Text,
                 Password = this.Password.Password
             };*/

            //var register1 = new Register1
            //{
            //    firstName = this.FirstName.Text,
            //    lastName = this.LastName.Text,
            //    avatar = this.Avatar.Text,
            //    phone = this.Phone.Text,
            //    address = this.Address.Text,
            //    introduction = this.Introduction.Text,
            //    gender = Int32.Parse(this.Gender.Text),
            //    birhtday = this.Birthday.Text,
            //    password = this.Password.Password

            //};

            var member = new Register1
            {
                firstName = "Nhat",
                password = "123456",
                lastName = "Nguyen",
                address = "Cau Dien",
                avatar = "https://i.ytimg.com/vi/Za0iUFKxzBc/maxresdefault.jpg",
                birhtday = "2018-12-30",
                email = "nhatnvd00481@gmail.com",
                gender = 1,
                introduction = "Hllo T1807E",
                phone = "01234567",
            };
            // validate phía client.
            Debug.WriteLine(JsonConvert.SerializeObject(member));
            var httpClient = new HttpClient();
            //httpClient.DefaultRequestHeaders.Add("Authorization", "Basic " + token);
            HttpContent content = new StringContent(JsonConvert.SerializeObject(member), Encoding.UTF8,
                "application/json");
            Task<HttpResponseMessage> httpRequestMessage = httpClient.PostAsync(ApiUrl, content);
            String responseContent = httpClient.PostAsync(ApiUrl, content).Result.Content.ReadAsStringAsync().Result;
            Debug.WriteLine("Response: " + responseContent);

            Member resMember = JsonConvert.DeserializeObject<Member>(responseContent);
           // Debug.WriteLine(resMember.email);
        }
    }
}
