using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaWeek4School
{
    public abstract class BaseKisi // her kişinin sahşp olduğu özelliği soyutluyorum
    {
        string _name;
        string _surname;
        public string name {get; set;    }
        public string surname { get; set;}

        public void Person(string name, string surname)
        {
            _name = name;
            _surname = surname;
            Console.WriteLine($"İsminiz {name} \n Soyisminiz {surname}");
        }
    
    }
    public class Student:BaseKisi
    {
        int _studentnum;
        public int studentnum {get; set;}
        public void Number(int studentnum)
        {
            _studentnum = studentnum;
            Console.WriteLine($"Okul numaranız {studentnum}");
        }
        
    }
    public class Teacher:BaseKisi //Sınıfı miras almak 
    {
        double _wage;
        public double wage {get; set;}
        public void TeacherWage(double wage )
        {
            _wage = wage;
            Console.WriteLine($"Maaşınız {wage}");
        }
    }
}
