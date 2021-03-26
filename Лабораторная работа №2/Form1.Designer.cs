namespace Лабораторная_работа__2
{
    partial class Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.navigationpanel = new System.Windows.Forms.ToolStrip();
            this.Gobackbutton = new System.Windows.Forms.ToolStripButton();
            this.gonextbutton = new System.Windows.Forms.ToolStripButton();
            this.uploadbutton = new System.Windows.Forms.ToolStripButton();
            this.stopbutton = new System.Windows.Forms.ToolStripButton();
            this.addresstextbox = new System.Windows.Forms.ToolStripTextBox();
            this.searchbutton = new System.Windows.Forms.ToolStripButton();
            this.addtabbutton = new System.Windows.Forms.ToolStripButton();
            this.DeletetabButton = new System.Windows.Forms.ToolStripButton();
            this.Menubutton = new System.Windows.Forms.ToolStripButton();
            this.Tabbutton = new System.Windows.Forms.ToolStripButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.savePageToDiskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maintab = new System.Windows.Forms.TabControl();
            this.Tabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.deletePageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deletePageToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.deletehistorybutton = new System.Windows.Forms.Button();
            this.historypole = new System.Windows.Forms.RichTextBox();
            this.navigationpanel.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.Tabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // navigationpanel
            // 
            this.navigationpanel.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.navigationpanel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Gobackbutton,
            this.gonextbutton,
            this.uploadbutton,
            this.stopbutton,
            this.addresstextbox,
            this.searchbutton,
            this.addtabbutton,
            this.DeletetabButton,
            this.Menubutton,
            this.Tabbutton});
            this.navigationpanel.Location = new System.Drawing.Point(0, 0);
            this.navigationpanel.Name = "navigationpanel";
            this.navigationpanel.Size = new System.Drawing.Size(1028, 33);
            this.navigationpanel.TabIndex = 0;
            // 
            // Gobackbutton
            // 
            this.Gobackbutton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Gobackbutton.Image = ((System.Drawing.Image)(resources.GetObject("Gobackbutton.Image")));
            this.Gobackbutton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Gobackbutton.Name = "Gobackbutton";
            this.Gobackbutton.Size = new System.Drawing.Size(34, 28);
            this.Gobackbutton.Text = "Go back";
            this.Gobackbutton.Click += new System.EventHandler(this.Gobackbutton_Click);
            // 
            // gonextbutton
            // 
            this.gonextbutton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.gonextbutton.Image = ((System.Drawing.Image)(resources.GetObject("gonextbutton.Image")));
            this.gonextbutton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.gonextbutton.Name = "gonextbutton";
            this.gonextbutton.Size = new System.Drawing.Size(34, 28);
            this.gonextbutton.Text = "Go next";
            this.gonextbutton.Click += new System.EventHandler(this.gonextbutton_Click);
            // 
            // uploadbutton
            // 
            this.uploadbutton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.uploadbutton.Image = ((System.Drawing.Image)(resources.GetObject("uploadbutton.Image")));
            this.uploadbutton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.uploadbutton.Name = "uploadbutton";
            this.uploadbutton.Size = new System.Drawing.Size(34, 28);
            this.uploadbutton.Text = "Upload";
            this.uploadbutton.Click += new System.EventHandler(this.uploadbutton_Click);
            // 
            // stopbutton
            // 
            this.stopbutton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stopbutton.Image = ((System.Drawing.Image)(resources.GetObject("stopbutton.Image")));
            this.stopbutton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stopbutton.Name = "stopbutton";
            this.stopbutton.Size = new System.Drawing.Size(34, 28);
            this.stopbutton.Text = "Stop";
            this.stopbutton.Click += new System.EventHandler(this.stopbutton_Click);
            // 
            // addresstextbox
            // 
            this.addresstextbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.addresstextbox.Name = "addresstextbox";
            this.addresstextbox.Size = new System.Drawing.Size(600, 33);
            this.addresstextbox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.addresstextbox_KeyUp);
            this.addresstextbox.Click += new System.EventHandler(this.addresstextbox_Click);
            // 
            // searchbutton
            // 
            this.searchbutton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.searchbutton.Image = ((System.Drawing.Image)(resources.GetObject("searchbutton.Image")));
            this.searchbutton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(34, 28);
            this.searchbutton.Text = "Поиск";
            this.searchbutton.Click += new System.EventHandler(this.searchbutton_Click);
            // 
            // addtabbutton
            // 
            this.addtabbutton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addtabbutton.Image = ((System.Drawing.Image)(resources.GetObject("addtabbutton.Image")));
            this.addtabbutton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addtabbutton.Name = "addtabbutton";
            this.addtabbutton.Size = new System.Drawing.Size(34, 28);
            this.addtabbutton.Text = "Add tab";
            this.addtabbutton.Click += new System.EventHandler(this.addtabbutton_Click);
            // 
            // DeletetabButton
            // 
            this.DeletetabButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DeletetabButton.Image = ((System.Drawing.Image)(resources.GetObject("DeletetabButton.Image")));
            this.DeletetabButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeletetabButton.Name = "DeletetabButton";
            this.DeletetabButton.Size = new System.Drawing.Size(34, 28);
            this.DeletetabButton.Text = "Delete tab";
            this.DeletetabButton.Click += new System.EventHandler(this.toolStripButton7_Click);
            // 
            // Menubutton
            // 
            this.Menubutton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Menubutton.Image = ((System.Drawing.Image)(resources.GetObject("Menubutton.Image")));
            this.Menubutton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Menubutton.Name = "Menubutton";
            this.Menubutton.Size = new System.Drawing.Size(34, 28);
            this.Menubutton.Click += new System.EventHandler(this.Menubutton_Click);
            // 
            // Tabbutton
            // 
            this.Tabbutton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Tabbutton.Image = ((System.Drawing.Image)(resources.GetObject("Tabbutton.Image")));
            this.Tabbutton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tabbutton.Name = "Tabbutton";
            this.Tabbutton.Size = new System.Drawing.Size(34, 28);
            this.Tabbutton.Text = "Addtobookmarks";
            this.Tabbutton.Click += new System.EventHandler(this.Tabbutton_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.savePageToDiskToolStripMenuItem,
            this.deletePageToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(226, 68);
            this.contextMenuStrip1.Text = "Save page to disk";
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // savePageToDiskToolStripMenuItem
            // 
            this.savePageToDiskToolStripMenuItem.Name = "savePageToDiskToolStripMenuItem";
            this.savePageToDiskToolStripMenuItem.Size = new System.Drawing.Size(225, 32);
            this.savePageToDiskToolStripMenuItem.Text = "Save page to disk";
            this.savePageToDiskToolStripMenuItem.Click += new System.EventHandler(this.savePageToDiskToolStripMenuItem_Click);
            // 
            // maintab
            // 
            this.maintab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maintab.Location = new System.Drawing.Point(0, 33);
            this.maintab.Name = "maintab";
            this.maintab.SelectedIndex = 0;
            this.maintab.Size = new System.Drawing.Size(1028, 516);
            this.maintab.TabIndex = 5;
            // 
            // Tabs
            // 
            this.Tabs.Controls.Add(this.tabPage1);
            this.Tabs.Controls.Add(this.tabPage2);
            this.Tabs.Controls.Add(this.tabPage3);
            this.Tabs.Dock = System.Windows.Forms.DockStyle.Right;
            this.Tabs.Location = new System.Drawing.Point(828, 33);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(200, 516);
            this.Tabs.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(192, 483);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tabs";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(3, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(186, 477);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 483);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Saves";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listBox2
            // 
            this.listBox2.ContextMenuStrip = this.contextMenuStrip2;
            this.listBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(3, 3);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(186, 477);
            this.listBox2.TabIndex = 0;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // deletePageToolStripMenuItem
            // 
            this.deletePageToolStripMenuItem.Name = "deletePageToolStripMenuItem";
            this.deletePageToolStripMenuItem.Size = new System.Drawing.Size(225, 32);
            this.deletePageToolStripMenuItem.Text = "Delete page";
            this.deletePageToolStripMenuItem.Click += new System.EventHandler(this.deletePageToolStripMenuItem_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deletePageToolStripMenuItem1});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(180, 36);
            // 
            // deletePageToolStripMenuItem1
            // 
            this.deletePageToolStripMenuItem1.Name = "deletePageToolStripMenuItem1";
            this.deletePageToolStripMenuItem1.Size = new System.Drawing.Size(179, 32);
            this.deletePageToolStripMenuItem1.Text = "Delete page";
            this.deletePageToolStripMenuItem1.Click += new System.EventHandler(this.deletePageToolStripMenuItem1_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.historypole);
            this.tabPage3.Controls.Add(this.deletehistorybutton);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(192, 483);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "History";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // deletehistorybutton
            // 
            this.deletehistorybutton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.deletehistorybutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletehistorybutton.Location = new System.Drawing.Point(0, 448);
            this.deletehistorybutton.Name = "deletehistorybutton";
            this.deletehistorybutton.Size = new System.Drawing.Size(192, 35);
            this.deletehistorybutton.TabIndex = 0;
            this.deletehistorybutton.Text = "Delete history";
            this.deletehistorybutton.UseVisualStyleBackColor = true;
            this.deletehistorybutton.Click += new System.EventHandler(this.deletehistorybutton_Click);
            // 
            // historypole
            // 
            this.historypole.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.historypole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.historypole.Location = new System.Drawing.Point(0, 0);
            this.historypole.Name = "historypole";
            this.historypole.ReadOnly = true;
            this.historypole.Size = new System.Drawing.Size(192, 448);
            this.historypole.TabIndex = 1;
            this.historypole.Text = "";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1028, 549);
            this.Controls.Add(this.Tabs);
            this.Controls.Add(this.maintab);
            this.Controls.Add(this.navigationpanel);
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Browser";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.navigationpanel.ResumeLayout(false);
            this.navigationpanel.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.Tabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip navigationpanel;
        private System.Windows.Forms.ToolStripButton Gobackbutton;
        private System.Windows.Forms.ToolStripButton gonextbutton;
        private System.Windows.Forms.ToolStripButton uploadbutton;
        private System.Windows.Forms.ToolStripButton stopbutton;
        private System.Windows.Forms.ToolStripTextBox addresstextbox;
        private System.Windows.Forms.ToolStripButton searchbutton;
        private System.Windows.Forms.ToolStripButton addtabbutton;
        private System.Windows.Forms.ToolStripButton DeletetabButton;
        private System.Windows.Forms.ToolStripButton Menubutton;
        private System.Windows.Forms.ToolStripButton Tabbutton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem savePageToDiskToolStripMenuItem;
        private System.Windows.Forms.TabControl maintab;
        private System.Windows.Forms.TabControl Tabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ToolStripMenuItem deletePageToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem deletePageToolStripMenuItem1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RichTextBox historypole;
        private System.Windows.Forms.Button deletehistorybutton;
    }
}

