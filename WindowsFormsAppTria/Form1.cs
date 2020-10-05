using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppTria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            double c = double.Parse(textBox3.Text);
            Triangle t = new Triangle(a, b, c);
            label4.Text = t.Perimeter();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            double c = double.Parse(textBox3.Text);
            Triangle t = new Triangle(a, b, c);
            label5.Text = t.CalculateAngles();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            double c = double.Parse(textBox3.Text);
            Isocale t = new Isocale(a, b, c);
            label6.Text = t.Area();
        }
    }

    

    class Triangle
    {
        protected double a;
        protected double b;
        protected double c;

        public Triangle(double a, double b, double c)
        {
            if (a > (b + c) || b > (a + c) || c > (a + b))
            {
                throw new ArithmeticException();
            }

            else if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArithmeticException();
            }
            else
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }
        }

        public string CalculateAngles()
        {
            double alpha = Math.Acos((Math.Pow(a, 2) + Math.Pow(c, 2) - Math.Pow(b, 2)) / (2 * a * c));
            double beta = Math.Acos((Math.Pow(a, 2) + Math.Pow(b, 2) - Math.Pow(c, 2)) / (2 * a * b));
            double gamma = Math.Acos((Math.Pow(b, 2) + Math.Pow(c, 2) - Math.Pow(c, 2)) / (2 * b * c));
            return "alpha = " + Math.Round(alpha, 2).ToString() + "\n" + "beta = " + Math.Round(beta, 2).ToString() + "\n" + " gamma = " + Math.Round(gamma, 2).ToString();
        }

        public string Perimeter()
        {
            double p = a + b + c;
            return "Периметр = " + p.ToString();
        }
    }

    class Isocale : Triangle
    {
        public Isocale(double a, double b, double c) : base(a,b,c) 
        {
            if (a != b)
            {
                throw new ArithmeticException();
            }
        }

        public string Area()
        {

                double h = Math.Sqrt(Math.Pow(a, 2) - Math.Pow(c / 2, 2));
                double s = 0.5 * c * h;
                return "Площадь = " + Math.Round(h, 2).ToString();

        }
    }


}
