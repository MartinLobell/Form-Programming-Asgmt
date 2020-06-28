//Assignment 4
//Martin Lobell
//2020-04-27

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2.Interfaces;

namespace WindowsFormsApp2
{
    public class Staff
    {
        private string name;
        private List<string> m_qualifications;

        public Staff() { }

        public Staff(string name, List<string> m_qualifications)
        {
            Name = name;
            Qualifications = m_qualifications;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public List<string> Qualifications
        {
            get { return m_qualifications; }
            set { m_qualifications = value; }
        }

        public override string ToString()
        {
            string str = "";
            for(int i = 0; i < m_qualifications.Count; i++)
            {
                str += m_qualifications[i];
            }

            return name + ": " + str;
        }
    }
}
