using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using _17MyAttributes;

namespace _16Reflection
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

            foreach (Type type in types)
            {
                List<Attribute> allAttributes =
                   type.GetCustomAttributes().ToList();

                bool isSerializable = false;
                foreach (Attribute attr in allAttributes)
                {
                    if (attr is SerializableAttribute)
                    {
                        isSerializable = true;
                        Console.WriteLine(type.Name + " is Serializable!");
                    }
                    if (attr is Table)
                    {
                        Table table = (Table)attr;
                        Console.WriteLine("Create table " + table.TableName + " () ");
                    }
                }

                if (isSerializable != true)
                {
                    Console.WriteLine(type.Name + " is not marked as Serializable!");
                }

                Console.WriteLine(type.Name);

                MethodInfo[] methods = //type.GetMethods();
                    type.GetMethods(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public);
                Console.WriteLine(" | ");
                Console.WriteLine();
                foreach (MethodInfo method in methods)
                {
                    Console.Write(" -----    "+ method.ReturnType.ToString() + "  " + method.Name +  " ( ");
                    ParameterInfo[] allparams = method.GetParameters();
                    foreach (ParameterInfo param in allparams)
                    {
                        Console.Write( param.ParameterType + "  "  + param.Name + "  ");
                    }

                    Console.Write(" ) ");
                    Console.WriteLine();
                }

            }

        }
    }
}
