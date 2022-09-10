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
        }

        private void ActivateCrosshair(object sender, MouseEventArgs e)
        {
            CrosshairWindow crosshair = new CrosshairWindow();
            crosshair.Show();
            this.Hide();
        }

        private void EnterSettings(object sender, MouseEventArgs e)
        {
            SettingsWindow settings = new SettingsWindow();
            settings.Show();
            this.Hide();
        }

        private void QuitProgram(object sender, MouseEventArgs e)
        {
            this.Close();
        }
    }
}
