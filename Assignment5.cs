//Create a CRUD based App for developing a Movie Database software where the user can add, remove and update movies of his Video library.
//It should be a menu driven program that has 4 use cases for add, removing, finding and updating movie info in the application.

using System;
using System.Collections;
using System.Collections.Generic;

namespace movie{
    class data{
        public string name{get;set;}
        
        public List<string> movies {get;set;}
        
        public data()
        {
            movies=new List<string>();
        }
    }
    
    class create {
        
        public create(data myObj)
        {
        Console.WriteLine("Enter The Name Of The Movie");
        myObj.movies.Add(Console.ReadLine());
        }
    }
    
    class read
    {
        public read(data myObj)
        {
        Console.WriteLine("The Movies Are :-");
        
        foreach(string x in myObj.movies)
        {
            Console.WriteLine(x);
        }
        }
    }
    
    class update
    {
        public update(data myObj)
        {
      
        Console.WriteLine("Enter The Name Of The Movie You Want To Update");
        var element=Console.ReadLine();
        int index=myObj.movies.FindIndex(a=>a.Contains(element));
        
        Console.WriteLine("Enter The Name Of The New Movie");
        myObj.movies[index]=Console.ReadLine();
    }
    }
    
    class delete
    {
        public delete(data myObj)
        {
     
        Console.WriteLine("Enter the movie name you want to delete");
        var element=Console.ReadLine();
        int index=myObj.movies.FindIndex(a=>a.Contains(element));
        myObj.movies.RemoveAt(index);
    }
    }
    
    class main{
        public static void Main(string[] args){
            data myObj=new data();
            
            while(true){
            Console.WriteLine("Enter\n1=>CREATE\n2=>READ\n3=>UPDATE\n4=>DELETE\n5=>exit");
            
            
            
            int x=Convert.ToInt32(Console.ReadLine());
            switch(x)
            {
                case 1:
                create createObj=new create(myObj);
                break;
                
                case 2:
                read readObj=new read(myObj);
                break;
                
                case 3:
                update updateObj=new update(myObj);
                break;
                
                case 4:
                delete deleteObj=new delete(myObj);
                break;
                
                default:
                Console.WriteLine("Invalid Input");
                break;
            }
            
            if(x==5)
            {
                break;
            }
            
            }
        }
    }
}
