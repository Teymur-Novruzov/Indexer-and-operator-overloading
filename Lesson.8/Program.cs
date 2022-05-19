using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;



//namespace Lesson_8
//{
//    class Base
//    {
//        public string[][] Arr { get; set; }
//        public string this[int index1, int index2]
//        {
//            get => Arr[index1][index2];
//            set => Arr[index1][index2] = value;


//        }

//    }
//    class Proses
//    {
//        public void Informations()
//        {
//            Console.Title = "Translate Task";
//            Console.BackgroundColor = ConsoleColor.Gray;
//            Console.ForegroundColor = ConsoleColor.Black;
//            Console.WindowHeight = 22;
//            Console.WindowWidth = 90;
//        }
//        public Base Ready_words()
//        {
//            Base base_ = new Base();
//            base_.Arr = new string[][]
//            {
//                new string[2]{"Salam","Hello"},
//                new string[2]{"qirmizi","red"},
//                new string[2]{"Sari","yellow"},
//                new string[2]{"boz","grey"},
//                new string[2]{"yasil","green"},
//                new string[2]{"ag","white"},
//                new string[2]{"qara","black"},
//                new string[2]{"goy","blue"},
//                new string[2]{"qiz","girl"},
//                new string[2]{"oglan","boy"},
//                new string[2]{"kisi","man"},
//                new string[2]{"qadin","woman"},
//                new string[2]{"qadinlar","women"},
//                new string[2]{"kisiler","men"},
//                new string[2]{"sican","mouse"},
//                new string[2]{"child","usaq"},
//                new string[2]{"baby","korpe"},
//                new string[2]{"Ana","Mother"},
//                new string[2]{"Ata","Father"},
//                new string[2]{"qardas","brother"},
//                new string[2]{"baci","sister"},
//                new string[2]{"utanmaq","shy"},
//                new string[2]{"getmek","go"},
//                new string[2]{"od","fire"},
//                new string[2]{"odun","wood"},
//                new string[2]{"su","water"},
//                new string[2]{"hava","air"},
//                new string[2]{"gul","flower"},
//                new string[2]{"aglamaq","cry"},
//                new string[2]{"mese","forest"},
//                new string[2]{"sevmek","love"},
//                new string[2]{"beyenmek","like"},
//                new string[2]{"opmek","kiss"},
//                new string[2]{"ucmaq","fly"},
//                new string[2]{"vaxt","time"},
//                new string[2]{"dil","language"},
//                new string[2]{"reng","color"},
//                new string[2]{"yas","age"},
//                new string[2]{"ad","name"},
//            };
//            var jsonString = JsonConvert.SerializeObject(base_);
//            File.WriteAllText("base.json", jsonString);
//            var text = File.ReadAllText("base.json");
//            Base readtest = JsonConvert.DeserializeObject<Base>(text);

//            return readtest;

//        }
//        public void First_page(string first_word, string second_word)
//        {
//            Console.Clear();
//            Console.WriteLine($@"          ------------------------------          ------------------------------          ");
//            Console.WriteLine("         |                              |        |                              |       ");
//            Console.WriteLine($@"                {first_word}                                      {second_word}                                  ");
//            Console.WriteLine("         |                              |        |                              |       ");
//            Console.WriteLine($@"          ------------------------------          ------------------------------          ");

//        }
//        public string Second_step()
//        {
//            Console.WriteLine();
//            Console.WriteLine();
//            Console.Write($@"         Enter Word : ");
//            string first_word = Console.ReadLine();

//            return first_word;
//        }
//        public void Again_funk(Base base_)
//        {
//            Console.WriteLine();
//            Console.WriteLine();
//            Console.WriteLine("  Again [0]                  ");
//            Console.WriteLine();
//            Console.Write("  Enter : ");
//            string again_choice = Console.ReadLine();

//            if (again_choice == "0")
//            {
//                Work(base_);
//            }
//            else
//            {
//                Wront_choice();
//                Work(base_);
//            }
//        }
//        public void Wront_choice()
//        {
//            Console.WriteLine();
//            Console.WriteLine();
//            for (int i = 0; i < 3; i++)
//            {
//                Console.Clear();
//                Thread.Sleep(500);
//                Console.ForegroundColor = ConsoleColor.Red;
//                Console.WriteLine($@"                     

//                                           WRONG   ");
//                Thread.Sleep(1000);
//            }

//            Console.ForegroundColor = ConsoleColor.Black;
//        }
//        public void Work(Base base_)
//        {

//            First_page("", "");

//            string word_1 = Second_step();


//            for (int i = 0; i < base_.Arr.Length; i++)
//            {
//                for (int k = 0; k < 2; k++)
//                {
//                    if (base_[i, k] == word_1)
//                    {
//                        if (k == 0)
//                        {
//                            First_page(word_1, base_[i, k + 1]);
//                            Again_funk(base_);
//                        }
//                        else if (k == 1)
//                        {
//                            First_page(word_1, base_[i, k - 1]);
//                            Again_funk(base_);
//                        }
//                    }
//                }

//            }
//            Wront_choice();
//            Work(base_);

//        }
//    }
//    class Program
//    {
//        static void Start()
//        {
//            Proses proses = new Proses();
//            proses.Informations();
//            proses.Work(proses.Ready_words());
//        }
//        static void Main(string[] args)
//        {
//            Start();
//        }
//    }
//}





//Task 2



namespace task_2
{
    class Capital
    {
        public int Popilation_city { get; set; }
        public string Name { get; set; }

