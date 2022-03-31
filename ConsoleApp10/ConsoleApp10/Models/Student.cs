using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp10.Models
{
    class Student:Person
    {
        private int _iqRank;
        public int IqRank 
        {
            get 
            {
                return _iqRank;
            
            }
            set 
            {
                if (value <= 100)
                {
                    _iqRank = value;
                }
                else Console.WriteLine("100den kicik olmalidir");
            } 
        }
        private int _languageRank;
        public int LanguageRank
        {
            get
            {
                return _languageRank;

            }
            set
            {
                if (value <= 100)
                {
                    _languageRank = value;
                }
                else Console.WriteLine("100den boyuk ola bilmez");
            }
        }
        public void ExamResult()
        {
            if (Age < 20 && Age > 6)
            {
                if (LanguageRank + IqRank < 120)
                {
                    Console.WriteLine("Sinifde qaldin");
                }
                else Console.WriteLine("kecdin");
            }
           
            
        }
        public Student(string name,string surname,int age,int iqRank,int languageRank)
        {
            Name = name;
            Surname = surname;
            IqRank = iqRank;
            LanguageRank = languageRank;
            AGE = age;

        }

        public int AGE 
        {
            get 
            {
                return Age;
            }
            set 
            {
                if (value < 20 && value > 6)
                {
                    Age = value;
                }
                else Console.WriteLine("yas sohbeti");
            } 
        }

    }
}
