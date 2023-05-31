using System;

namespace aufg4
{
    class Unsername
            {
                private string _name;  
                public string Name    
                {
                    get => _name;
                    set => _name = value;
                }
            }

    class Program
    {
        static void Main(string[] args)
        {
           while (true)
            {
            string input = Console.ReadLine();

            switch (input)
            {
                case "new_user" :
                    var User = new Unsername();
                    Console.Write("create new User: ");
                    User.Name = Console.ReadLine();  
                    System.Console.Write(User.Name);
                  //case "user_logout" :
                    break;
                default: 
                    break;
            }
            }
            
        }
        
        
    }
    
}

