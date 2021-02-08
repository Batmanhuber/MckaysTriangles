using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MckaysTriangles
{
    public partial class Form1 : Form
    {
        private Label label1;
        private TextBox textBox1,textBox2,textBox3;
        private Button button;
        private SplitContainer splitContainer;
        private FlowLayoutPanel flowLayoutPanel;
        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button = new System.Windows.Forms.Button();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            //
            // label1
            //
            this.label1.Dock = System.Windows.Forms.DockStyle.None;
            this.label1.Text = "Enter three sides\nfor a triangle";
            this.label1.Size = new Size (label1.PreferredWidth, label1.PreferredHeight);
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // textBox3
            //
            this.textBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            //
            // button
            //
            this.button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button.Text = "Submit";
            this.button.Size = new Size (button.PreferredSize.Width,button.PreferredSize.Height);
            //
            // flowLayout Panel
            //
            this.flowLayoutPanel.FlowDirection = FlowDirection.TopDown;
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel.Controls.Add(label1);
            this.flowLayoutPanel.Controls.Add(textBox1);
            this.flowLayoutPanel.Controls.Add(textBox2);
            this.flowLayoutPanel.Controls.Add(textBox3);
            this.flowLayoutPanel.Controls.Add(button);
            //
            // Split Container
            //
            splitContainer.BorderStyle = BorderStyle.Fixed3D;
            splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer.Panel1.Controls.Add(this.flowLayoutPanel);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Controls.Add(this.splitContainer);
            this.Text = "TextBox Example";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