        public Capital(int pop, string name)
        {
            this.Popilation_city = pop;
            this.Name = name;
        }
    }
    class Location
    {
        public string location_country { get; set; }

        public Location(string location)
        {
            this.location_country = location;
        }
    }
    class Country
    {
        public Capital Capital_country { get; set; }
        public Location Location_country { get; set; }
        public int Popilation { get; set; }
        public string Name { get; set; }

        public Country(Capital capital, Location location, int pop, string name)
        {
            this.Capital_country = capital;
            this.Location_country = location;
            this.Popilation = pop;
            this.Name = name;
        }

        public static bool operator >(Country a,Country b)
        {
            if (a.Popilation > b.Popilation)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator <(Country a,Country b)
        {
            if (a.Popilation < b.Popilation)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator >=(Country a, Country b)
        {
            if (a.Popilation >= b.Popilation)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator <=(Country a, Country b)
        {
            if (a.Popilation <= b.Popilation)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



    }
    class Program
    {
        static Country[] Base()
        {

            Country[] countries = new Country[3];

            Capital capital1 = new Capital(6000000, "Baku");
            Location location1 = new Location("40.401891, 49.864316");
            Country country1 = new Country(capital1, location1, 11000000, "Azerbaijan");

            Capital capital2 = new Capital(15840900, "Istanbul");
            Location location2 = new Location("41.008433, 28.980313");
            Country country2 = new Country(capital2, location2, 84000000, "Turkey");

            Capital capital3 = new Capital(13000000, "Moscow");
            Location location3 = new Location("55.714809, 37.487057");
            Country country3 = new Country(capital3, location3, 145000000, "Russia");

            countries[0] = country1;
            countries[1] = country2;
            countries[2] = country3;

            return countries;

        }
        static void First_page(Country[] countrys)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($@"     AZE [1]      TUR [2]      Rus[3]    ");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("   Enter first country : ");
            string first_choice_str = Console.ReadLine();
            Console.WriteLine();
            Console.Write("   Enter second country : ");
            string second_choice_str = Console.ReadLine();
            Second_page(countrys,first_choice_str,second_choice_str);

        }
        static void Check_words(Country[] countrys, string first, string second,int num)
        {
            if(first=="1"||first=="2"||first=="3"&& second == "1" || second == "2" || second == "3")
            {
                int first_int = int.Parse(first);
                int second_int = int.Parse(second);
                if (first_int == 1)
                {
                    Third_page(countrys, first_int, second_int, num);
                }
                else if (first_int == 2)
                {
                    Third_page(countrys, first_int, second_int, num);
                }
                else if (first_int == 3)
                {
                    Third_page(countrys, first_int, second_int, num);
                }
                else if (first_int == 4)
                {
                    Third_page(countrys, first_int, second_int, num);
                }
                else
                {
                    Wront_choice();
                    Second_page(countrys, first, second);
                }
            }
            else
            {
                Wront_choice();
                First_page(countrys);
            }
        }
        static void Third_page(Country[] countrys,int first,int second,int choice_num)
        {
            bool choice;
            if (choice_num == 1)
            {
               choice = countrys[first - 1] > countrys[second - 1];
            }
            else if (choice_num == 2)
            {
                choice = countrys[first - 1] < countrys[second - 1];
            }
            else if (choice_num == 3)
            {
                choice = countrys[first - 1] >= countrys[second - 1];
            }
            else if (choice_num == 4)
            {
                choice = countrys[first - 1] <= countrys[second - 1];
            }
            else
            {
                choice = false;
            }

            if (choice == true)
            {
                True_choice();
                First_page(countrys);
            }
            else if (choice == false)
            {
                Wront_choice();
                First_page(countrys);
            }
            
        }
        static void Second_page(Country[] countrys,string first,string second)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("   Choice :   > [1]   or   < [2]   or   >= [3]   or   <= [4] ");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("   Enter : ");
            string second_pages_choice = Console.ReadLine();
            bool choice;
            if (second_pages_choice == "1")
            {
               Check_words(countrys, first, second, 1);
            }
            else if (second_pages_choice == "2")
            {
                Check_words(countrys, first, second, 2);
            }
             else if (second_pages_choice == "3")
            {
                Check_words(countrys, first, second, 3);
            }
             else if (second_pages_choice == "4")
            {
                Check_words(countrys, first, second, 4);
            }
            else
            {
                Wront_choice();
                Second_page(countrys,first,second);
            }

        }
        static void Fight(string first,string second)
        {
            int first_int = int.Parse(first);
            int second_int = int.Parse(second);

        }
        static void Informations()
        {
            Console.Title = "Countrys Task";
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WindowHeight = 22;
            Console.WindowWidth = 90;
        }
        public static void Wront_choice()
        {
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < 3; i++)
            {
                Console.Clear();
                Thread.Sleep(500);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($@"                     

                                                   WRONG   ");
                Thread.Sleep(1000);
            }

            Console.ForegroundColor = ConsoleColor.Black;
        }
        public static void True_choice()
        {
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < 2; i++)
            {
                Console.Clear();
                Thread.Sleep(500);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($@"                     

                                                   True   ");
                Thread.Sleep(1000);
            }

            Console.ForegroundColor = ConsoleColor.Black;
        }
        static void Start()
        {
            Informations();
            Country[] countrys = Base();
            First_page(countrys);

        }
        static void Main()
        {
            Start();
        }
    }
}
