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
    public partial class FrmConfirm : Form
    {
        private DelegateText DelProgram, DelLastName, DelFirstName, DelMiddleName, DelAddress;

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void FrmConfirm_Load_1(object sender, EventArgs e)
        {
            tbStudentNo.Text = DelStudNo(StudentInfoClass.StudentNo).ToString();
            programValue.Text = DelProgram(StudentInfoClass.Program);
            tbLastName.Text = DelLastName(StudentInfoClass.LastName);

            tbFirstName.Text = DelFirstName(StudentInfoClass.FirstName);
            tbMiddleName.Text = DelMiddleName(StudentInfoClass.MiddleName);
            tbAge.Text = DelNumAge(StudentInfoClass.Age).ToString();
            tbContactNo.Text = DelNumContactNumber(StudentInfoClass.ContactNo).ToString();
            tbAddress.Text = DelAddress(StudentInfoClass.Address);
        }

        private DelegateNumber DelNumAge, DelNumContactNumber, DelStudNo;
        public FrmConfirm()
        {
            InitializeComponent();

            DelProgram = new DelegateText(StudentInfoClass.GetProgram);
            DelLastName = new DelegateText(StudentInfoClass.GetLastName);
            DelFirstName = new DelegateText(StudentInfoClass.GetFirstName);
            DelMiddleName = new DelegateText(StudentInfoClass.GetMiddleName);
            DelAddress = new DelegateText(StudentInfoClass.GetAddress);

            DelNumAge = new DelegateNumber(StudentInfoClass.GetAge);
            DelNumContactNumber = new DelegateNumber(StudentInfoClass.GetContactNo);
            DelStudNo = new DelegateNumber(StudentInfoClass.GetStudentNo);
        }
        private void FrmConfirm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
