using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using Newtonsoft.Json;
using PddOpenSdk.Services;

namespace PddSignTool
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BTSign_Click(object sender, RoutedEventArgs e)
        {
            var dic = JsonConvert.DeserializeObject<Dictionary<string, object>>(TBParams.Text);
            // 添加公共参数
            dic.Add("access_token", TBAccessToken.Text);
            dic.Add("client_id", TBClientId.Text);
            dic.Add("data_type", "JSON");
            dic.Add("versioin", "V1");

            if (dic.Keys.Any(k => k == "type"))
            {
                dic.Remove("type");
                dic.Add("type", TBType.Text);
            }
            if (dic.Keys.Any(k => k == "timestamp"))
            {
                dic.Remove("timestamp");
                dic.Add("timestamp", DateTimeOffset.Now.ToUnixTimeSeconds().ToString());
            }
            // 添加签名

            var api = new PddCommonApi();
            string sign = api.BuildSign(dic);

            TBSign.Text = sign;
        }
    }
}
