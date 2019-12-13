using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Boxing UnBoxing
            //int i = 100; //Stack
            //object obj = i; //Boxing

            //int j = Convert.ToInt32(obj); //UnBoxing
            //Console.WriteLine(j);
            #endregion

            #region Emp Casting 
            //Emp e1 = new Emp(); // Heap
            //object obj = e1; // cast
            ////Emp e = (Emp) obj; // Casting
            ////Emp e = obj as Emp; // Casting
            //Console.WriteLine(e.GetDetails());
            #endregion

            #region string type casting
            //string str = "abc"; //Heap
            //object obj = str; //Casting
            //string s = obj.ToString();//casting
            //Console.WriteLine(s);
            #endregion

            #region Simple Int Array
            //int[] arr = new int[] { 100,200,300,400};
            //int[] arr = new int[3];
            //arr[0] = 1001;
            //arr[1] = 1002;
            //arr[2] = 1003;

            // arr[3] = 1004; //<-- this will end up in err

            //foreach (int data in arr)
            //{
            //    Console.WriteLine(data);
            //}

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}
            #endregion

            #region Emp Declarations
            Emp e1 = new Emp();
            e1.No = 1;
            e1.Name = "Mahesh";

            Emp e2 = new Emp();
            e2.No = 2;
            e2.Name = "Sandip";

            Emp e3 = new Emp();
            e3.No = 3;
            e3.Name = "Amit";

            #endregion

            #region Emp Array
            //Emp[] arr = new Emp[] { e1, e2, e3 };

            //foreach (Emp e in arr)
            //{
            //    Console.WriteLine(e.GetDetails());
            //}
            #endregion

            #region Object Array
            //object []arr = new object[3];
            //arr[0] = 100; // Boxing
            //arr[1] = "abc"; // Casting
            //arr[2] = e1; //Casting

            //foreach (object obj in arr)
            //{
            //    if(obj is int)
            //    { 
            //        int i = Convert.ToInt32(obj); //UnBoxing
            //        Console.WriteLine(i);
            //    }
            //    else if(obj is string)
            //    {
            //        string s = obj.ToString(); //Casting
            //        Console.WriteLine(s);
            //    }
            //    else if (obj is Emp)
            //    {
            //        Emp e = (Emp)obj; //Casting
            //        Console.WriteLine(e.GetDetails());
            //    }
            //} 
            #endregion

            #region ArrayList
            //ArrayList arr = new ArrayList();

            //arr.Add(100); // Boxing
            //arr.Add("abc"); // Casting
            //arr.Add(e1); //Casting
            //arr.Add(e2); //Casting

            //object o = arr[2];
            //Emp eData = (Emp)o; //Casting
            //Console.WriteLine(eData.GetDetails());

            //foreach (object obj in arr)
            //{
            //    if (obj is int)
            //    {
            //        int i = Convert.ToInt32(obj); //UnBoxing
            //        Console.WriteLine(i);
            //    }
            //    else if (obj is string)
            //    {
            //        string s = obj.ToString(); //Casting
            //        Console.WriteLine(s);
            //    }
            //    else if (obj is Emp)
            //    {
            //        Emp e = (Emp)obj; //Casting
            //        Console.WriteLine(e.GetDetails());
            //    }
            //} 
            #endregion

            #region HashTable
            //Hashtable arr = new Hashtable();

            //arr.Add("a", 100); // Boxing
            //arr.Add("b", "abc"); // Casting
            //arr.Add("c", e1); //Casting
            //arr.Add("d", e2); //Casting

            //object o = arr["c"];
            //Emp eData = (Emp)o; //Casting
            //Console.WriteLine(eData.GetDetails());

            ////foreach (object key in arr.Keys)
            ////{
            ////    Console.WriteLine(key.ToString());
            ////}

            //foreach (object key in arr.Keys)
            //{
            //    object obj = arr[key];
            //    if (obj is int)
            //    {
            //        int i = Convert.ToInt32(obj); //UnBoxing
            //        Console.WriteLine(i);
            //    }
            //    else if (obj is string)
            //    {
            //        string s = obj.ToString(); //Casting
            //        Console.WriteLine(s);
            //    }
            //    else if (obj is Emp)
            //    {
            //        Emp e = (Emp)obj; //Casting
            //        Console.WriteLine(e.GetDetails());
            //    }
            //}
            #endregion

            #region Calling Generic Method from Generic Class
            //int p = 100;
            //int q = 200;

            //Maths<int> obj = new Maths<int>();
            //Console.WriteLine("Before Swap P = {0}, Q = {1}", p, q);
            //obj.Swap(ref p, ref q);
            //Console.WriteLine("After Swap P = {0}, Q = {1}", p, q); 
            #endregion

            #region Calling Normal Method using Generic Class
            //Maths<string> obj = new Maths<string>();
            //Console.WriteLine(obj.Add(10, 20)) ; 
            #endregion

            #region Calling Normal & Generic Method from Non Generic Class
            //Maths obj = new Maths();
            //Console.WriteLine(obj.Add(10, 20));

            //int p = 100;
            //int q = 200;
            //Console.WriteLine("Before Swap P = {0}, Q = {1}", p, q);
            //obj.Swap<int>(ref p, ref q);
            //Console.WriteLine("After Swap P = {0}, Q = {1}", p, q);
            #endregion

            #region Calling Generic Method from Normal Class derived from generic class
            //int p = 100;
            //int q = 200;

            //SpecialMaths obj = new SpecialMaths();
            //Console.WriteLine("Before Swap P = {0}, Q = {1}", p, q);
            //obj.Swap(ref p, ref q);
            //Console.WriteLine("After Swap P = {0}, Q = {1}", p, q);
            #endregion

            #region Calling Generic Methods from Generic Class derived from generic class
            //int p = 100;
            //int q = 200;

            //SpecialMaths<int, string, Emp, bool> obj = new SpecialMaths<int, string, Emp, bool>();
            //Console.WriteLine("Before Swap P = {0}, Q = {1}", p, q);
            //obj.Swap(ref p, ref q);
            //Console.WriteLine("After Swap P = {0}, Q = {1}", p, q);

            //bool result =
            //    obj.NonsenseMethod(10, "abc", e1, true);
            //Console.WriteLine(result);

            #endregion

            #region Generic List<T>
            // List<Emp> arr = new List<Emp>();
            // arr.Add(e1);
            // arr.Add(e2);
            // arr.Add(e3);

            //// List<object> lst = new List<object>();
            // //Above line is similar to ArrayList

            // foreach (Emp e in arr)
            // {
            //     Console.WriteLine(e.GetDetails());
            // }
            #endregion

            #region Generic Stack
            //Stack<Emp> arr = new Stack<Emp>();
            //arr.Push(e1);
            //arr.Push(e2);
            //arr.Push(e3);

            ////Emp e = arr.Pop();
            ////Console.WriteLine(e.GetDetails());

            ////Emp es = arr.Pop();
            ////Console.WriteLine(es.GetDetails());
            //foreach (Emp e in arr)
            //{
            //    Console.WriteLine(e.GetDetails());
            //}
            #endregion

            #region Generic Queue
            //Queue<Emp> arr = new Queue<Emp>();
            //arr.Enqueue(e1);
            //arr.Enqueue(e2);
            //arr.Enqueue(e3);

            ////arr.Dequeue()
            //foreach (Emp e in arr)
            //{
            //    Console.WriteLine(e.GetDetails());
            //}
            #endregion

            #region Generic Dictionary
            //Dictionary<string, Emp> arr =
            //    new Dictionary<string, Emp>();
            //arr.Add("a", e1);
            //arr.Add("b", e2);
            //arr.Add("c", e3);

            //foreach (string key in arr.Keys)
            //{
            //    Emp e = arr[key];
            //    Console.WriteLine(e.GetDetails());
            //}
            ////foreach (string key in arr.Keys)
            ////{
            ////    Console.WriteLine(key);
            ////}
            #endregion

            #region Indexer
            //Week week = new Week();
            ////Console.WriteLine(week[0]);
            //Console.WriteLine(week["a"]);
            #endregion
        }
    }

    #region Indexer
    //public class Week
    //{
    //    //private string[] days = new string[]{"mon","tue","wed", "thu", "fri", "sat", "sun"};

    //    private Hashtable days = new Hashtable();
    //    public Week()
    //    {
    //        days.Add("a", "Mon");
    //        days.Add("b", "Tue");
    //        days.Add("c", "Wed");
    //        days.Add("d", "Thu");
    //        days.Add("e", "Fri");
    //        days.Add("f", "Sat");
    //        days.Add("g", "Sun");
    //    }
    //    //public string this[int index]
    //    //{
    //    //    get { return days[index]; }
    //    //}

    //    public string this[string key]
    //    {
    //        get { return days[key].ToString(); }
    //    }

    //}
    #endregion

    #region Inherit Generic class in Generic Class
    //public class Maths<T>
    //{
    //    public void Swap(ref T x, ref T y)
    //    {
    //        T z = x;
    //        x = y;
    //        y = z;
    //    }
    //}

    //public class SpecialMaths<P,Q,R,S> : Maths<P>
    //{
    //    public S NonsenseMethod(P p, Q q, R r, S s)
    //    {
    //        //Some not existing logic
    //        return s;
    //    }

    //}
    #endregion

    #region Inherit Generic Class in NonGeneric Class
    //public class Maths<T>
    //{
    //    public void Swap(ref T x, ref T y)
    //    {
    //        T z = x;
    //        x = y;
    //        y = z;
    //    }
    //}

    //public class SpecialMaths:Maths<int>
    //{
    //}
    #endregion

    #region Normal Class with Generic Method & Non Generic Method
    //public class Maths
    //{
    //    public void Swap<T>(ref T x, ref T y)
    //    {
    //        T z = x;
    //        x = y;
    //        y = z;
    //    }

    //    public int Add(int x, int y)
    //    {
    //        return x + y;
    //    }
    //} 
    #endregion

    #region Generic Class with Generic Method & NonGeneric Method
    //public class Maths<T>
    //{
    //    public void Swap(ref T x, ref T y)
    //    {
    //        T z = x;
    //        x = y;
    //        y = z;
    //    }

    //    public int Add(int x, int y)
    //    {
    //        return x + y;
    //    }
    //}
    #endregion

    #region Generic Class with Generic Method
    //public class Maths<T>
    //{
    //    public void Swap(ref T x,ref T y)
    //    {
    //        T z = x;
    //        x = y;
    //        y = z;
    //    }
    //} 
    #endregion

    public class Emp
    {
        private int _No;
        private string _Name;

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public int No
        {
            get { return _No; }
            set { _No = value; }
        }

        public Emp()
        {
            this.No = 10;
            this.Name = "ABC";
        }

        //public override string ToString()
        //{
        //    return string.Format("No = {0}, Name = {1}", this.No, this.Name);
        //}
        public string GetDetails()
        {
            return string.Format("No = {0}, Name = {1}", this.No, this.Name);
        }

    }
}