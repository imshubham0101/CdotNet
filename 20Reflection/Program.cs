using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace _20Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            // string dllPath = @"D:\Demos\AllDemos\02MathsLib\bin\Debug\02MathsLib.dll";
            Console.WriteLine("Enter Path of any .NET Assembly to see the details");
            string dllPath = Console.ReadLine();
            Assembly assembly = Assembly.LoadFrom(dllPath);
            Type[] types = assembly.GetTypes();
            object dynamicObjectOfSomeType = null;

            foreach (Type type in types)
            {
                dynamicObjectOfSomeType =
                    assembly.CreateInstance(type.FullName);
                Console.WriteLine("Created object of " + type.Name);
                //Console.WriteLine(type.Name);

                MethodInfo[] methods = //type.GetMethods();
                    type.GetMethods(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public);
               // Console.WriteLine(" | ");
              //  Console.WriteLine();


                foreach (MethodInfo method in methods)
                {
                    // Console.Write(" -----    " + method.ReturnType.ToString() + "  " + method.Name + " ( ");
                    Console.WriteLine("Calling " + method.Name);

                  
                    ParameterInfo[] allparams = method.GetParameters();
                    object[] argumentArray = new object[allparams.Length];
                   
                    for (int i = 0; i < allparams.Length; i++)
                    {
                        Console.WriteLine("Please enter value for " + allparams[i].Name + " of type " + allparams[i].ParameterType);
                        argumentArray[i] = 
                            Convert.ChangeType(Console.ReadLine(), 
                                                allparams[i].ParameterType);
                        //Console.Write(param.ParameterType + "  " + param.Name + "  ");
                    }

                    object result = type.InvokeMember(
                                     method.Name,
                                     BindingFlags.InvokeMethod |
                                     BindingFlags.Instance |
                                     BindingFlags.Public,
                                     null,
                                     dynamicObjectOfSomeType,
                                     argumentArray);
                    Console.WriteLine(result);
                    //Console.Write(" ) ");
                    Console.WriteLine();
                }
            }
        }
    }
}
