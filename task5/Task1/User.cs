using System;
using System.Text.RegularExpressions;
namespace task1
{
    partial class Program
    {
        public class User
        {
            private string name , secondname , Patronymic ;
            internal int Age;
            private DateTime Birthday;

            public string GetName
            {
                get
                {
                    return name;
                }
                set
                {
                    string pattern ="[A-Za-z]";
                    Regex regex = new Regex(pattern);
                    if (regex.IsMatch(pattern))
                        {
                        name = value;
                    }
                    else
                    {
                        throw new Exception("Вы ввели не правильное имя");
                    }
                }
            }
            public string Secondname
            {
                get
                {
                    return secondname;
                }
                set
                {
                   
                    secondname = value;
                }
            }
            public string GetPatronymic
            {
                get
                    
                {
                    return Patronymic;
                }
            }
            public int GetAge
            {
                get

                {
                    DateTime dateTime = DateTime.Now;
                    return dateTime.Year - Birthday.Year;
                }

                
            }
            public void checkTheExceptionWhichIhate(string value,string name )
            {
                string pattern = "[A-Za-z]";
                if (Regex.IsMatch(value, pattern))
                {
                    name = value;

                }
                else
                {
                    Console.WriteLine("Exception");
                }
                    
            }

            public DateTime GetBirthday
            {

                get
                {
                    return Birthday;

                }


                set
                {
                    DateTime dateTimeNow = DateTime.Now;
                    if ((dateTimeNow.Year - Birthday.Year) < 100) 
                    Birthday = value;
                
                    
                } 
            }

        }
    }
}