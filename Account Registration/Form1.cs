using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Account_Registration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentInfoClass.FirstName = GetFirstName.Text;
            StudentInfoClass.LastName = GetLastName.Text;
            StudentInfoClass.MiddleName = GetMiddleName.Text;
            StudentInfoClass.Address = GetAddress.Text;
            StudentInfoClass.Age = Convert.ToInt64(GetAge.Text);
            StudentInfoClass.ContactNo = Convert.ToInt64(GetContactNo.Text);
            StudentInfoClass.StudentNo = Convert.ToInt64(GetStudentNo.Text);
            StudentInfoClass.Program = GetProgram.Text;

            FrmConfirm frmConfirm = new FrmConfirm();
            DialogResult result = frmConfirm.ShowDialog();

            if (result == DialogResult.OK)
            {
                GetFirstName.Text = "";
                GetLastName.Text = "";
                GetMiddleName.Text = "";
                GetAddress.Text = "";
                GetContactNo.Text = "";
                GetAge.Text = "";
                GetStudentNo.Text = "";
                GetProgram.SelectedIndex = -1;
            }
        }
    }
}
