using System;
using System.Diagnostics;
using System.IO;
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
    public partial class SettingsWindow : Form
    {

        public Image crosshairImage;
        MenuWindow menuWindow;

        public SettingsWindow()
        {
            InitializeComponent();
            comboBox1.Text = UserPreferances.Default.preferedCrosshair;
        }

        private void SaveNReturn(object sender, MouseEventArgs e)
        {
            SaveChanges();
            menuWindow.Show();
            menuWindow.RefreshWindow();
            this.Hide();
        }

        private void ChangesMade(object sender, EventArgs e)
        {
            PreviewChanges(null, null);
        }

        private void ChangesCommited(object sender, EventArgs e)
        {
            SaveChanges();
        }

        private void ResetDefaults(object sender, MouseEventArgs e)
        {
            comboBox1.Text = UserPreferances.Default.defaultCrosshair;
            UserPreferances.Default.preferedCrosshair = UserPreferances.Default.defaultCrosshair;
            SaveChanges();
        }

        private void PreviewChanges(object sender, EventArgs e)
        {
            this.crosshairPreview.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\data\\crosshairs\\" + comboBox1.Text);
            Debug.WriteLine("Updading preview to show '" + comboBox1.Text + "'");
        }

        private void SaveChanges()
        {
            if (comboBox1.Text != null)
            {
                Debug.WriteLine("Updading Crosshair to '" + comboBox1.Text + "'");
                UserPreferances.Default.preferedCrosshair = comboBox1.Text;
                this.crosshairImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\data\\crosshairs\\" + UserPreferances.Default.preferedCrosshair);
                menuWindow.crosshairImage = this.crosshairImage;
            }
            PreviewChanges(null, null);
            UserPreferances.Default.Save();
            Debug.WriteLine("Saved Changes");
        }

        public void IdentifyCaller(MenuWindow Caller)
        {
            menuWindow = Caller;
        }
    }
}
