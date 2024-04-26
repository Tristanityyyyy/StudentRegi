using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace StudentRegistrationApplication
{
    public partial class frmStudentRegistration : Form
    {
        public frmStudentRegistration()
        {
            InitializeComponent();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            string firstName = firstText.Text;
            string lastName = lastText.Text;
            string mi = miText.Text;

            string day = comboBox1.Text;
            string month = comboBox2.Text;
            string year = comboBox3.Text;

            string courses = comboBox5.Text;

            string gender = "";
            if (radioButton1.Checked == true) {
                gender = "Male";
            }
            else if (radioButton2.Checked == true) {
                gender = "Female";
            }

            if (string.IsNullOrEmpty(mi))
            {
                message(firstName, lastName, courses);

            }
            else if (string.IsNullOrEmpty(day) || string.IsNullOrEmpty(month) || string.IsNullOrEmpty(year) || string.IsNullOrEmpty(gender))
            {
                message(firstName, mi, lastName, courses);
            }
            else if (!(string.IsNullOrEmpty(gender)))
            {
                message(firstName, mi, lastName, gender, day, month, year, courses);
            }
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            int a = 1;
            while (a <= 31) {
                comboBox1.Items.Add(a);
                a++;
            }

            string[] months = {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

            foreach (string twelve in months) { 
                comboBox2.Items.Add(twelve);
            }
            
            int c = 1900;
            while (c <= 2024)
            {
                comboBox3.Items.Add(c);
                c++;
            }
            string[] course = { "Bachelor of Science in Computer Science", "Bachelor of Science in Information Technology", "Bachelor of Science in Information Systems", "Bachelor of Science in Computer Engineering" };

            foreach (string four in course)
            {
                comboBox5.Items.Add(four);
            }
           

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
         
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog pageSetupDialog1 = new OpenFileDialog();
            pageSetupDialog1.ShowDialog();
            pageSetupDialog1.InitialDirectory = @"C:\";
            pageSetupDialog1.RestoreDirectory = true;
            

            pageSetupDialog1.Title = "Open Image";
            pageSetupDialog1.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";

            if (pageSetupDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.ImageLocation = pageSetupDialog1.FileName;

            }


        }

        public void message(string fname, string miName, string lName, string myGender, string myDay, string myMonth, string myYear, string myCourse) {
            string msg1 = "Student name " + fname + " " + miName + " " + lName;
            string msg2 = "Gender: " + myGender;
            string msg3 = "Date of birth: " + myDay + "/" + myMonth + "/" + myYear;
            string msg4 = "Program: " + myCourse;
            MessageBox.Show(msg1 + "\n" + msg2 + "\n" + msg3 + "\n" + msg4);
        }

        public void message(string fname, string miName, string lName, string myCourse) {
            string msg1 = "Student name " + fname + " " + miName + " " + lName;
            string msg4 = "Program: " + myCourse;
            MessageBox.Show(msg1 + "\n" + msg4);
        }
        public void message(string fName, string lName, string myCourse) {
            string msg1 = "Student name " + fName + " " + lName;
            string msg4 = "Program: " + myCourse;
            MessageBox.Show(msg1 + "\n" + msg4);
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
         
        }
    }
}
