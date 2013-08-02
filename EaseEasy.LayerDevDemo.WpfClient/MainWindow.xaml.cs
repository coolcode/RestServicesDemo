using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
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

namespace EaseEasy.LayerDevDemo.WpfClient {
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e) {
           
            var param = new FormUrlEncodedContent(new Dictionary<string, string>{
                {"Name", this.UserName.Text},
                {"Age", this.Age.Text}
            });

            var httpClient = new HttpClient();
            var post = httpClient.PostAsync("http://localhost.:3033/FooService/GetUser.rs", param);

            var response = post.Result.Content.ReadAsAsync<RestResult<User>>();

            var result = response.Result.Model;

            tbResult.Text = string.Format("Name:{0}, Age:{1}", result.Name, result.Age);

        }

            //暂不支持josn方式参数
            //var post = httpClient.PostAsJsonAsync("http://localhost.:3033/FooService/GetUser.rs", new {
            //    Name = this.UserName.Text,
            //    Age = this.Age.Text
            //});
    }

    public class RestResult<T> {
        public bool Success { get; set; }
        public T Model { get; set; }
    }

    public class User {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
