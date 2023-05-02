//Create a CRUD based App for developing a Movie Database software where the user can add, remove and update movies of his Video library.
//It should be a menu driven program that has 4 use cases for add, removing, finding and updating movie info in the application.

using System;
using System.Collections;
using System.Collections.Generic;

namespace movie
{
    class data
    {
        public string name { get; set; }

        public List<string> movies { get; set; }

        public data()
        {
            movies = new List<string>();
        }
    }

    class create
    {

        public create()
        {
            data myObj = new data();
            Console.WriteLine("Enter The Name Of The Movie");
            myObj.movies.Add(Console.ReadLine());
        }
    }

    class read
    {
        public read()
        {
            Console.WriteLine("The Movies Are :-");
            data myObj1 = new data();
            foreach (var x in myObj1.movies)
            {
                Console.WriteLine(x);
            }
        }
    }

    class update
    {
        public update()
        {
            data myObj2 = new data();

            Console.WriteLine("Enter The Name Of The Movie You Want To Update");
            var element = Console.ReadLine();
            int index = myObj2.movies.FindIndex(a => a.Contains(element));

            Console.WriteLine("Enter The Name Of The New Movie");
            myObj2.movies[index] = Console.ReadLine();
        }
    }

    class delete
    {
        public delete()
        {
            data myObj3 = new data();
            Console.WriteLine("Enter the movie name you want to delete");
            var element = Console.ReadLine();
            int index = myObj3.movies.FindIndex(a => a.Contains(element));
            myObj3.movies.RemoveAt(index);
        }
    }

    class main
    {
        public static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Enter\n1=>CREATE\n2=>READ\n3=>UPDATE\n4=>DELETE\n5=>exit");



                int x = Convert.ToInt32(Console.ReadLine());
                switch (x)
                {
                    case 1:
                        create createObj = new create();
                        break;

                    case 2:
                        read readObj = new read();
                        break;

                    case 3:
                        update updateObj = new update();
                        break;

                    case 4:
                        delete deleteObj = new delete();
                        break;

                    case 5:
                        break;
                }
            }
        }
    }
}
