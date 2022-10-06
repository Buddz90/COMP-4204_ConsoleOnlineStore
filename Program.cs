using System;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
using System.Security.Permissions;
using System.Threading;
using System.Linq.Expressions;
using COMP_4204_ConsoleOnlineStore;
using System.Security;

namespace COMP_4204_ConsoleOnlineStore
{
    public class Program
    {
        
        /*// Create Globeal variables here
        public string FirstName;
        public string LastName;        
        public string Password;
        public int balance;*/

        // Entry Point
        public static void Main(string[] args)
        {
            StoreFront.StoreAccess();
            SetAccount.UserAccount();        

        }

    }
    // User Details storage
    public class UserDetails
    {
        public static string input;

        public static string FirstName { get; set; }
            public string LastName { get; set; }        
            public string  Password { get; set; }
            

        public static void SignUp()
        {   

            // Ask for the users name to add to the database.
            L1:Console.Clear();
            Console.Write("\tPlease enter your First name: ");
            string firstName = Console.ReadLine();
            //UserDetails User = new UserDetails();
            FirstName = firstName;
            

            if (firstName != "")
            {
                 
                if (firstName == UserDetails.FirstName)
                goto L2;               
            }
            else
            {   
                Console.WriteLine("\n\tNo Match was found, try again");
                goto L1;
            }
            
            //Console.Clear();
            L2:Console.Write("\tGreat..Now, Please enter your Last name: ");
            string lastName = Console.ReadLine();
            UserDetails userSurName = new UserDetails();        
            userSurName.LastName = lastName;
                
            // Ask user to create a password to create the users store account.
            // Store password in DB with name.
            
            // The next time this user returns to the store, he is able to select the sign-in function.
            L4:Console.Write("\tPlease create a Password: ");
            string userPwd = Console.ReadLine();
            UserDetails userPass = new UserDetails
            {
                Password = userPwd
            };
            

            // >>>MAKE SURE TO VALIDATE LOGIN DETAILS<<<
            if (userPwd != "")
            {
                Console.Write("\tPlease Re-Enter Password: ");
                
                input = Console.ReadLine();
                //input = "";
                
                if (userPwd != input) // >>>The name I doesnt exist in the current context
                {

                    Console.WriteLine("\tTry again");
                    goto L4;               
                }
                else
                {
                    goto L3;
                }
            }    
                else
                {
                if (userPass.Password != userPwd)
                Console.WriteLine("\n\tThis field is empty, try again");
                goto L4;
                }
                        
            // Display message to user then Call UserAccount()
            L3:Console.WriteLine("\tYour account is being created, please wait...");
            Thread.Sleep(1000);
            SetAccount.UserAccount();
        }

        public static void SignIn()// >>>CHANGE NAME OF THIS<<< & OTHER REFS SIGN-IN
        {
            //get; { return LastName;}
            L5:Console.Write("\tPlease enter your First Name: ");
            string CheckUserInit = Console.ReadLine();

            if (CheckUserInit != "")
            {
                if (CheckUserInit == UserDetails.FirstName)
                goto L6;
               
            }
            else
            {   
                Console.WriteLine("\n\tSearching...");
                Thread.Sleep(1000);
                Console.WriteLine("\tName not found, try again");                
                goto L5;
            }

            L6:Console.Write("\tPlease enter your Password: ");
            string CheckUserPwd = Console.ReadLine();
            

            // >>>ADD A CONDITION STATEMENT HERE<<<
            L8:string i = CheckUserPwd;
            UserDetails userPass = new UserDetails();
            //string password = userPass.Password;
            //object value = userPass.Password;
            //Console.WriteLine(userPass.Password);

            if (i != "")
            {
                Console.WriteLine("\tSearching...");
                Thread.Sleep(1000);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\tAccess Granted");
                if (userPass.Password == CheckUserPwd)
                    SetAccount.UserAccount();
                
               
            }
            else
            {   
                Console.WriteLine("\n\tSearching...");
                Thread.Sleep(1000);
                Console.WriteLine("\tName not found, try again");                
                goto L8;
            }
            
        }    
    }      

    // >>>>>>GET AND SET NAME AND PASSWORD fIND vIDEO<<<<<<
    public class StoreFront
    {
        
        // Create a store() front method with the option to sign up or sign in.
        public static void StoreAccess()
        {   
            Console.Write("\tWELCOME TO DIGGYGAMEZ\n\n");
            Console.WriteLine("\tIn order for you to access this store, \n\tyou will need to Sign-Up.");
            Console.WriteLine("\tOnce your account has been created, \n\tyou must add credit to purchase your items.\n\n");
            Console.WriteLine("\tPlease select an option below\n\n\n");
            Console.WriteLine("\t\tSign-Up......[1]");
            Console.WriteLine("\t\tSign-In......[2]\n\n\n");
            // The user is to select and option.
            string input = Console.ReadLine();
            
            // Add requirements to throw error if user enters incorrect character.
            // User input is stored to a variable to use later.
            if  (input == "1")
            { 
                UserDetails.SignUp();     
            }//end of if statement*/
            if (input == "2")
            {
                UserDetails.SignIn();
            }
        }
           

    }
       
    #region UserAccount

                    
    public class SetAccount                    
    {
        public static void UserAccount() 
        {
            Console.WriteLine("\tYou are in the userAccount");
            
            Thread.Sleep(1000);
            
            Console.ReadKey();
        }
        // Deposit funds to account = User Taken to Deposit menu
        public static void TopUp()
        { 

        }
        // Start Shopping = opens to Category Menu()
        public static void Browse()
        {

        }
        // Display Cart = Items selected by user are added to a list, and the prices calculated when user performs purchase 
        public static void Cart()
        {

        }
        // Log-Out
        // Add requirements to throw error if user enters incorrect character.
        
        
        
        #endregion

    
    

}   }

        
        
        
        #region Deposit
        // Deposit()

        // User is prompted to enter and amount
        // Amount is calculated and added to the users account balance and displayed.
        // Add requirements to throw error if user enters incorrect character.
        // Allow the user to select from the options       
        // Browse
        // View Cart
        // Back to account
        #endregion
        #region Menu
        // Menu()

        // Create a list of 3 objects which will be the category list for the user to choose from.
        // PC Games = Display item list
        // PlayStation Games = Display item list
        // XBox Games = Display item list
        // All = Displays all items from each category.

        // Back to account
        // Add requirements to throw error if user enters incorrect character.
        #endregion

        #region Cart
        // Cart() Global

        // Create a list of selected items from the user inputs added to the cart. .
        // Add and display total amount
        // Subtract total from balance and display after purchase balance.
        // Allow user to select from the options
        // Continue Shopping
        // Select Quantity of an item
        // Remove item
        // Deposit funds
        // Purchase

        // Back to previous page
        #endregion
        #region CategoryName
        // catName()

        // Create a list of 3 categories for the user to choose from.
        // Allow the user the option to
        // Select a category = taken to itemList() Option menu

        // Back to menu
        #endregion

        #region ItemList
        // itemList()

        // Display list of items with a descrption and price
        // Allow option for user to
        // Select product to add to Cart() list
        // Display Cart = taken to Cart()
        // Back to previous page.
        #endregion  