namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            BankAccount myAccount = new BankAccount(80000);

            Console.WriteLine("How much would you like to deposit?");
            //string _pounds = Console.ReadLine();
            // int _poundsVal = Int32.Parse(_pounds);

            double _bal = 0;

            bool _deposit1 = double.TryParse(Console.ReadLine(), out _bal);

            myAccount.Deposit(_bal);

            Console.WriteLine($"Your new balance is {myAccount.GetBalance()}");
        }

        
    }
}
/* Create a new public class named BankAccount
In your BankAccount class, create the following:
A private field of type double named balance with a value of 0
Define a method named Deposit that will accept a double and store that value in the balance field
Define a method named GetBalance that will return the amount stored in the balance field
In the main method of your application, create a new instance of the BankAccount class. Allow the user of the application to Deposit money and retrieve their balance through the console.
Once finished save, commit, and push back to Github
 */