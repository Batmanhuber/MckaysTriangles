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
            this.ClientSize = new System.Drawing.Size(600, 500);
            this.Controls.Add(this.splitContainer);
            this.Text = "Triangle Information";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        //
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

        // 
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
            String triInfo = "Valid Triangle!";
            String eqiuilateralInfo = "\nEQUILATERAL: \nAn equilateral triangle is a triangle in which all three sides have the same length. In the familiar Euclidean geometry, an equilateral triangle is also equiangular; that is, all three internal angles are also congruent to each other and are each 60°. \nAn Equilateral Triangle is also ISOSCELES.";
            String isosceleseInfo = "\nISOSCELES: \nAn isosceles triangle is a triangle that has two sides of equal length. The two equal sides are called the legs and the third side is called the base of the triangle. Every isosceles triangle has an axis of symmetry along the perpendicular bisector of its base. The two angles opposite the legs are equal and are always acute, so the classification of the triangle as acute, right, or obtuse depends only on the angle between its two legs.";
            String scaleneInfo = "\nSCALENE: \nAll angles of a scalene triangle are unequal. A scalene triangle has no line of symmetry. The angle opposite to the longest side would be the greatest angle and vice versa. All sides of the given scalene triangle are unequal.";
            String rightInfo = "\nRIGHT TRIANGLE: \nA right triangle (American English) or right-angled triangle (British English) is a triangle in which one angle is a right angle (that is, a 90-degree angle). The relation between the sides and angles of a right triangle is the basis for trigonometry. The side opposite the right angle is called the hypotenuse (side c in the figure). The sides adjacent to the right angle are called legs (or catheti, singular: cathetus). Side a may be identified as the side adjacent to angle B and opposed to (or opposite) angle A, while side b is the side adjacent to angle A and opposed to angle B. If the lengths of all three sides of a right triangle are integers, the triangle is said to be a Pythagorean triangle and its side lengths are collectively known as a Pythagorean triple.";
            decimal num1 = this.number1.Value;
            decimal num2 = this.number2.Value;
            decimal num3 = this.number3.Value;
            if(this.isosceles(num1 , num2, num3)){
                if(this.eqiuilateral(num1 , num2, num3))
                    triInfo += eqiuilateralInfo;
                else
                    triInfo += isosceleseInfo;
            }else
                triInfo += scaleneInfo;
            
            if(this.rightTri(num1, num2, num3)){
                triInfo += rightInfo;
            }
            
            return triInfo;
        }

        //
        // determin isosceles
        private bool isosceles(decimal num1, decimal num2, decimal num3){
            if(num1 == num2 || num1 == num3 || num2 == num3){
                return true;
            }else
                return false;
        }
        //
        // determin equilateral
        private bool eqiuilateral(decimal num1, decimal num2, decimal num3){
            if(num1 == num2 && num1 == num3){
                return true;
            }else
                return false;
        }
        private bool rightTri(decimal num1, decimal num2, decimal num3){
            bool isRight = false;
            int max = 1;
            if(max < num2)
                max = 2;
            if(max < num3)
                max = 3;
            switch(max){
                case 1:
                    if((num2*num2)+(num3*num3) == (num1*num1))
                        isRight = true;
                break;
                case 2:
                    if((num1*num1)+(num3*num3) == (num2*num2))
                        isRight = true;
                break;
                case 3:
                    if((num2*num2)+(num1*num1) == (num3*num3))
                        isRight = true;
                break;
            }
            return isRight;
        }
    }
}
