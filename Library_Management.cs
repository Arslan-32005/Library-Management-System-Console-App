//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace FirstProject
//{
//    class Library_Management
//    {
//        static Dictionary<string,int> inventory = new Dictionary<string,int>();
//        static void Main(string[] args)
//        {
//            while(true)
//            {
//                Console.WriteLine("--------Library Management System-------");
//                Console.WriteLine("1- Add Books");
//                Console.WriteLine("2- View All Books");
//                Console.WriteLine("3- Issue Books");
//                Console.WriteLine("4- Return Books");
//                Console.WriteLine("5- Search Book");
//                Console.WriteLine("6- Exit");
//                Console.Write(" Enter the choice: ");
//                string choice=Console.ReadLine();
//                switch(choice)
//                {
//                    case "1":
//                        AddBooks();
//                        break;
//                    case "2":
//                        ViewAllBooks();
//                        break;
//                    case "3":
//                        IssueBook();
//                        break;
//                    case "4":
//                        ReturnBook();
//                        break;
//                    case "5":
//                        SearchBook();
//                        break;
//                    case "6":
//                        Console.WriteLine("Exit the System");
//                        return; 
//                }
//            }
//        }
//        static void AddBooks()
//        {
//            Console.Write("Enter the title of Book: ");
//            string title=Console.ReadLine();
//            Console.Write("Enter the total Copies of title: ");
//            int copies = Convert.ToInt32(Console.ReadLine());
//            if (inventory.ContainsKey(title))
//            {
//                Console.WriteLine("This title is already exist.Try some other title");
//                return;
//            }
//            else
//            {
//                inventory.Add(title, copies);
//            }
            
//        }
//        static void ViewAllBooks()
//        {
//            if(inventory.Count==0)
//            {
//                Console.WriteLine("No Book in the List");
//                return;
//            }
//            foreach(var book in inventory)
//            {
//                Console.WriteLine($"Name: {book.Key} Copies: {book.Value}");
//            }
//        }
//        static void IssueBook()
//        {
//            Console.Write("Which Book do you want: ");
//            string issue=Console.ReadLine();
//            if(!inventory.ContainsKey(issue))
//            {
//                Console.WriteLine("Book does not exist");
//                return;
//            }
//            else if (inventory[issue] ==0)
//            {
//                Console.WriteLine("Book exist But we have no copies.");
//                return;
//            }
//            else
//            {
//                inventory[issue]--;
//                Console.WriteLine("Book is available to be issued.");
//                return;
//            }
//        }
//        static void ReturnBook()
//        {
//            Console.Write("which Book you want To return: ");
//            string ret=Console.ReadLine();
//            if(!inventory.ContainsKey(ret))
//            {
//                Console.WriteLine("book cannot be returned Because It does not exist");
//            }
//            else
//            {
//                // adding the book back to the inventory
//                inventory[ret]++;

//            }
//        }
//        static void SearchBook()
//        {
//            Console.Write("Enter the Book Title you want to search: ");
//            string search = Console.ReadLine();
//            if (inventory.ContainsKey(search))
//            {
//                Console.WriteLine($"Book is available Copies: {inventory[search]}");
//            }
//            else
//            {
//                Console.WriteLine("Book is not available");
//            }
//        }

//    }
//}
