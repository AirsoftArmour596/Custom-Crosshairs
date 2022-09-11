using System;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;

namespace Custom_Crosshairs
{
    partial class MenuWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuWindow));
            this.Start = new System.Windows.Forms.Button();
            this.Settings = new System.Windows.Forms.Button();
            this.Quit = new System.Windows.Forms.Button();
            this.CrossairPreview = new System.Windows.Forms.PictureBox();
            this.titleBox = new System.Windows.Forms.PictureBox();
            this.Stop = new System.Windows.Forms.Button();
            this.HideMenu = new System.Windows.Forms.Button();
            this.menuNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.CrossairPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titleBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.SystemColors.Control;
            this.Start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Start.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Start.Location = new System.Drawing.Point(12, 226);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(195, 64);
            this.Start.TabIndex = 0;
            this.Start.Text = "Activate Crosshair";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ActivateCrosshair);
            // 
            // Settings
            // 
            this.Settings.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Settings.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Settings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Settings.Location = new System.Drawing.Point(12, 296);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(195, 64);
            this.Settings.TabIndex = 1;
            this.Settings.Text = "Enter Settings";
            this.Settings.UseVisualStyleBackColor = false;
            this.Settings.MouseClick += new System.Windows.Forms.MouseEventHandler(this.EnterSettings);
            // 
            // Quit
            // 
            this.Quit.BackColor = System.Drawing.Color.Maroon;
            this.Quit.Cursor = System.Windows.Forms.Cursors.Help;
            this.Quit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Quit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Quit.Location = new System.Drawing.Point(12, 436);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(195, 64);
            this.Quit.TabIndex = 2;
            this.Quit.Text = "Quit to Desktop";
            this.Quit.UseVisualStyleBackColor = false;
            this.Quit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.QuitProgram);
            // 
            // CrossairPreview
            // 
            this.CrossairPreview.BackColor = System.Drawing.SystemColors.ControlDark;
            this.CrossairPreview.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\data\\crosshairs\\" + UserPreferances.Default.preferedCrosshair);
            this.CrossairPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CrossairPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CrossairPreview.Location = new System.Drawing.Point(244, 244);
            this.CrossairPreview.Name = "CrossairPreview";
            this.CrossairPreview.Size = new System.Drawing.Size(256, 256);
            this.CrossairPreview.TabIndex = 3;
            this.CrossairPreview.TabStop = false;
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(12, 12);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(488, 100);
            this.titleBox.TabIndex = 4;
            this.titleBox.TabStop = false;
            // 
            // Stop
            // 
            this.Stop.BackColor = System.Drawing.Color.Maroon;
            this.Stop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Stop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Stop.ForeColor = System.Drawing.SystemColors.Control;
            this.Stop.Location = new System.Drawing.Point(12, 366);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(195, 64);
            this.Stop.TabIndex = 5;
            this.Stop.Text = "Deactivate Crosshair";
            this.Stop.UseVisualStyleBackColor = false;
            this.Stop.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DeactivateCrosshair);
            // 
            // HideMenu
            // 
            this.HideMenu.BackColor = System.Drawing.SystemColors.Control;
            this.HideMenu.Cursor = System.Windows.Forms.Cursors.Help;
            this.HideMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.HideMenu.Location = new System.Drawing.Point(12, 194);
            this.HideMenu.Name = "HideMenu";
            this.HideMenu.Size = new System.Drawing.Size(195, 26);
            this.HideMenu.TabIndex = 6;
            this.HideMenu.Text = "Hide Menu";
            this.HideMenu.UseVisualStyleBackColor = false;
            this.HideMenu.Click += new System.EventHandler(this.HideWindow);
            // 
            // menuNotifyIcon
            // 
            this.menuNotifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.menuNotifyIcon.BalloonTipText = "Text";
            this.menuNotifyIcon.BalloonTipTitle = "Title";
            this.menuNotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("menuNotifyIcon.Icon")));
            this.menuNotifyIcon.Text = "Custom Crosshair";
            this.menuNotifyIcon.Visible = true;
            this.menuNotifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.UnhideWindow);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.progressBar1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.progressBar1.Location = new System.Drawing.Point(244, 228);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(256, 10);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 7;
            // 
            // MenuWindow
            // 
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(512, 512);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.HideMenu);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.CrossairPreview);
            this.Controls.Add(this.Quit);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.Start);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.TransparencyKey = System.Drawing.Color.Magenta;
            ((System.ComponentModel.ISupportInitialize)(this.CrossairPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titleBox)).EndInit();
            this.ResumeLayout(false);

        }

        public void RefreshWindow()
        {
            this.CrossairPreview.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\data\\crosshairs\\" + UserPreferances.Default.preferedCrosshair);
        }

        #endregion

        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Settings;
        private System.Windows.Forms.Button Quit;
        private System.Windows.Forms.PictureBox CrossairPreview;
        private System.Windows.Forms.PictureBox titleBox;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Button HideMenu;
        private System.Windows.Forms.NotifyIcon menuNotifyIcon;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}