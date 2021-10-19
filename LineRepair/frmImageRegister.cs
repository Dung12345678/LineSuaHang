using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMS
{
    public partial class frmImageRegister : Form
    {
        private string Path;
        public Image ImageReceive { get; set; }
        public frmImageRegister(string name, string content,string path,Image currentImg)
        {
            InitializeComponent();
            lblPart.Text = name;
            lblContent.Text = content;
            Path = path;
            if (currentImg != null) pcb.Image = currentImg;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                Camera.Connected = true;
                Camera.GetVideoCaps();
                Camera.LightOn(1);
                Camera.EnableMicroTouch(true);
                Camera.Preview = true;
            }
            catch (Exception ex)
            {
            }
           
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Camera.Connected = false;
        }
        private void btnSnap_Click(object sender, EventArgs e)
        {
            try
            {
                pcb.Image = Camera.GrabFrame();
                ImageReceive = pcb.Image;
            }
            catch (Exception)
            {
            }
            
        }
        private void Camera_MicroTouchPressed(object sender, EventArgs e)
        {
            try
            {
                pcb.Image = Camera.GrabFrame();
                ImageReceive = pcb.Image;
            }
            catch (Exception)
            {
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
