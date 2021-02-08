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
        private Label label1, label2;
        private NumericUpDown number1, number2, number3;
        private SplitContainer splitContainer;
        private FlowLayoutPanel flowLayoutPanel;
        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.number1 = new System.Windows.Forms.NumericUpDown();
            this.number2 = new System.Windows.Forms.NumericUpDown();
            this.number3 = new System.Windows.Forms.NumericUpDown();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            //
            // label1
            //
            this.label1.Dock = System.Windows.Forms.DockStyle.None;
            this.label1.Text = "Enter side Lengths \na, b, and c";
            this.label1.Size = new Size (label1.PreferredWidth, label1.PreferredHeight);
            //
            // label2
            //
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Text = "Please Select Three Side Lengths that make a Valid Triangle";
            this.label2.Size = new Size (label2.PreferredWidth, label2.PreferredHeight);
            // 
            // Number1
            // 
            this.number1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.number1.Maximum = 5000;
            this.number1.ValueChanged += new EventHandler(number1_Change);
            // 
            // Number2
            // 
            this.number2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.number2.Maximum = 5000;
            this.number2.ValueChanged += new EventHandler(number2_Change);
            // 
            // Number3
            // 
            this.number3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.number3.Maximum = 5000;
            this.number3.ValueChanged += new EventHandler(number3_Change);
            //
            // flowLayout Panel
            //
            this.flowLayoutPanel.FlowDirection = FlowDirection.TopDown;
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel.Controls.Add(label1);
            this.flowLayoutPanel.Controls.Add(number1);
            this.flowLayoutPanel.Controls.Add(number2);
            this.flowLayoutPanel.Controls.Add(number3);
            //
            // Split Container
            //
            splitContainer.BorderStyle = BorderStyle.Fixed3D;
            splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer.Panel1.Controls.Add(this.flowLayoutPanel);
            splitContainer.Panel2.Controls.Add(this.label2);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Controls.Add(this.splitContainer);
            this.Text = "Triangle Information";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        //
        // Event handlers for submission of side lengths 1 2 and 3
        //
        private void number1_Change(object sender, System.EventArgs e){
            if(this.valid_input()){
                this.label2.Text = check_Triagle();
            }
            else{
                this.label2.Text = "Please Select Three Side Lengths that make a Valid Triangle";
            }
            
        }
        private void number2_Change(object sender, System.EventArgs e){
            if(this.valid_input()){
                this.label2.Text = check_Triagle();
            }
            else{
                this.label2.Text = "Please Select Three Side Lengths that make a Valid Triangle";
            }
            
        }
        private void number3_Change(object sender, System.EventArgs e){
            if(this.valid_input()){
                this.label2.Text = check_Triagle();
            }
            else{
                this.label2.Text = "Please Select Three Side Lengths that make a Valid Triangle";
            }
            
        }

        // TODO:
        // make sure input is a valid triangle
        private bool valid_input(){
            bool valid = false;
            decimal num1 = this.number1.Value;
            decimal num2 = this.number2.Value;
            decimal num3 = this.number3.Value;

            if(this.number1.Value == 0 || this.number2.Value == 0 || this.number3.Value == 0){
                valid = false;
            }else if(num1 + num2 > num3 && num2 + num3 > num1 && num3 + num1 > num2){
                valid = true;
            }

            return valid;
        }

        // TODO:
        // check type of tirangle return info
        private String check_Triagle(){
            return "Valid Triangle!";
        }

        //
        // find max side
        private decimal my_Max(decimal num1, decimal num2, decimal num3){
            decimal max = num1;

            if(max < num2){
                max = num2;
            }
            if(max < num3){
                max = num3;
            }
            return max;
        }
    }
}
