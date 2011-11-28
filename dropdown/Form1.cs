using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace dropdown
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int i;
            for(i=0;i<10;i++)
                comboBox1.Items.Add("suhas kalambe"+i);


            this.comboBox1.DrawMode = DrawMode.OwnerDrawFixed;
            this.comboBox1.DrawItem += new DrawItemEventHandler(comboBox1_DrawItem);

        }

        private void comboBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            string text = this.comboBox1.GetItemText(comboBox1.Items[e.Index]);
            e.DrawBackground();
            using (SolidBrush br = new SolidBrush(e.ForeColor))
            { e.Graphics.DrawString(text, e.Font, br, e.Bounds); }

            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            { this.toolTip1.Show(text, comboBox1, e.Bounds.Right, e.Bounds.Bottom); }
            else { this.toolTip1.Hide(comboBox1); }
            e.DrawFocusRectangle();
        }
    }
}
