using SyncAsyncCode.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SyncAsyncCode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGetSync_Click(object sender, EventArgs e)
        {
            var watch = Stopwatch.StartNew();

            
            RunDownloadSync();

            watch.Stop();

            txtElapsed.Text = $"Total execution time: {watch.ElapsedMilliseconds} ms";
        }

        private async void btnGetAsync_Click(object sender, EventArgs e)
        {
            var watch = Stopwatch.StartNew();

            await RunDownloadParallelASync();

            watch.Stop();

            txtElapsed.Text = $"Total execution time: {watch.ElapsedMilliseconds} ms";
        }

        public void RunDownloadSync()
        {
            List<String> WebSites = PrepData();

            foreach (String website in WebSites)
            {
                WebsiteDataModel results = DownloadWebSite(website);
                ReportWebSiteInfo(results);
            }
        }

        public async Task RunDownloadASync()
        {
            List<String> WebSites = PrepData();

            foreach (String website in WebSites)
            {
                WebsiteDataModel results = await Task.Run(() => DownloadWebSite(website));
                ReportWebSiteInfo(results);
            }
        }

        public async Task RunDownloadParallelASync()
        {
            List<String> WebSites = PrepData();
            List<Task<WebsiteDataModel>> tasks = new List<Task<WebsiteDataModel>>();

            foreach (String website in WebSites)
            {
                tasks.Add(Task.Run(() => DownloadWebSite(website)));
            }

            var results = await Task.WhenAll(tasks);

            foreach (var item in results)
            {
                ReportWebSiteInfo(item);
            }
        }

        private void ReportWebSiteInfo(WebsiteDataModel data)
        {
            txtResultBox.Text += $"{data.WebSiteName} downloaded : {data.WebSiteData.Length} characters long. {System.Environment.NewLine}";
        }

        private WebsiteDataModel DownloadWebSite(string WebSiteURL)
        {
            WebsiteDataModel output = new WebsiteDataModel();
            WebClient webClient = new WebClient();

            output.WebSiteName = WebSiteURL;
            output.WebSiteData = webClient.DownloadString(WebSiteURL);

            return output;
        }

        public List<string> PrepData()
        {
            List<String> output = new List<string>();

            txtElapsed.Text = "";
            txtResultBox.Text = "";

            output.Add("http://www.google.com");
            output.Add("http://www.stackoverflow.com");
            output.Add("http://www.youtube.com");
            output.Add("http://www.facebook.com");
            output.Add("http://www.gmail.com");
            output.Add("http://www.github.com");


            return output;
        }

        
        
    }
}
