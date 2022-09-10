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
        public MenuWindow()
        {
            InitializeComponent();
            menuNotifyIcon.Visible = false;
        }

        CrosshairWindow crosshair = new CrosshairWindow();
        SettingsWindow settings = new SettingsWindow();

        private void ActivateCrosshair(object sender, MouseEventArgs e)
        {
            crosshair.Show();
        }

        private void EnterSettings(object sender, MouseEventArgs e)
        {
            settings.Show();
            crosshair.Hide();
            this.Hide();
            menuNotifyIcon.Visible = false;
        }

        private void DeactivateCrosshair(object sender, MouseEventArgs e)
        {
            crosshair.Hide();
        }

        private void QuitProgram(object sender, MouseEventArgs e)
        {
            crosshair.Close();
            settings.Close();
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
