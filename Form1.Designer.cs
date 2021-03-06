
namespace FunctionPoint1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFile = new System.Windows.Forms.ToolStripMenuItem();
            this.openFile = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.exitFile = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languagePreference = new System.Windows.Forms.ToolStripMenuItem();
            this.metricToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.functionpointMetric = new System.Windows.Forms.ToolStripMenuItem();
            this.enterFPDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FPTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.menuStrip1.SuspendLayout();
            this.FPTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.preferencesToolStripMenuItem,
            this.metricToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(905, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFile,
            this.openFile,
            this.saveFile,
            this.exitFile});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newFile
            // 
            this.newFile.Name = "newFile";
            this.newFile.Size = new System.Drawing.Size(180, 22);
            this.newFile.Text = "New";
            this.newFile.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openFile
            // 
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(180, 22);
            this.openFile.Text = "Open";
            this.openFile.Click += new System.EventHandler(this.openFile_Click);
            // 
            // saveFile
            // 
            this.saveFile.Name = "saveFile";
            this.saveFile.Size = new System.Drawing.Size(180, 22);
            this.saveFile.Text = "Save";
            this.saveFile.Click += new System.EventHandler(this.saveFile_Click);
            // 
            // exitFile
            // 
            this.exitFile.Name = "exitFile";
            this.exitFile.Size = new System.Drawing.Size(180, 22);
            this.exitFile.Text = "Exit";
            this.exitFile.Click += new System.EventHandler(this.exitFile_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.languagePreference});
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            // 
            // languagePreference
            // 
            this.languagePreference.Name = "languagePreference";
            this.languagePreference.Size = new System.Drawing.Size(126, 22);
            this.languagePreference.Text = "Language";
            this.languagePreference.Click += new System.EventHandler(this.languagePreference_Click);
            // 
            // metricToolStripMenuItem
            // 
            this.metricToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.functionpointMetric});
            this.metricToolStripMenuItem.Name = "metricToolStripMenuItem";
            this.metricToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.metricToolStripMenuItem.Text = "Metrics";
            // 
            // functionpointMetric
            // 
            this.functionpointMetric.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enterFPDataToolStripMenuItem});
            this.functionpointMetric.Name = "functionpointMetric";
            this.functionpointMetric.Size = new System.Drawing.Size(152, 22);
            this.functionpointMetric.Text = "Function Point";
            this.functionpointMetric.Click += new System.EventHandler(this.functionpointMetric_Click);
            // 
            // enterFPDataToolStripMenuItem
            // 
            this.enterFPDataToolStripMenuItem.Name = "enterFPDataToolStripMenuItem";
            this.enterFPDataToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.enterFPDataToolStripMenuItem.Text = "Enter FP Data";
            this.enterFPDataToolStripMenuItem.Click += new System.EventHandler(this.enterFPDataToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // FPTab
            // 
            this.FPTab.Controls.Add(this.tabPage1);
            this.FPTab.Location = new System.Drawing.Point(0, 27);
            this.FPTab.Name = "FPTab";
            this.FPTab.SelectedIndex = 0;
            this.FPTab.Size = new System.Drawing.Size(905, 697);
            this.FPTab.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(897, 671);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Welcome";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 723);
            this.Controls.Add(this.FPTab);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "CECS 543 Metrics Suite ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.FPTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newFile;
        private System.Windows.Forms.ToolStripMenuItem openFile;
        private System.Windows.Forms.ToolStripMenuItem saveFile;
        private System.Windows.Forms.ToolStripMenuItem exitFile;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languagePreference;
        private System.Windows.Forms.ToolStripMenuItem metricToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem functionpointMetric;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enterFPDataToolStripMenuItem;
        private System.Windows.Forms.TabControl FPTab;
        private System.Windows.Forms.TabPage tabPage1;
    }
}

