using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Calculator
{
    class FileController
    {

        public System.IO.StreamWriter Create(string Name)
        {
            return new System.IO.StreamWriter(Name, true);
        }

        public void Write(System.IO.StreamWriter File, string Line)
        {
            File.WriteLine(Line);
            File.Close();
        }

        public Boolean Exists(String Name)
        {
            return System.IO.File.Exists(Name);
        }

        public ArrayList Read(System.IO.StreamReader File)
        {

            string line;
            ArrayList list = new ArrayList();
            while ((line = File.ReadLine()) != null)
            {
                list.Add(line);
            }
            File.Close();
            return list;
        }

        public void Open(String Name)
        {


        }

    }
}
