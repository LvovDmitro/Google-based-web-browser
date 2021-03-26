using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Лабораторная_работа__2
{
    public partial class Form : System.Windows.Forms.Form
    {
        int i = 0;
        public Form()
        {
            
            InitializeComponent();
            historypole.Text = File.ReadAllText("history.txt");
            listBox2.Items.AddRange(File.ReadAllLines("savepages.txt"));
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
                File.AppendAllText("history.txt", addresstextbox.Text + "\n");
                 historypole.Text = File.ReadAllText("history.txt");
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
            if (maintab.TabPages.Count > 1)
            {
                maintab.TabPages.RemoveAt(maintab.SelectedIndex);
                maintab.SelectTab(maintab.TabPages.Count - 1);
                i -= 1;
            }
            else
            {
                Application.Exit();
            }
        }

        private void addresstextbox_Click(object sender, EventArgs e)
        {
            
        }

        private void Menubutton_Click(object sender, EventArgs e)
        {
          
        }


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Tabbutton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(addresstextbox.Text))
            {
                WebBrowser web = new WebBrowser();
                web.Navigate(addresstextbox.Text);
                listBox1.Items.Add(addresstextbox.Text);
                i++;

            }
        }

        private void addresstextbox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ((WebBrowser)maintab.SelectedTab.Controls[0]).Navigate(addresstextbox.Text);
            }
        }

        private void Tabs_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Tabs_Paint_1(object sender, PaintEventArgs e)
        {
            
            
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void savePageToDiskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            File.AppendAllText("savepages.txt", Convert.ToString(maintab.SelectedTab));
            listBox2.Items.Add(Convert.ToString(maintab.SelectedTab.Text));
            i += 1;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void deletePageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void deletePageToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            listBox2.Items.RemoveAt(listBox2.SelectedIndex);
            i += 1;
        }

        private void deletehistorybutton_Click(object sender, EventArgs e)
        {
            File.WriteAllText("history.txt", "");
            historypole.Text = File.ReadAllText("history.txt");
        }
    }
}
