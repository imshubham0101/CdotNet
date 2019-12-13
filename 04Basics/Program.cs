#region New Code with Reflection

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Reflection;

namespace _04Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger logger = Logger.GetLogger();
            logger.Log("Main Started");

            DocumentFactory df = new DocumentFactory();
            Document d = df.GetDocument();
            d.Generate();
            Console.ReadLine();
        }
    }

    public class DocumentFactory
    {
        public Document GetDocument()
        {
            Logger logger = Logger.GetLogger();
            logger.Log("Document Factory Called");

            string doctype=ConfigurationManager.AppSettings["docType"];
            Assembly assembly = Assembly.GetExecutingAssembly();
            object someDocumentObject =
                assembly.CreateInstance(doctype);
            return someDocumentObject as Document;
        }
    }

    public abstract class Document
    {
        protected Logger currentLogger = null;
        public Document()
        {
            this.currentLogger = Logger.GetLogger();
        }


        protected abstract void Create();
        protected abstract void Parse();
        protected abstract void Validate();

        protected abstract void Save();

        public virtual void Generate()
        {
            this.currentLogger.Log("Generate of Document Called");

            this.Create();
            this.Parse();
            this.Validate();
            this.Save();
        }
    }

    public class PDF : Document
    {
        protected override void Create()
        {
            Console.WriteLine("PDF Created");
            currentLogger.Log("PDF Create Called");
        }
        protected override void Parse()
        {
            Console.WriteLine("PDF Parsed");
            currentLogger.Log("PDF Parse Called");
        }
        protected override void Validate()
        {
            Console.WriteLine("PDF Validated");
            currentLogger.Log("PDF Validate Called");
        }
        protected override void Save()
        {
            Console.WriteLine("PDF Saved");
            currentLogger.Log("PDF Save Called");
        }
    }

    public class DOCX : Document
    {
        protected override void Create()
        {
            Console.WriteLine("DOCX Created");
        }
        protected override void Parse()
        {
            Console.WriteLine("DOCX Parsed");
        }
        protected override void Validate()
        {
            Console.WriteLine("DOCX Validated");
        }
        protected override void Save()
        {
            Console.WriteLine("DOCX Saved");
        }


    }

    public abstract class SpecialDocument : Document
    {
        protected abstract void ReValidate();
        public override void Generate()
        {
            this.Create();
            this.Parse();
            this.Validate();
            this.ReValidate();
            this.Save();
        }
    }

    public class TXT : SpecialDocument
    {
        protected override void Create()
        {
            Console.WriteLine("TXT Created");
        }
        protected override void Parse()
        {
            Console.WriteLine("TXT Parsed");
        }
        protected override void Validate()
        {
            Console.WriteLine("TXT Validated");
        }

        protected override void Save()
        {
            Console.WriteLine("TXT Saved");
        }
        protected override void ReValidate()
        {
            Console.WriteLine("TXT Revalidated");
        }
    }

    public class XML : SpecialDocument
    {
        protected override void Create()
        {
            Console.WriteLine("XML Created");
        }
        protected override void Parse()
        {
            Console.WriteLine("XML Parsed");
        }
        protected override void Validate()
        {
            Console.WriteLine("XML Validated");
        }

        protected override void Save()
        {
            Console.WriteLine("XML Saved");
        }
        protected override void ReValidate()
        {
            Console.WriteLine("XML Revalidated");
        }
    }

    public class Logger
    {
        private static Logger _logger = new Logger();

        private Logger()
        {
            Console.WriteLine("Logger Object Created");
        }

        public static Logger GetLogger()
        {
            return _logger;
        }


        public void Log(string message)
        {
            //Write message in  DB/File/EMail/*
            Console.WriteLine("Logged! " + DateTime.Now.ToString() + " - " + message);
        }
    }
}
#endregion

#region Old Code Without Reflection
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _04Basics
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Logger logger = Logger.GetLogger();
//            logger.Log("Main Started");

//            DocumentFactory df = new DocumentFactory();

