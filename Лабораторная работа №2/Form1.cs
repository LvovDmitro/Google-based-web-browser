using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лабораторная_работа__2
{
    public partial class Form1 : Form
    {
        int i = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void addtabbutton_Click(object sender, EventArgs e)
        {
            WebBrowser web = new WebBrowser();
            web.Visible = true; //делаем видимым
            web.ScriptErrorsSuppressed = true; //отображает все ошибки
            web.Dock = DockStyle.Fill; // делаем на полный экран
            web.DocumentCompleted += Web_DocumentCompleted;
            maintab.TabPages.Add("New tab");
            maintab.SelectTab(i);//выделяет нужные вкладки, где i индекс вкладок
            maintab.SelectedTab.Controls.Add(web); // то, что данной вкладкой управляет
            i += 1;
        }

        private void Web_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            maintab.SelectedTab.Text = ((WebBrowser)maintab.SelectedTab.Controls[0]).DocumentTitle; // чтобы отображлось название сайта во вкладке
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            if (addresstextbox.Text != null)
            {
                ((WebBrowser)maintab.SelectedTab.Controls[0]).Navigate(addresstextbox.Text); //обращение к 0 элементу управления
            }
            else
            {

            }
        }

        private void Gobackbutton_Click(object sender, EventArgs e)
        {
            ((WebBrowser)maintab.SelectedTab.Controls[0]).GoBack();
        }

        private void gonextbutton_Click(object sender, EventArgs e)
        {
            ((WebBrowser)maintab.SelectedTab.Controls[0]).GoForward();
        }

        private void uploadbutton_Click(object sender, EventArgs e)
        {
            ((WebBrowser)maintab.SelectedTab.Controls[0]).Refresh();
        }

        private void stopbutton_Click(object sender, EventArgs e)
        {
            ((WebBrowser)maintab.SelectedTab.Controls[0]).Stop();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {

        }
    }
}
