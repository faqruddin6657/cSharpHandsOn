using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqHandsOn
{
    internal class LinqDemo 
    {
        public string foundcity;
        public void findPositive()
        {
            int[] arr = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            var result = from int a in arr
                         where a>0
                         select a;

            foreach(int i in result)
            {
                Console.Write(i + " ,");
            }

                
                
             
        }

        public void frequencyOfNum()
        {
            int count = 0;
           int[] arr1={ 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };
            var result = from int a in arr1
                         group a by a into finalgroup
                         select finalgroup;
            Console.WriteLine("the numbers in the array are:");
            foreach(int i in arr1)
            {
                Console.Write(i + " ,");
            }

            Console.WriteLine("the number and the frequencies are:");

            foreach (var arr2 in result)
            {
            //  Console.Write("number" + arr2 + "appears");
                foreach(int i in arr2)
                {
                    ++count;
                    if(count == 1)
                    {
                        Console.Write("number " + i + " appears");
                    }
                }
                Console.Write("  " + count + " times" + "\n");
                count = 0;
            }

        }

        public void frequencyOfCharinStr()
        {
            int count = 0;
            Console.WriteLine("enter any string");
            string str= Console.ReadLine();
            var result = from char c in str
                         group c by c into finalgroup
                         select finalgroup;
            Console.WriteLine("the frequencies of the characters are");
            foreach(var subgrp in result)
            {
                foreach(char c2 in subgrp)
                {
                    ++count;
                    if (count == 1)
                    {
                        Console.Write("character  " + c2 + " : ");
                    }
                }
                Console.Write(count + " times" + "\n");
                count = 0;
            }

        }

        public void findingStrWithStrtAndEdChar()
        {
            
            int index = -1;
            string[] cities = { "ROME", "LONDON", "NAIROGI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };
            var result = from city in cities
                         select city;

            Console.WriteLine("the cities are :");
            foreach( var city in cities)
            {
                Console.Write(city + "  ,");
            }
            Console.WriteLine("\n input starting character of the string");
            char start =Convert.ToChar(Console.ReadLine());

            Console.WriteLine("input ending character of the string");
            char end =Convert.ToChar(Console.ReadLine());

            

            foreach(string city in result)
            {
                ++index;
                for(int i=0; i<cities.Length; i++)
                {
                    if (city[0].Equals(start) && city[city.Length-1].Equals(end))   
                    {
                        foundcity = city;
                    }
                }
            }
            if (index > -1)
            {
                Console.WriteLine("the city starting with " + start + " and ending with " + end + " is " + foundcity);
            }
            else
            {
                Console.WriteLine("no such city found");
            }


        }
        public void nRecords()
        {
            Console.WriteLine("the members of the list are ");
            List<int> list = new List<int> { 5, 7, 13, 24, 6, 9, 8, 7 };
            foreach(int i in list)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("how many records you want to display");
            int n = Convert.ToInt32(Console.ReadLine());

            var result =(from int a in list
                         select a).Take(n);
            Console.WriteLine("the top " + n + " records from the list are:");

            foreach(int i in result)
            {
                Console.WriteLine(i);
            }




 
        }

        public void maxGrade()
        {
            int itr=0;
            List<Student> li = new List<Student>
            {
                new Student{studentid=101, name = "faqruddin",gradepoints=950 },
            new Student { studentid = 102, name = "shaikhazh", gradepoints = 450 },
            new Student { studentid = 103, name = "rasoolsbb", gradepoints = 780 },
            new Student { studentid = 104, name = "ghousesss", gradepoints = 779 },
            new Student { studentid = 105, name = "shahzabdn", gradepoints = 880 },
            new Student { studentid = 105, name = "shahzabdn", gradepoints = 880 }
            };
            Console.WriteLine("which maximum grade point( 1st, 2nd, 3rd,...) you want to find ");
            int rank = Convert.ToInt32(Console.ReadLine());

            var result = (from a in li
                          orderby a.gradepoints descending
                          group a by a.gradepoints into sameranks

                          select sameranks).Take(rank) ;

            Console.WriteLine(result.Count());

            foreach(var stu in result)
            {
                itr++;
                if(itr==result.Count())
                {
                    foreach (var rec in stu)
                    {
                        Console.WriteLine("id : " + rec.studentid + " , name : " + rec.name + " ,achieved gradepoint : " + rec.gradepoints);
                    }
                }
               
            }


        }

        public void findingLastNameWithChar()
        {
            List<People> l2 = new List<People>() {
            new People{firstname= "Bill" ,lastname="Smith",age=41},
            new People{firstname= "Sarah" ,lastname="Jones",age=22},
            new People{firstname= "Stacy" ,lastname="Baker",age=21},
            new People{firstname= "Vivianne" ,lastname="Dexter",age=19},
            new People{firstname= "Bob" ,lastname="Smith",age=49},
            new People{firstname= "Brett" ,lastname="Baker",age=51},
            new People{firstname= "Mark" ,lastname="Parkar",age=19},
            new People{firstname= "Alice" ,lastname="Thompson",age=18},
            new People{firstname= "Evelyn" ,lastname="Thompson",age=58},
            new People{firstname= "Mort" ,lastname="Martin",age=58},
            new People{firstname= "Eugene" ,lastname="Delauter",age=84},
            new People{firstname= "Gail" ,lastname="Dawson",age=19}

            };

            var result = from person in l2
                         where person.lastname.StartsWith("D")
                         select person;

            foreach(var person in result)
            {
                Console.WriteLine(person.lastname);
            }

            Console.WriteLine("the number of people whose name starts with D letter: " + result.Count());

          

        }

        public void questionNine()
        {
            List<People> l2 = new List<People>() {
            new People{firstname= "Bill" ,lastname="Smith",age=41},
            new People{firstname= "Sarah" ,lastname="Jones",age=22},
            new People{firstname= "Stacy" ,lastname="Baker",age=21},
            new People{firstname= "Vivianne" ,lastname="Dexter",age=19},
            new People{firstname= "Bob" ,lastname="Smith",age=49},
            new People{firstname= "Brett" ,lastname="Baker",age=51},
            new People{firstname= "Mark" ,lastname="Parkar",age=19},
            new People{firstname= "Alice" ,lastname="Thompson",age=18},
            new People{firstname= "Evelyn" ,lastname="Thompson",age=58},
            new People{firstname= "Mort" ,lastname="Martin",age=58},
            new People{firstname= "Eugene" ,lastname="Delauter",age=84},
            new People{firstname= "Gail" ,lastname="Dawson",age=19}

            };
            var result2 = (from person in l2
                           where person.age > 40
                           orderby person.firstname ascending
                           select person);

            foreach (var person in result2)
            {
                Console.Write(person.firstname+" ,");

            }
        }

        public void  questionTen()
        {
            List<string> fruits = new List<string>()
            {
               "Lemon","Apple","Orrange","Lime","Watermelon","Loganberry"

            };
            
            var result = from fruit in fruits
                         where fruit.StartsWith("L")
                         select fruit;

            foreach(var rec in result)
            {
                Console.WriteLine(rec);
            }
            Console.WriteLine("there are : " + result.Count()+ " words in in the list that starts with L");
        }


        public void questionEleven()
        {
            List<int> mixedNumbers = new List<int>()
            {
                15,8,21,24,32,13,30,12,7,54,48,4,49,96

            };

            var result = from num in mixedNumbers
                         where (num%4==0 || num%6==0)
                         select num;

            Console.WriteLine("numbers multiples of 4 or 6");
            foreach(int num in result)
            {
                Console.Write(num + " ,");

            }

        }

    }
}
