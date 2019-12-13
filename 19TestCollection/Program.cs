using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _19TestCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            Emp e1 = new Emp();
            e1.No = 10;
            e1.Name = "abc";

            Emp e2 = new Emp();
            e2.No = 20;
            e2.Name = "xyz";

            Book b1 = new Book();
            b1.Title = "BHMD";
            b1.Author = "MP";
            b1.ISBN = 19199;

            //Dictionary<string, object> col = new Dictionary<string, object>();
            //Hashtable col = new Hashtable();
            //col.Add("e1", e1);
            //col.Add("e2", e2);
            //col.Add("b1", b1);

            ArrayList col = new  ArrayList();
            col.Add( e1);
            col.Add(e2);
            col.Add(b1);
            FileStream fs = new FileStream("D:\\Demos\\demo.xml", FileMode.OpenOrCreate, FileAccess.Write);
            Type[] arr = new Type[] { typeof(Emp), typeof(Book) };
            XmlSerializer xs = new XmlSerializer(typeof(ArrayList),arr);
            xs.Serialize(fs, col);
            xs = null;
            fs.Close();

            //FileStream fs = new FileStream("D:\\Demos\\demo.txt", FileMode.OpenOrCreate, FileAccess.Read);
            //BinaryFormatter bf = new BinaryFormatter();
            //bf.Serialize(fs, col);
            //bf = null;
            //////object someData= bf.Deserialize(fs);
            //////Dictionary<string, object> dict = (Dictionary<string, object>)someData;
            //////bf = null;
        }
    }
    [Serializable]
    public class Emp
    {
        private int _No;

        public int No
        {
            get { return _No; }
            set { _No = value; }
        }

        private string _Name;

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public string GetDetails()
        {
            return string.Format("No = {0}, Name = {1}",this.No, this.Name);
        }

    }

    [Serializable]
    public class Book
    {
        private string _Title;
        private string _Author;
        private int _ISBN;

        public int ISBN
        {
            get { return _ISBN; }
            set { _ISBN = value; }
        }

        public string Author
        {
            get { return _Author; }
            set { _Author = value; }
        }

        public string Title
        {
            get { return _Title; }
            set { _Title = value; }
        }

    }
}
