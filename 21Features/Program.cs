using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Diagnostics;
using System.Linq.Expressions;

namespace _21Features
{
    public delegate bool MyDelegate(int i);
   // public delegate P AnotherDelegate<P,Q>(Q lst);
    class Program
    {
        static void Main(string[] args)
        {
            #region Partial Class - Maths 
            //Maths obj = new Maths();
            //Console.WriteLine(obj.Add(10, 20)) ;
            //Console.WriteLine(obj.Sub(20, 30));
            #endregion

            #region Nullable Type
            //int? salary = 10;

            ////Nullable<int> salary = 10;
            //salary = null;
            //Console.WriteLine(salary.HasValue);
            #endregion

            #region Anonymous Method
            //bool result = Check(20);
            //Console.WriteLine(result);

            //MyDelegate pointer = new MyDelegate(Check);
            //bool result = pointer(20);
            //Console.WriteLine(result);

            //MyDelegate pointer = delegate (int i)
            //                    {
            //                        return (i > 10);
            //                    };
            //bool result = pointer(20);
            //Console.WriteLine(result); 
            #endregion

            #region Lambada Expression

            //////MyDelegate pointer = new MyDelegate(Check);
            //////bool result = pointer(20);
            //////Console.WriteLine(result);

            //////MyDelegate pointer = delegate (int i)
            //////                    {
            //////                        return (i > 10);
            //////                    };
            //////bool result = pointer(20);

            //MyDelegate pointer = (i)=>
            //                        {
            //                            return (i > 10);
            //                        };
            //bool result = pointer(20);
            //Console.WriteLine(result);

            #endregion

            #region Iterator
            ////List<string> lst = new List<string>();

            //Week week = new Week();
            //foreach (string day in week)
            //{
            //    Console.WriteLine(day);
            //}

            //string currentday = week[2];
            //Console.WriteLine(currentday);
            #endregion

            #region Implicit Type
            //var i = 100;
            //i = 10;
            //var e = new object();

            //var v; //<--This will end up in err

            #endregion

            #region Object Initializer
            //Old way of initializing object properties
            ////Emp e1 = new Emp();
            ////e1.No = 1;
            ////e1.Name = "mahesh";
            //Emp e1 = new Emp() { No = 1, Name = "mahesh" };
            //Console.WriteLine(e1.GetDetails());
            #endregion

            #region Anonymous Type / Array
            ////var e1 = new { No = 1, Name = "mahesh" };
            //////e1.Name = "changed";

            ////Console.WriteLine(e1.No + e1.Name);

            //var e1 = new { No = 1, Name = "mahesh" };
            //var e2 = new { No = 2, Name = "nilesh" };

            //var arr = new[] 
            //            {
            //                new { No = 1, Name = "mahesh" },
            //                new { No = 2, Name = "nilesh" }
            //            };

            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item.Name);
            //}

            #endregion

            #region Extension Method
            //string str = "pqr";
            //MyExtension.CheckForValidEMailAddress(str, 100);
            //str.CheckForValidEMailAddress(44);
            //SomeClass someObject = new SomeClass();
            //someObject.SomeMethod();

            ////ABC.SomeOtherMethod(someObject);

            //someObject.SomeOtherMethod(100);


            //int[] arr = new int[] { 10, 20, 30, 40, 50, 60, 70, 80, 90 };
            //var v = new { no = 1, name = "abc"};

            #endregion

            #region Sample Emp Collection

            var emps = new List<Emp>()
            {
                new Emp { No =  11 , Name = "Sourabh", Address="Nagar"},
                new Emp { No =  12 , Name = "Chaitanya", Address="Washim"},
                new Emp { No =  13 , Name = "Keshav", Address="Shegaon"},
                new Emp { No =  14 , Name = "Bhagyesh", Address="Jalgaon"},
                new Emp { No =  15 , Name = "Deepak", Address="Raipur"},
                new Emp { No =  16 , Name = "Rupali", Address="Barhanpur"},
                new Emp { No =  17 , Name = "Mahesh", Address="Nagar"}
            };
            #endregion

