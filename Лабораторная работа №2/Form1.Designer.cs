namespace Лабораторная_работа__2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.navigationpanel = new System.Windows.Forms.ToolStrip();
            this.Gobackbutton = new System.Windows.Forms.ToolStripButton();
            this.gonextbutton = new System.Windows.Forms.ToolStripButton();
            this.uploadbutton = new System.Windows.Forms.ToolStripButton();
            this.stopbutton = new System.Windows.Forms.ToolStripButton();
            this.addresstextbox = new System.Windows.Forms.ToolStripTextBox();
            this.searchbutton = new System.Windows.Forms.ToolStripButton();
            this.addtabbutton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.maintab = new System.Windows.Forms.TabControl();
            this.navigationpanel.SuspendLayout();
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
            this.toolStripButton7});
            this.navigationpanel.Location = new System.Drawing.Point(0, 0);
            this.navigationpanel.Name = "navigationpanel";
            this.navigationpanel.Size = new System.Drawing.Size(1039, 38);
            this.navigationpanel.TabIndex = 0;
            // 
            // Gobackbutton
            // 
            this.Gobackbutton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Gobackbutton.Image = ((System.Drawing.Image)(resources.GetObject("Gobackbutton.Image")));
            this.Gobackbutton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Gobackbutton.Name = "Gobackbutton";
            this.Gobackbutton.Size = new System.Drawing.Size(34, 33);
            this.Gobackbutton.Text = "Go back";
            // 
            // gonextbutton
            // 
            this.gonextbutton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.gonextbutton.Image = ((System.Drawing.Image)(resources.GetObject("gonextbutton.Image")));
            this.gonextbutton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.gonextbutton.Name = "gonextbutton";
            this.gonextbutton.Size = new System.Drawing.Size(34, 33);
            this.gonextbutton.Text = "Go next";
            // 
            // uploadbutton
            // 
            this.uploadbutton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.uploadbutton.Image = ((System.Drawing.Image)(resources.GetObject("uploadbutton.Image")));
            this.uploadbutton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.uploadbutton.Name = "uploadbutton";
            this.uploadbutton.Size = new System.Drawing.Size(34, 33);
            this.uploadbutton.Text = "Upload";
            // 
            // stopbutton
            // 
            this.stopbutton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stopbutton.Image = ((System.Drawing.Image)(resources.GetObject("stopbutton.Image")));
            this.stopbutton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stopbutton.Name = "stopbutton";
            this.stopbutton.Size = new System.Drawing.Size(34, 33);
            this.stopbutton.Text = "Stop";
            // 
            // addresstextbox
            // 
            this.addresstextbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.addresstextbox.Name = "addresstextbox";
            this.addresstextbox.Size = new System.Drawing.Size(600, 38);
            // 
            // searchbutton
            // 
            this.searchbutton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.searchbutton.Image = ((System.Drawing.Image)(resources.GetObject("searchbutton.Image")));
            this.searchbutton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(34, 33);
            this.searchbutton.Text = "Поиск";
            this.searchbutton.Click += new System.EventHandler(this.searchbutton_Click);
            // 
            // addtabbutton
            // 
            this.addtabbutton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addtabbutton.Image = ((System.Drawing.Image)(resources.GetObject("addtabbutton.Image")));
            this.addtabbutton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addtabbutton.Name = "addtabbutton";
            this.addtabbutton.Size = new System.Drawing.Size(34, 33);
            this.addtabbutton.Text = "Add tab";
            this.addtabbutton.Click += new System.EventHandler(this.addtabbutton_Click);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(34, 33);
            this.toolStripButton7.Text = "Delete tab";
            // 
            // maintab
            // 
            this.maintab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maintab.Location = new System.Drawing.Point(0, 38);
            this.maintab.Name = "maintab";
            this.maintab.SelectedIndex = 0;
            this.maintab.Size = new System.Drawing.Size(1039, 534);
            this.maintab.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 572);
            this.Controls.Add(this.maintab);
            this.Controls.Add(this.navigationpanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.navigationpanel.ResumeLayout(false);
            this.navigationpanel.PerformLayout();
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
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.TabControl maintab;
    }
}

