//Assignment 4
//Martin Lobell
//2020-04-29

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2.Interfaces;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Collections;
using System.Xml.Serialization;


namespace WindowsFormsApp2
{
    public class ListManager<T> : IListManager<T>
    {
        protected List<T> m_list;

        public ListManager()
        {
            m_list = new List<T>();
        }

        public void BinarySerialize(string FileName)
        {
            FileStream fileStream = null; 
            try 
            { 
                fileStream = new FileStream(FileName, FileMode.Create); 
                BinaryFormatter b = new BinaryFormatter(); 
                b.Serialize(fileStream, m_list);
            } 
            finally 
            { 
                if (fileStream != null) 
                    fileStream.Close(); 
            }
        }

        public void BinaryDeSerialize(string FileName)
        {
            FileStream fileStream = null;

            try
            {
                fileStream = new FileStream(FileName, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                m_list = (List<T>)bf.Deserialize(fileStream);

            }
            finally
            {
                if (fileStream != null)
                    fileStream.Close();
            }
        }

        public void XMLSerialize(string FileName)
        {
            XmlSerializer s = new XmlSerializer(typeof(List<T>));
            TextWriter w = new StreamWriter(FileName);
            try
            {
                s.Serialize(w, m_list);
            }
            finally
            {
                if (w != null) w.Close();
            }
        }

        public void XmlFileDeserialize(string FileName) 
        { 
            XmlSerializer s = new XmlSerializer(typeof(List<T>)); 
            TextReader r = new StreamReader(FileName); 
            try   
            { 
                m_list = (List<T>)s.Deserialize(r);
            } 
            finally   
            { 
                if (r != null) 
                    r.Close();   
            } 
        }

        public int Count
        {
            get
            {
                if ((m_list != null))
                {
                    return m_list.Count;
                }
                else
                {
                    return 0;
                }
            }
        }

        public int Add(T obj)
        {
            m_list.Add(obj);
            return m_list.Count;
        }

        public bool CheckIndex(int index)
        {
            return (m_list != null) & (index < m_list.Count) & (index >= 0);
        }

        public void DeleteAll()
        {
            m_list.Clear();
        }

        public bool DeleteAt(int index)
        {
            if (CheckIndex(index))
            {
                m_list.RemoveAt(index);
                Console.WriteLine("Item removed!");
                return true;
            }
            else
                Console.WriteLine("Item wasn't removed :(");
                return false;
        }

        public T GetAt(int anIndex)
        {
            if (CheckIndex(anIndex))
            {
                return m_list[anIndex];
            }
            else
                return default(T);
        }

        public void Reset()
        {
            m_list = new List<T>();
        }

        public string[] ToStringArray()
        {
            string[] stringArr = new string[]{"Kalle " + "Pelle " + "Svenne " + "Olle " + "Nisse"};

            return stringArr;
        }

        public List<string> ToStringList() 
        {
            var stringList = new List<string>();
            stringList.Add("Kalle");
            stringList.Add("Pelle");
            stringList.Add("Olle");
            stringList.Add("Nisse");
            stringList.Add("Svenne");

            return stringList;
        }
    }
}
