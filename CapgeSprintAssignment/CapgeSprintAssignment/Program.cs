using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Task1
{
    class student
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string smailid { get; set; }
        public string branch { get; set; }
        public double per { get; set; }
    }


    class Program
    {
        static void Main(string[] args)
        {
            List<student> slist = new List<student>()
            {
                new student(){firstname ="Pradeep", lastname="Mahur", branch= "comp", smailid = "pradip@gmail.com", per = 84 },
                new student(){firstname ="Sandeep", lastname="Potdhuke", branch= "comp", smailid = "sandip@gmail.com", per = 89},
                new student(){firstname ="Randeep", lastname="Aahur", branch= "elec", smailid = "randip@gmail.com", per = 91},
                new student(){firstname ="Mandeep", lastname="Mahur1", branch= "mech", smailid = "mandip@gmail.com", per = 80 },
                new student(){firstname ="Gagandeep", lastname="Mahur2", branch= "comp", smailid = "gagandip@gmail.com", per = 67 },
                new student(){firstname ="Akashdeep", lastname="Mahur3", branch= "civil", smailid = "akashdip@gmail.com", per = 74 },
                new student(){firstname ="Amardeep", lastname="Mahur4", branch= "elec", smailid = "amardip@gmail.com", per = 61 },
                new student(){firstname ="Deep", lastname="Mahur5", branch= "comp", smailid = "dip@gmail.com", per = 96 },
            };

            //1.select,where,take,takewhile,skip,skipwhile

            Console.WriteLine("TASK1");
            //1.Select

            Console.WriteLine("select query \n");
            //var query = from i in slist select i;
            var query = slist.Select(i => i);
            foreach (var i in query)
            {
                Console.WriteLine(i.firstname + "," + i.lastname + "," + i.branch + "," + i.smailid + "," + i.per);
            }

            Console.WriteLine("-------------------------------------------- \n");
            //2.Where
            Console.WriteLine("where query \n");
            //var query1 = from i in slist where i.firstname == "Pradeep" select i;
            var query1 = slist.Where(i => i.firstname == "Pradeep").Select(i => i);
            foreach (var i in query1)
            {
                Console.WriteLine(i.firstname + "," + i.lastname + "," + i.branch + "," + i.smailid + "," + i.per);
            }

            Console.WriteLine("-------------------------------------------- \n");
            //3.Take
            Console.WriteLine("take query \n");
            //var query2 = (from i in slist select i).Take(2);
            var query2 = slist.Take(2);
            foreach (var i in query2)
            {
                Console.WriteLine(i.firstname + "," + i.lastname + "," + i.branch + "," + i.smailid + "," + i.per);
            }

            Console.WriteLine("-------------------------------------------- \n");
            //4.Takewhile
            Console.WriteLine("takewhile query \n");
            var query3 = slist.TakeWhile(i => i.firstname == "Pradeep");
            foreach (var i in query3)
            {
                Console.WriteLine(i.firstname + "," + i.lastname + "," + i.branch + "," + i.smailid + "," + i.per);
            }

            Console.WriteLine("-------------------------------------------- \n");
            //5. Skip
            Console.WriteLine("skip query \n");
            //var query4 = (from i in slist select i).Skip(6);
            var query4 = slist.Skip(6);
            foreach (var i in query4)
            {
                Console.WriteLine(i.firstname + "," + i.lastname + "," + i.branch + "," + i.smailid + "," + i.per);
            }

            Console.WriteLine("-------------------------------------------- \n");
            //6. Skipwhile
            Console.WriteLine("skipwhile query \n");
            var query5 = slist.SkipWhile(i => i.branch == "comp");
            foreach (var i in query5)
            {
                Console.WriteLine(i.firstname + "," + i.lastname + "," + i.branch + "," + i.smailid + "," + i.per);
            }

            Console.WriteLine("\n--------------------------------------------");
            Console.WriteLine("-------------------------------------------- \n");



            //2.order by asc and desc,group by
            Console.WriteLine("Order by Ascending");
            var query6 = from i in slist where i.per < 80 orderby i.per select i;
            foreach (var i in query6)
            {
                Console.WriteLine(i.firstname + "," + i.lastname + "," + i.branch + "," + i.smailid + "," + i.per);
            }

            Console.WriteLine("-------------------------------------------- \n");

            Console.WriteLine("Order by Descending");
            var query7 = from i in slist where i.per < 80 orderby i.per descending select i;
            foreach (var i in query7)
            {
                Console.WriteLine(i.firstname + "," + i.lastname + "," + i.branch + "," + i.smailid + "," + i.per);
            }

            Console.WriteLine("-------------------------------------------- \n");



            Console.WriteLine("Group By \n");
            var query8 = slist.GroupBy(i => i.branch);

            foreach (var i in query8)
            {
                Console.WriteLine(i.Key);
            }

            Console.WriteLine("\n--------------------------------------------");
            Console.WriteLine("-------------------------------------------- \n");


            //3.selectmany
            /*Console.WriteLine("selectmany query \n");
            //var query = from i in slist select i;
            var query9 = slist.SelectMany(i => i.branch);
            foreach (var i in query9)
            {
                Console.WriteLine(i);
            }*/

            List<List<int>> array = new List<List<int>>();
            List<int> array1 = new List<int> { 10,20,30 };
            array.Add(array1);
            Console.WriteLine("\nSelectMany query");
            var query9 = array.SelectMany(i => i);
            foreach (var i in query9)
            {
                Console.WriteLine(i);
            }


            Console.WriteLine("\n--------------------------------------------");
            Console.WriteLine("-------------------------------------------- \n");


            //4.Aggregate functions->sum,max,min,avg,count,distinct

            //Console.WriteLine("Sum");
            double sum = (from i in slist select i.per).Sum();
            Console.WriteLine("Sum: " + sum);

            //Console.WriteLine("Max");
            double max = (from i in slist select i.per).Max();
            Console.WriteLine("Maximum: " + max);

            //Console.WriteLine("Min");
            double min = (from i in slist select i.per).Min();
            Console.WriteLine("Minimum: " + min);

            //Console.WriteLine("Average");
            double avg = (from i in slist select i.per).Average();
            Console.WriteLine("Average: " + avg);

            //Console.WriteLine("Count");
            var query10 = (from i in slist select i).Count();
            Console.WriteLine("Count: " + query10);

            Console.WriteLine("Distinct");
            var query11 = (from i in slist select i.branch).Distinct();
            foreach (string i in query11)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\n--------------------------------------------");
            Console.WriteLine("-------------------------------------------- \n");

            //5.let,into,oftype<int/string>
            Console.WriteLine("let");
            List<int> arr = new List<int>() { 50, 60, 70 };
            var query12 = from i in arr let res = i + 10 where res > 60 select res;
            foreach (int i in query12)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("-------------------------------------------- \n");

            Console.WriteLine("Into");
            var query13 = from i in slist where i.branch == "comp" select i into res where res.firstname.Contains("deep") select res;
            foreach (var i in query13)
            {
                Console.WriteLine(i.firstname + "," + i.branch);
            }

            Console.WriteLine("-------------------------------------------- \n");

            Console.WriteLine("OfType");
            object[] arr1 = new object[] { 4, "X", 3, "Y", 2, "Z", 1, "ABC" };
            var query14 = (from i in arr1 select i).OfType<string>();
            foreach (var i in query14)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\n--------------------------------------------");
            Console.WriteLine("-------------------------------------------- \n");

            //6.first,firstordefault,last,lastdefault,single,singleordefault,elementat,elementatordefault.
            Console.WriteLine("First and FirstOrDefault");
            var query15 = (from i in slist where i.branch == "comp" select i.per).First();
            var query16 = (from i in slist where i.branch == "x" select i.per).FirstOrDefault();
            Console.WriteLine(query15);
            Console.WriteLine(query16);
            Console.WriteLine("-------------------------------------------- \n");

            Console.WriteLine("Last and LastOrDefault");
            var query17 = (from i in slist where i.branch == "comp" select i.per).Last();
            var query18 = (from i in slist where i.branch == "comp" select i.per).LastOrDefault();
            Console.WriteLine(query17);
            Console.WriteLine(query18);

            Console.WriteLine("-------------------------------------------- \n");

            Console.WriteLine("Single and SingleOrDefault");
            var query19 = (from i in slist where i.per == 84 select i).Single();
            var query20 = (from i in slist where i.per == 9 select i).SingleOrDefault();
            Console.WriteLine(query19.firstname);
            Console.WriteLine(query20);


            Console.WriteLine("-------------------------------------------- \n");

            Console.WriteLine("Elementat and ElementatOrDefault");
            var query21 = (from i in slist select i).ElementAt(1);
            var query22 = (from i in slist select i).ElementAtOrDefault(15);
            Console.WriteLine(query21.firstname);
            Console.WriteLine(query22);

            Console.WriteLine("\n--------------------------------------------");
            Console.WriteLine("-------------------------------------------- \n");

            //7.Immediate execution and deffered execution.

            var query23 = (from i in slist select i).Count();

            var query24 = (from i in slist select i);

            slist.Add(new student() { firstname = "Radeep", lastname = "Mahur6", branch = "comp", smailid = "pradip@gmail.com", per = 88 });
            slist.Add(new student() { firstname = "Adeep", lastname = "Mahur7", branch = "mech", smailid = "pradip@gmail.com", per = 87 });

            Console.WriteLine("Immediate Execution");
            Console.WriteLine(query23);

            Console.WriteLine("-------------------------------------------- \n");

            Console.WriteLine("Deffered Execution");
            foreach (var i in query24)
            {
                Console.WriteLine(i.firstname + " " + i.per);
            }

            Console.WriteLine("\n--------------------------------------------");
            Console.WriteLine("-------------------------------------------- \n");


            //8.display names startswith,endswith,contains

            Console.WriteLine("Startswith");
            var query25 = (from i in slist where i.firstname.StartsWith('M') select i);
            foreach (var i in query25)
            {
                Console.WriteLine(i.firstname);
            }

            Console.WriteLine("-------------------------------------------- \n");

            Console.WriteLine("Endsswith");
            var query26 = (from i in slist where i.branch.EndsWith('c') select i);
            foreach (var i in query26)
            {
                Console.WriteLine(i.firstname);
            }

            Console.WriteLine("-------------------------------------------- \n");

            Console.WriteLine("Contains");
            var query27 = (from i in slist where i.firstname.Contains("Deep") select i);
            foreach (var i in query27)
            {
                Console.WriteLine(i.firstname + " " + i.lastname);
            }

            Console.WriteLine("\n--------------------------------------------");
            Console.WriteLine("-------------------------------------------- \n");

            //9.Ienumerable,Iqueryable
            Console.WriteLine("IEnumerable");

            IEnumerable<string> query28 = slist.Select(i => i.firstname);
            foreach (var i in query28)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("-------------------------------------------- \n");

            Console.WriteLine("Iqueryable");
            IQueryable<student> query29 = (from i in slist select i).AsQueryable();


            foreach (var i in query)
            {
                Console.WriteLine(i.firstname);
            }

            Console.WriteLine("\n--------------------------------------------");
            Console.WriteLine("-------------------------------------------- \n");


        }
    }
}
