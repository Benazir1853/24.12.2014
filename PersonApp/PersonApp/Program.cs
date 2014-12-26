using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Benazir", "Sultana", "Shimul");
            Person person2=new Person("Rakib","Hossain");
            Person person3 = new Person("Shamima");
            Person person4 =new Person();
           //string fullName=person1.GetFullName();
           // string reverseName=person1.GetReverseName();
            Console.WriteLine(person1.GetFullName() + "\n" + person1.GetReverseName());
            Console.WriteLine(person2.GetFullName() + "\n" + person2.GetReverseName());
            Console.WriteLine(person3.GetFullName() + "\n" + person3.GetReverseName());
            Console.WriteLine(person4.GetFullName() + "\n" + person4.GetReverseName());
            Console.Read();

        }
    }
}
