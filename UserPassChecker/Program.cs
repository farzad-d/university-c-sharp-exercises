using System;

// namespace UserPassChecker
// {
//     internal class Program
//     {
//         static void Main(string[] args)
//         {
//             //Vars
//             string userName, password;

//             //Inputs
//             Console.WriteLine("Enter your username: ");
//             userName=Console.ReadLine();
//             Console.WriteLine("Enter your password: ");
//             password=Console.ReadLine();

//             //Display the result
//             if(userName=="admin" && password=="Pp=-0987")
//             {
//                 Console.WriteLine("Welcome Admin!");
//             }
//             else if(userName=="admin" && password!="Pp=-0987")
//             {
//                 Console.WriteLine("Your password isn't correct.");
//             }
//             else if(userName!="admin" && password=="Pp=-0987")
//             {
//                 Console.WriteLine("Your username isn't correct.");
//             }
//             else
//             {
//                 Console.WriteLine("Your both username and password are incorrect.");
//             }
//         }
//     }
// }



// With (switch) instead of (if)

namespace UserPassChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Vars
            string userName, password;

            //Inputs
            Console.WriteLine("Enter your username: ");
            userName=Console.ReadLine();
            Console.WriteLine("Enter your password: ");
            password=Console.ReadLine();

            //Display the result
            switch(userName == "admin" , password == "Pp=-0987")
            {
                case (true, true):
                    Console.WriteLine("Welcome Admin!");
                    break;
                case (true, false):
                    Console.WriteLine("Your password isn't correct.");
                    break;
                case (false, true):
                    Console.WriteLine("Your username isn't correct.");
                    break;
                default:
                    Console.WriteLine("Your both username and password are incorrect.");
                    break;
            }
        }
    }
}


