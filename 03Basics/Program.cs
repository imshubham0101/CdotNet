using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Understanding Basic Getter Setter Like C++


            //Emp e1 = new Emp();

            //Console.WriteLine("Enter Name");
            //string name = Console.ReadLine();
            //e1.Set_Name(name);
            //string result = e1.Get_Name();
            //Console.WriteLine(result);
            //Console.ReadLine();

            #endregion

            #region Getter Setter Function Usage
            //Emp e1 = new Emp();

            //Console.WriteLine("Enter No");
            //e1.Set_No(Convert.ToInt32(Console.ReadLine()));

            //Console.WriteLine("Enter Name");
            //e1.Set_Name(Console.ReadLine());

            //string details = e1.GetDetails();
            //Console.WriteLine(details);
            //Console.ReadLine(); 
            #endregion

            #region Use Properties
            //Emp e1 = new Emp();

            //Console.WriteLine("Enter No");
            //e1.No=Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter Name");
            //e1.Name =Console.ReadLine();

            //string details = e1.GetDetails();
            //Console.WriteLine(details);
            //Console.ReadLine(); 
            #endregion

            #region Using Special Emp
                SpecialEmp se = new SpecialEmp();
                se.No = 1;
                se.Name = "abc";
                se.Salary = 10000;
                Console.WriteLine(se.GetDetails());
                Console.ReadLine();
            #endregion
        }
    }

    #region Emp Class in C++ Way
    //public class Emp
    //{
    //    private int _No;
    //    private string _Name;

    //    public void Set_Name(string name)
    //    {
    //        this._Name = name;
    //    }
    //    public string Get_Name()
    //    {
    //        return "Mr / Mrs " + this._Name ;
    //    }

    //    public void Set_No(int no)
    //    {
    //       this._No = no;
    //    }
    //    public int Get_No()
    //    {
    //        return this._No;
    //    }

    //    public string GetDetails()
    //    {
    //        return this.Get_No().ToString() + this.Get_Name();
    //    }


    //} 
    #endregion

    public class Emp
    {
        private int _No;
        private string _Name;
        private string _Address;

        public string Address
        {
            get { return _Address; }
            set { _Address = value; }
        }

        public string Name
        {
            get { return "Mr / Mrs " + _Name; }
            set { _Name = value; }
        }

        public int No
        {
            get { return _No; }
            set { _No = value; }
        }

        public virtual string GetDetails()
        {
            return this.No + this.Name;
        }

    }

    public class SpecialEmp:Emp
    {
        private int _Salary;

        public int Salary
        {
            get { return _Salary; }
            set { _Salary = value; }
        }

        public override string GetDetails()
        {
            return base.GetDetails() + this.Salary;
        }


    }

}
