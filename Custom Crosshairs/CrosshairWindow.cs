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
    public partial class CrosshairWindow : Form
    {
        public Image crosshairImage;
        private MenuWindow menuWindow;

        public CrosshairWindow()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // CrosshairWindow
            // 
            this.BackColor = System.Drawing.Color.Magenta;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(256, 256);
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CrosshairWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Magenta;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
        }

        public void RefreshCrosshair()
        {
            if (crosshairImage == null)
            {
                crosshairImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\data\\crosshairs\\" + UserPreferances.Default.defaultCrosshair);
                Debug.WriteLine("Replaced null with default image.");
            }
            this.BackgroundImage = this.crosshairImage;
            Debug.WriteLine("Started Crosshair Instance with image " + crosshairImage + ".");
        }

        public void IdentifyCaller(MenuWindow Caller)
        {
            RefreshCrosshair();
            menuWindow = Caller;
        }
    }
}
