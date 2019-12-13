using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Xml.Serialization;
namespace _15FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Normal File Writing
            ////File.Exists(@"D:\Demos\Test.txt")
            //FileStream fs = 
            //    new FileStream(@"D:\Demos\Test.txt", 
            //                    FileMode.OpenOrCreate, 
            //                    FileAccess.Write);

            //StreamWriter writer = new StreamWriter(fs);
            //Console.WriteLine("Likho.");
            //writer.WriteLine(Console.ReadLine());
            //writer.Close();
            //fs.Close(); 
            #endregion

            #region Normal File Reading

            //FileStream fs =
            //    new FileStream(@"D:\Demos\Test.txt",
            //                    FileMode.Open,
            //                    FileAccess.Read);

            //StreamReader reader = new StreamReader(fs);

            //string data = reader.ReadToEnd();
            //Console.WriteLine(data);
            //reader.Close();
            //fs.Close();
            #endregion

            #region Binary Serialization
            //FileStream fs =
            //    new FileStream(@"D:\Demos\Test.txt",
            //                    FileMode.OpenOrCreate,
            //                    FileAccess.Write);

            //BinaryFormatter writer = new BinaryFormatter();

            //Emp emp = new Emp();
            //Console.WriteLine("Enter No");
            //emp.No = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter Name");
            //emp.Name = Console.ReadLine();

            //writer.Serialize(fs, emp);
            //writer = null;
            //fs.Close();
            #endregion

            #region Binary DeSerialization
            //FileStream fs =
            //                new FileStream(@"D:\Demos\Test.txt",
            //                                FileMode.Open,
            //                                FileAccess.Read);

            //BinaryFormatter reader = new BinaryFormatter();

            //object obj = reader.Deserialize(fs);

            //if (obj is Emp)
            //{
            //    Emp e = (Emp)obj;
            //    string details = e.GetDetails();
            //    Console.WriteLine(details);
            //}

            //reader = null;
            //fs.Close();
            #endregion

            #region XML Serialization
            //FileStream fs =
            //    new FileStream(@"D:\Demos\Test.xml",
            //                    FileMode.OpenOrCreate,
            //                    FileAccess.Write);

            //XmlSerializer writer = 
            //    new XmlSerializer(typeof(Emp));

            //Emp emp = new Emp();
            //Console.WriteLine("Enter No");
            //emp.No = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter Name");
            //emp.Name = Console.ReadLine();

            //writer.Serialize(fs, emp);
            //writer = null;
            //fs.Close();
            #endregion

            #region XML DeSerialization
            //FileStream fs =
            //                new FileStream(@"D:\Demos\Test.xml",
            //                                FileMode.Open,
            //                                FileAccess.Read);

            //XmlSerializer reader = new XmlSerializer(typeof(Emp));

            //object obj = reader.Deserialize(fs);

            //if (obj is Emp)
            //{
            //    Emp e = (Emp)obj;
            //    string details = e.GetDetails();
            //    Console.WriteLine(details);
            //}

            //reader = null;
            //fs.Close();
            #endregion

            #region SOAP Serialization
            //FileStream fs =
            //    new FileStream(@"D:\Demos\TestSOAP.xml",
            //                    FileMode.OpenOrCreate,
            //                    FileAccess.Write);

            //SoapFormatter writer = new SoapFormatter();

            //Emp emp = new Emp();
            //Console.WriteLine("Enter No");
            //emp.No = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter Name");
            //emp.Name = Console.ReadLine();

            //writer.Serialize(fs, emp);
            //writer = null;
            //fs.Close();
            #endregion

            #region SOAP DeSerialization
            //FileStream fs =
            //                new FileStream(@"D:\Demos\TestSOAP.xml",
            //                                FileMode.Open,
            //                                FileAccess.Read);

            //SoapFormatter reader = new  SoapFormatter();

            //object obj = reader.Deserialize(fs);

            //if (obj is Emp)
            //{
            //    Emp e = (Emp)obj;
            //    string details = e.GetDetails();
            //    Console.WriteLine(details);
            //}

            //reader = null;
            //fs.Close();
            #endregion
        }
    }

    [Serializable]
    public class Emp
    {
        [NonSerialized]
        private string _Password = "abc@123";

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
}
