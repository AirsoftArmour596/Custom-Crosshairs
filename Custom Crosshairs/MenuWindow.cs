using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Custom_Crosshairs
{
    public partial class MenuWindow : Form
    {
        public Image crosshairImage;
        CrosshairWindow crosshairWindow = new CrosshairWindow();
        SettingsWindow settingsWindow = new SettingsWindow();

        public MenuWindow()
        {
            InitializeComponent();
            menuNotifyIcon.Visible = false;
        }

        private void ActivateCrosshair(object sender, MouseEventArgs e)
        {
            crosshairWindow.crosshairImage = this.crosshairImage;
            crosshairWindow.IdentifyCaller(this);
            crosshairWindow.Show();
        }

        private void EnterSettings(object sender, MouseEventArgs e)
        {
            settingsWindow.Show();
            settingsWindow.IdentifyCaller(this);
            crosshairWindow.Hide();
            this.Hide();
            menuNotifyIcon.Visible = false;
        }

        private void DeactivateCrosshair(object sender, MouseEventArgs e)
        {
            crosshairWindow.Hide();
        }

        private void QuitProgram(object sender, MouseEventArgs e)
        {
            crosshairWindow.Close();
            settingsWindow.Close();
            this.Close();
            Application.Exit();
        }

        private void HideWindow(object sender, EventArgs e)
        {
            this.Hide();
            menuNotifyIcon.Visible = true;
        }

        private void UnhideWindow(object sender, MouseEventArgs e)
        {
            this.Show();
            menuNotifyIcon.Visible = false;
        }
    }
}