//            Console.WriteLine("1: PDF");
//            Console.WriteLine("2: DOCX");
//            Console.WriteLine("3: TXT");
//            Console.WriteLine("4: XML");
//            int choice = Convert.ToInt32(Console.ReadLine());

//            Document d = df.GetDocument(choice);
//            d.Generate();


//            Console.ReadLine();
//        }
//    }

//    public class DocumentFactory
//    {
//        public Document GetDocument(int choice)
//        {
//            Logger logger = Logger.GetLogger();
//            logger.Log("Documnet Factory Called");

//            if (choice == 1)
//            {
//                return new PDF();
//            }
//            if (choice == 2)
//            {
//                return new DOCX();
//            }
//            if(choice == 3)
//            {
//                return new TXT();
//            }
//            else
//            {
//                return new XML();
//            }
//        }
//    }

//    public abstract class Document
//    {
//        protected Logger currentLogger = null;
//        public Document()
//        {
//            this.currentLogger = Logger.GetLogger();
//        }


//        protected abstract void Create();
//        protected abstract void Parse();
//        protected abstract void Validate();

//        protected abstract void Save();

//        public virtual void Generate()
//        {
//            this.currentLogger.Log("Generate of Document Called");

//            this.Create();
//            this.Parse();
//            this.Validate();
//            this.Save();
//        }
//    }

//    public class PDF : Document
//    {
//        protected override void Create()
//        {
//            Console.WriteLine("PDF Created");
//            currentLogger.Log("PDF Create Called");
//        }
//        protected override void Parse()
//        {
//            Console.WriteLine("PDF Parsed");
//            currentLogger.Log("PDF Parse Called");
//        }
//        protected override void Validate()
//        {
//            Console.WriteLine("PDF Validated");
//            currentLogger.Log("PDF Validate Called");
//        }
//        protected override void Save()
//        {
//            Console.WriteLine("PDF Saved");
//            currentLogger.Log("PDF Save Called");
//        }
//    }

//    public class DOCX:Document
//    {
//        protected override void Create()
//        {
//            Console.WriteLine("DOCX Created");
//        }
//        protected override void Parse()
//        {
//            Console.WriteLine("DOCX Parsed");
//        }
//        protected override void Validate()
//        {
//            Console.WriteLine("DOCX Validated");
//        }
//        protected override void Save()
//        {
//            Console.WriteLine("DOCX Saved");
//        }


//    }

//    public abstract class SpecialDocument:Document
//    {
//        protected abstract void ReValidate();
//        public override void Generate()
//        {
//            this.Create();
//            this.Parse();
//            this.Validate();
//            this.ReValidate();
//            this.Save();
//        }
//    }

//    public class TXT : SpecialDocument
//    {
//        protected override void Create()
//        {
//            Console.WriteLine("TXT Created");
//        }
//        protected override void Parse()
//        {
//            Console.WriteLine("TXT Parsed");
//        }
//        protected override void Validate()
//        {
//            Console.WriteLine("TXT Validated");
//        }

//        protected override void Save()
//        {
//            Console.WriteLine("TXT Saved");
//        }
//        protected override void ReValidate()
//        {
//            Console.WriteLine("TXT Revalidated");
//        }
//    }

//    public class XML : SpecialDocument
//    {
//        protected override void Create()
//        {
//            Console.WriteLine("XML Created");
//        }
//        protected override void Parse()
//        {
//            Console.WriteLine("XML Parsed");
//        }
//        protected override void Validate()
//        {
//            Console.WriteLine("XML Validated");
//        }

//        protected override void Save()
//        {
//            Console.WriteLine("XML Saved");
//        }
//        protected override void ReValidate()
//        {
//            Console.WriteLine("XML Revalidated");
//        }
//    }

//    public class Logger
//    {
//        private static Logger _logger = new Logger();

//        private Logger()
//        {
//            Console.WriteLine("Logger Object Created");
//        }

//        public static Logger GetLogger()
//        {
//            return _logger;
//        }


//        public void Log(string message)
//        {
//            //Write message in  DB/File/EMail/*
//            Console.WriteLine("Logged! " + DateTime.Now.ToString() + " - " + message);
//        }
//    }
//}
#endregion
