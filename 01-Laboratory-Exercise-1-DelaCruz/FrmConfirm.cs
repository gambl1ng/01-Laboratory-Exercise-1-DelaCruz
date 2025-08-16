using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Laboratory_Exercise_1_DelaCruz
{
    public partial class FrmConfirm: Form
    {
        private DelegateText DelProgram, DelLastName, DelFirstName, DelMiddleName,
        DelAddress;

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private DelegateNumber DelNumAge, DelNumContactNo, DelStudNo;

        public FrmConfirm()
        {
            InitializeComponent();
            this.FormClosing += FrmConfirm_FormClosing;

            DelProgram = new DelegateText(StudentInfoClass.GetProgram);
            DelLastName = new DelegateText(StudentInfoClass.GetLastName);
            DelFirstName = new DelegateText(StudentInfoClass.GetFirstName);
            DelMiddleName = new DelegateText(StudentInfoClass.GetMiddleName);
            DelAddress = new DelegateText(StudentInfoClass.GetAddress);
            DelNumAge = new DelegateNumber(StudentInfoClass.GetAge);
            DelNumContactNo = new DelegateNumber(StudentInfoClass.GetContactNo);
            DelStudNo = new DelegateNumber(StudentInfoClass.GetStudentNo);
        }

   
            
        private void FrmConfirm_Load(object sender, EventArgs e)
        {
            labelProgram.Text = "Program: " + DelProgram(StudentInfoClass.Program);
            labelStudentNo.Text = "Student No: " + DelStudNo(StudentInfoClass.StudentNo).ToString();
            labelLastName.Text = "Last Name: " + DelLastName(StudentInfoClass.LastName);
            labelFirstName.Text = "First Name: " + DelFirstName(StudentInfoClass.FirstName);
            labelMiddleName.Text = "Middle Name: " + DelMiddleName(StudentInfoClass.MiddleName);
            labelAge.Text = "Age: " + DelNumAge(StudentInfoClass.Age).ToString();
            labelAddress.Text = "Address: " + DelAddress(StudentInfoClass.Address);
            labelContactNo.Text = "Contact No.: " + DelNumContactNo(StudentInfoClass.ContactNo).ToString();
        }
        private void FrmConfirm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

    }
}


