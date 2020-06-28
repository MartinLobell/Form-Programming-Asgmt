//Assignment 4
//Martin Lobell
//2020-04-27

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class StaffForm : Form
    { 
        private List<string> m_qualifications = new List<string>();
        private Staff m_staff;

        public Staff Staff 
        {
            get { return m_staff; }
            set { m_staff = value; } 
        }

        public StaffForm()
        {
            InitializeComponent();
            if (m_staff == null)
                {
                    m_staff = new Staff();
                }
        }

        private void UpdateGUI()
        {
            qualificationBox.Text = string.Empty;
            listBox1.Items.Clear();

            List<string> list = new List<string>();
            for (int i = 0; i < m_qualifications.Count; i++)
            {
                list.Add(m_qualifications[i]);
            }

            listBox1.Items.AddRange(printQualifications(list));
        }

        private string[] printQualifications(List<string> qualifications)
        {
            string[] arr = new string[qualifications.Count];
            int count = 0;
            foreach (string i in qualifications)
            {
                arr[count] = i;
                count++;
            }
            return arr;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                AddQualification();
            }
            else
                MessageBox.Show("Fill out all the boxes with valid input!");
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            m_qualifications.RemoveAt(listBox1.SelectedIndex);
            UpdateGUI();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            string Name = staffName.Text;

            Staff = new Staff(Name, m_qualifications);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            qualificationBox.Text = listBox1.SelectedItem.ToString();
        }

        private void changeBtn_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            listBox1.Items.RemoveAt(index);
            listBox1.Items.Insert(index, qualificationBox.Text);
        }

        private bool ValidateInput()
        {
            bool ok = (!string.IsNullOrEmpty(staffName.Text)) &
                      (!string.IsNullOrEmpty(qualificationBox.Text));
            return ok;
        }

        private void AddQualification()
        {
            string ingredient = qualificationBox.Text;
            m_qualifications.Add(ingredient + ", ");

            UpdateGUI();
        }

        public string GetString()
        {
            return Staff.ToString();
        }
    }
}
