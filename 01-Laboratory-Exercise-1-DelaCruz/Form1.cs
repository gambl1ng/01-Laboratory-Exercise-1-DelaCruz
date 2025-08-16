using _01_Laboratory_Exercise_1_DelaCruz;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _01_Laboratory_Exercise_1_DelaCruz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentInfoClass.FirstName = firstname.Text.ToString();
            StudentInfoClass.LastName = lastname.Text.ToString();
            StudentInfoClass.MiddleName = middlename.Text.ToString();
            StudentInfoClass.Address = address.Text.ToString();
            StudentInfoClass.Program = program.Text.ToString();
            StudentInfoClass.Age = Convert.ToInt64(age.Text);
            StudentInfoClass.ContactNo = Convert.ToInt64(contactno.Text);
            StudentInfoClass.StudentNo = Convert.ToInt64(studentno.Text);

            FrmConfirm frmConfirm = new FrmConfirm();
            if (frmConfirm.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Registration Successful!");
                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is System.Windows.Forms.TextBox)
                    {
                        ((System.Windows.Forms.TextBox)ctrl).Clear();
                    }

                    if (ctrl is System.Windows.Forms.ComboBox)
                    {
                        ((System.Windows.Forms.ComboBox)ctrl).SelectedIndex = -1;
                    }

                    this.Close();

                }

            }
        }
    }
}







