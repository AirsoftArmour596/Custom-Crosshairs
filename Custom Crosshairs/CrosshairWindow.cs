using System;
using System.IO;
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
    public partial class CrosshairWindow : Form
    {
        public CrosshairWindow()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrosshairWindow));
            this.SuspendLayout();
            this.BackColor = System.Drawing.Color.Magenta;
            this.TransparencyKey = System.Drawing.Color.Magenta;

            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));

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
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
        }
    }
}