            #region Asking for Filter Value

            //Console.WriteLine("Enter City Keyword to search the record with");
            //string filter = Console.ReadLine();

            //Console.WriteLine("Enter City Keyword to search second level the record with");
            //string filter2 = Console.ReadLine();
            #endregion

            #region Routine Search

            //List<Emp> filteredEmps = new List<Emp>();

            //foreach (Emp emp in emps)
            //{
            //    if (emp.Address.EndsWith(filter))
            //    {
            //        //Console.WriteLine(emp.Name);
            //        filteredEmps.Add(emp);
            //    }
            //}

            //foreach (Emp emp in filteredEmps)
            //{
            //    Console.WriteLine(emp.GetDetails());
            //}
            #endregion

            #region Normal LINQ + Differed Lazy Execution
            ////var result = from emp in emps
            ////             where emp.Address.ToLower().Contains(filter.ToLower())
            ////             select emp;


            ////emps.Add(new Emp() { No = 18, Name = "Yogesh", Address = "Nasik" });

            ////foreach (var emp in result)
            ////{
            ////    Console.WriteLine("No = {0}, Name = {1}, Address = {2}", emp.No, emp.Name, emp.Address);
            ////}
            #endregion

            #region LINQ Differed execution with ToList()
            //var result = (from emp in emps
            //              where emp.Address.ToLower().Contains(filter.ToLower())
            //              select emp).ToList();


            //emps.Add(new Emp() { No = 18, Name = "Yogesh", Address = "Nasik" });

            //foreach (var emp in result)
            //{
            //    Console.WriteLine("No = {0}, Name = {1}, Address = {2}", emp.No, emp.Name, emp.Address);
            //}
            #endregion

            #region LINQ with partial selection

            //var result = from emp in emps
            //             where emp.Address.ToLower().Contains(filter.ToLower())
            //             select emp.Name;


            //foreach (var name in result)
            //{
            //    Console.WriteLine(name);
            //}
            #endregion

            #region LINQ with Anonymous Type Array as Result
            //var result = from emp in emps
            //             where emp.Address.ToLower().Contains(filter.ToLower())
            //             select new FilteredEmp() { EName = emp.Name, EAddress = emp.Address };


            //foreach (var fe in result)
            //{
            //    Console.WriteLine(fe.EName + fe.EAddress);
            //}

            //var result = (from emp in emps
            //              where emp.Address.ToLower().Contains(filter.ToLower())
            //              select new { EName = emp.Name, EAddress = emp.Address }).ToList();


            //foreach (var fe in result)
            //{
            //    Console.WriteLine(fe.EName + fe.EAddress);
            //} 
            #endregion

            #region understand that where is a method
            //var result = (from emp in emps
            //              where emp.Address.ToLower().Contains(filter.ToLower())
            //              select new { EName = emp.Name, EAddress = emp.Address }).ToList();

            //Console.WriteLine("Result after first Filter");
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.EName);
            //}

            //var filteredAnonymousCollection = result.Where((a) =>
            //                                                    {
            //                                                        return a.EAddress.Contains("g");
            //                                                    });
            //Console.WriteLine("Result after Second Filter");
            //foreach (var item in filteredAnonymousCollection)
            //{
            //    Console.WriteLine(item.EName);
            //}
            #endregion

