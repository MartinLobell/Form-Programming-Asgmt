//Assignment 4
//Martin Lobell
//2020-04-29

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Interfaces
{
    public interface IListManager<T>
    {

        void BinarySerialize(string FileName);

        void BinaryDeSerialize(string FileName);

        void XMLSerialize(string FileName);

        void XmlFileDeserialize(string FileName);

        int Count { get; }

        int Add(T obj);

        bool CheckIndex(int index);

        void DeleteAll();

        bool DeleteAt(int index);

        T GetAt(int anIndex);

        string[] ToStringArray();

        List<string> ToStringList();

    }
}
