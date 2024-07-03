using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace task1asp
{
    public partial class page1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
            string name = Text1.Text;
            Label3.Text = name;
            string email = TextBox2.Text;
            Label4.Text = email;
            Label5.Text = TextBox3.Text;
            if (RadioButton1.Checked)
            {
                Label6.Text = RadioButton1.Text;
            }
            if (RadioButton2.Checked)
            {
                Label7.Text = RadioButton2.Text;

            }
            if (CheckBox1.Checked) { Label8.Text = CheckBox1.Text; }
            if (CheckBox2.Checked) { Label9.Text = CheckBox2.Text; }
            if (CheckBox3.Checked) { Label10.Text = CheckBox3.Text; }
            Label11.Text =Text6.Text;




        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(TextBox1.Text);
            double num2 = Convert.ToDouble(TextBox4.Text);
            double sum = num1 + num2;

            Label14.Text =sum.ToString();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(TextBox1.Text);
            double num2 = Convert.ToDouble(TextBox4.Text);
            double sum = num1 * num2;

            Label14.Text = sum.ToString();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(TextBox1.Text);
            double num2 = Convert.ToDouble(TextBox4.Text);
            double sum = num1 - num2;

            Label14.Text = sum.ToString();
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(TextBox1.Text);
            double num2 = Convert.ToDouble(TextBox4.Text);
            double sum = num1 / num2;

            Label14.Text = sum.ToString();
        }
    }
}