            #region LINQ Advanced
            //var result = (from emp in emps
            //              where emp.Address.ToLower().Contains(filter.ToLower())
            //              select new
            //              {
            //                  EName = emp.Name,
            //                  EAddress = emp.Address
            //              }).Where((a) =>
            //              {
            //                  return a.EAddress.Contains(filter2);
            //              }); ;


            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.EName + item.EAddress);
            //}
            #endregion

            #region Expression Tree
            ////Create a tree 
            //Expression<Func<int, bool>> tree = (i)=> (i > 10);

            ////Compile a tree 
            //Func<int, bool> pointer = tree.Compile();

            //Stopwatch watch = new Stopwatch();

            //watch.Start();
            ////bool result = Check(20);
            ////Execute a tree
            //bool result = pointer(20);
            //bool result1 = pointer(20);
            //bool result2 = pointer(20);
            //bool result3 = pointer(20);
            //bool result4 = pointer(20);
            //watch.Stop();

            //Console.WriteLine(result);
            //Console.WriteLine("Time taken for Execution {0}", watch.ElapsedTicks);
            //Console.ReadLine();
            #endregion

            #region Use Partial Method
            //// Test t = new Test();

            //Student s = new Student();
            //s.Name = "mahesh";

            #endregion

            #region Dynamic
            //Console.WriteLine("Enter Choice");
            //int choice = Convert.ToInt32(Console.ReadLine());
            //Factory factory = new Factory();

            //dynamic obj = factory.GetMeSomeObject(choice);

            //Console.WriteLine(obj.GetDetails());
            #endregion

            Emp emp = new Emp();
            emp.Print(111,address:"Mumbai", name:"abc");

        }


        //public static bool Check(int i)
        //{
        //    return (i > 10);
        //}

        #region Filter Function code to understand Where Function in LINQ
        ////Where is written like Filter 
        //public static IEnumerable<Anonymous>  Filter(this List<Anonymous> lst, Func<Anonymous,bool> pointer)
        //{
        //    var filteredCollection = new List<Anonymous>();

        //    foreach (Anonymous a in lst)
        //    {
        //        //Some Logic to filter a's value
        //        //If condition matches we will add 'a' in collection
        //        //this collection needs to be returned from here
        //       bool shallWeAdd =  pointer(a);

        //        if (shallWeAdd==true)
        //        {
        //            filteredCollection.Add(a);
        //        }
        //    }
        //    return filteredCollection;
        //}
        #endregion

        //Below code will result in err
        //public var SomeFn()
        //{
        //    return 100;
        //}

        //public static bool Check(int i )
        //{
        //    return (i > 10);
        //}

    }

    public class Factory
    {
        public object GetMeSomeObject(int choice)
        {
            if (choice == 0)
            {
                return new Emp();
            }
            else
            {
                return new Student();
            }
        }
    }

    #region Used in Extension Method
    public static class MyExtension
    {
        public static bool CheckForValidEMailAddress(this string str, int a)
        {
            return true;
        }
    }
    public sealed class SomeClass
    {
        public void SomeMethod()
        {
            Console.WriteLine("Some code");
        }
    }
    public static class ABC
    {
        public static void SomeOtherMethod<T>(this T s, int i)
        {
            Console.WriteLine("Some Other code");
        }
    }

    //public static class ABC
    //{
    //    public static void SomeOtherMethod(this SomeClass s, int i)
    //    {
    //        Console.WriteLine("Some Other code");
    //    }
    //}

    #endregion

    #region Used in Iterator
    public class Week : IEnumerable
    {
        private string[] days = new string[] { "Mon", "Tue", "Wed", "Thur", "Fri", "Sat", "Sun" };

        public string this[int i]
        {
            get { return days[i]; }
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < days.Length; i++)
            {
                yield return days[i];
            }
        }
    }
    #endregion

    #region Used in Partial Class Concept
    public partial class Maths
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
    }
    #endregion

    public class Anonymous
    {

    }

    //public class FilteredEmp
    //{
    //    public string EName { get; set; }
    //    public string EAddress { get; set; }
    //}

    public class Emp
    {
        #region Auto Property
        public int No { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        #endregion

        public Emp()
        {
            No = 1;
            Name = "ABC";
            Address = "Pune";
        }
        public string GetDetails()
        {
            return string.Format("No = {0}, Name = {1}, Address = {2}",this.No, this.Name,this.Address);
        }

        public void Print(int no, string name="Mahesh", string address="Pune")
        {
            Console.WriteLine("No = {0}, Name = {1}, Address={2}",no, name,address);
        }
    }

    //Programmer A
    public partial class Student
    {
      
    }
}
