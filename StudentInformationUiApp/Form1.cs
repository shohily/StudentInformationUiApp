using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInformationUiApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        Student aStudent = new Student();
        private void ShowButton_Click(object sender, EventArgs e)
        {
            aStudent.regNo = regTextBox.Text;
            aStudent.firstName = firstNameTextBox.Text;
            aStudent.lastName = lastNameTextBox.Text;
            MessageBox.Show(aStudent.GetFullname() + " " + "Your Reg No Is" + " " + aStudent.GetCode("12"));
            regTextBox.Text = "";
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";

            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void retrieveButton_Click(object sender, EventArgs e)
        {
            regTextBox.Text = aStudent.regNo;
            firstNameTextBox.Text = aStudent.firstName;
            lastNameTextBox.Text = aStudent.lastName;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            regTextBox.Text = "";
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            aStudent.regNo = aStudent.firstName = aStudent.lastName = null;
            
        }
    }
}
