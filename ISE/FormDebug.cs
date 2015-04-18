using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ISE
{
    public partial class FormDebug : Form
    {
        FrameData currentData = null;

        public FormDebug()
        {
            InitializeComponent();
            refreshListBox();
            pictureBoxPreview.Refresh();
        }

        public void refreshListBox()
        {
            listBoxFrames.Items.Clear();
            string[] __keys = FormMain.instance.frameDatas.Keys.ToArray<string>();
            for (int i = 0; i < __keys.Length; i++)
            {
                listBoxFrames.Items.Add(__keys[i]);
            }
        }

        private void listBoxFrames_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxFrames.SelectedItem != null)
            {
                currentData = FormMain.instance.frameDatas[listBoxFrames.SelectedItem.ToString()];
                pictureBoxPreview.Refresh();
            }
        }

        void pictureBoxPreview_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            if (currentData != null && FormMain.instance.textureImage != null)
            {
                Graphics g = e.Graphics;
                g.DrawImage(FormMain.instance.textureImage, new Point(0, 0));
                g.DrawRectangle(new Pen(Color.Green), 0, 0, FormMain.instance.textureImage.Width, FormMain.instance.textureImage.Height);
                g.DrawRectangle(new Pen(Color.Yellow), currentData.frameX, currentData.frameY, currentData.frameWidth, currentData.frameHeight);
                int __sourceX = currentData.frameX - currentData.spriteSourceX;
                int __sourceY = currentData.frameY - currentData.spriteSourceY;
                int __sourceWidth = currentData.sourceWidth;
                int __sourceHeight = currentData.sourceHeight;
                g.DrawRectangle(new Pen(Color.Red), __sourceX, __sourceY, __sourceWidth, __sourceHeight);
            }
        }
    }
}
