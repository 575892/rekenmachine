using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rekenmachine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (txtstore.Text != "")
            {
                num = float.Parse(txtstore.Text);
                txtresualt.Text = txtstore.Text + "/";
                txtstore.Clear();
                count = 4;
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (txtstore.Text != "")
            {
                num = float.Parse(txtstore.Text);
                txtresualt.Text = txtstore.Text + "+";
                txtstore.Clear();
                count = 2;
            }
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {

            txtstore.Text = txtstore.Text + "3";
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {

            txtstore.Text = txtstore.Text + "6";
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            if (txtstore.Text != "")
            {
                num = float.Parse(txtstore.Text);
                txtresualt.Text = txtstore.Text + "%";
                txtstore.Clear();
                count = 5;
            }
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            if (txtstore.Text != "")
            {
                num = float.Parse(txtstore.Text);
                txtresualt.Text = txtstore.Text + "x";
                txtstore.Clear();
                count = 3;
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            float ans;
            switch (count)
            {
                case 1:
                    ans = num - float.Parse(txtstore.Text);
                    txtresualt.Text = txtresualt.Text + txtstore.Text + "=" + ans;
                    txtstore.Text = ans.ToString();
                    break;
                case 2:
                    ans = num + float.Parse(txtstore.Text);
                    txtresualt.Text = txtresualt.Text + txtstore.Text + "=" + ans;
                    txtstore.Text = ans.ToString();
                    break;

                case 3:
                    ans = num * float.Parse(txtstore.Text);
                    txtresualt.Text = txtresualt.Text + txtstore.Text + "=" + ans;
                    txtstore.Text = ans.ToString();
                    break;

                case 4:
                    ans = num / float.Parse(txtstore.Text);
                    txtresualt.Text = txtresualt.Text + txtstore.Text + "=" + ans;
                    txtstore.Text = ans.ToString();
                    break;

                case 5:
                    ans = num % float.Parse(txtstore.Text);
                    txtresualt.Text = txtresualt.Text + txtstore.Text + "=" + ans;
                    txtstore.Text = ans.ToString();
                    break;
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (txtstore.Text != "")
            { num = float.Parse(txtstore.Text);
                txtresualt.Text = txtstore.Text + "-";
                txtstore.Clear();
                count = 1;
            }
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {

            txtstore.Text = txtstore.Text + "9";
        }

        private void guna2Button14_Click(object sender, EventArgs e)
        {

            txtstore.Text = txtstore.Text + "4";
        }

        private void btndot_Click(object sender, EventArgs e)
        {
            txtstore.Text = txtstore.Text + ".";
        }

        private void btnzero_Click(object sender, EventArgs e)
        {

            txtstore.Text = txtstore.Text + "0";
        }

        private void btnone_Click(object sender, EventArgs e)
        {

            txtstore.Text = txtstore.Text + "1";
        }

        private void btntwo_Click(object sender, EventArgs e)
        {

            txtstore.Text = txtstore.Text + "2";
        }

        private void btnfive_Click(object sender, EventArgs e)
        {

            txtstore.Text = txtstore.Text + "5";
        }

        private void btnseven_Click(object sender, EventArgs e)
        {

            txtstore.Text = txtstore.Text + "7";
        }

        private void btneight_Click(object sender, EventArgs e)
        {

            txtstore.Text = txtstore.Text + "8";
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtresualt.Clear();
            txtstore.Clear();
        }
        float num;
        int count;

    }
}
