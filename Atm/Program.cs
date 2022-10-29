using System;


public class CardHolder
{
    String Firstname;
    String Lastname;
    String CardNumber;
    int Cardid;
    int Pin;
    double Balance;

    public CardHolder(string firstname, string lastname, string cardNumber, int cardid, int pin, double balance)
    {
        Firstname = firstname;
        Lastname = lastname;
        CardNumber = cardNumber;
        Cardid = cardid;
        Pin = pin;
        Balance = balance;
    }

    public string getFirstname()
    {
        return Firstname;
    }

    public string getLastName()
    {
        return Lastname;
    }

    public int getCardid()
    {
        return Cardid;
    }
    public String getCardnumber()
    {
        return CardNumber;
    }
    public int getPin()
    {
        return Pin;
    }
    public double getBalance()
    {
        return Balance;
    }

    public void setFirstname(string newfirstname)
    {
        Firstname = newfirstname;
    }
    public void setLastname(string newlastname)
    {
        Lastname = newlastname;
    }
    public void setCardNumber(string newcardnumber)
    {
        CardNumber=newcardnumber;
    }
    public void setCardid(int newcardid)
    {
        Cardid = newcardid;
    }
    public void setPin(int newpin)
    {
        Pin = newpin;
    }
    public void setBalance(double newbalance)
    {
        Balance= newbalance;
    }

    public static void Main(String[] args)
    {
        void Printoptions()
        {
            Console.WriteLine("click on the options you want to perform");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. show Balance");
            Console.WriteLine("4. Exit");
        }
        void Deposit(CardHolder currentuser)
        {
            Console.WriteLine("Enter the amount you want to Deposit");
            double deposit= Double.Parse(Console.ReadLine());
            double totalbalance =deposit+currentuser.getBalance();
            currentuser.setBalance(totalbalance);
            Console.WriteLine("Thank you for depositing. Your balance is"+currentuser.getBalance());
        }

        void Withdraw(CardHolder currentuser)
        {
            Console.WriteLine("Enter the amount you want to Withdraw");
            double withdraw=Double.Parse(Console.ReadLine());
            if (withdraw > currentuser.getBalance())
                Console.WriteLine("Enter amount is greater than Balance Retry after some time");
            return;
            currentuser.setBalance(currentuser.getBalance()-withdraw);
            Console.WriteLine("Thank you for withdrawl. Your balance is" + currentuser.getBalance());
        }
        void Balance(CardHolder currentuser)
        {
            Console.WriteLine("Current Balance :"+currentuser.getBalance());
        }

        // insert data
        List<CardHolder> cardHolders = new List<CardHolder>();
        cardHolders.Add(new CardHolder("Maruthi","Davuluri","3459 1369 4497 239",12345678,1234,123.56));
        cardHolders.Add(new CardHolder("Camala","Harris","5518 8676 9303 8206",23456789,1345,999.00));
        cardHolders.Add(new CardHolder("Biden","Joe","4811 7406 1378 2814",34567890,3567,3556.00));
        cardHolders.Add(new CardHolder("Trumph","Donald","4930 7981 1144 8417",45678901,7869,234.56));
        cardHolders.Add(new CardHolder("Narredra","Modi","4024007134935401",56789012,8910,786.34));
        cardHolders.Add(new CardHolder("ChandraBabu","Naidu","4532886557934073",67890123,8023,678.12));
        cardHolders.Add(new CardHolder("Bill","Gates","4081478573080464",78901234,7980,7865.45));
        cardHolders.Add(new CardHolder("Amit","Shah","7532886557934073",89012345,5679,5678.35));
        cardHolders.Add(new CardHolder("Adani","Gautham","6773400361442196",90123456,3412,3789.59));
        cardHolders.Add(new CardHolder("Mukesh","Ambani","5929841418350812",01234567,5018,278.79));

        // User Interaction
        Console.WriteLine("Welcome to Bongulo Atm: ");
        Console.WriteLine("Pls insert your Credit/Debit card: ");
        String debitcardnum ;
        CardHolder currentuser;
        while(true)
        {
            try
            {
                debitcardnum = Console.ReadLine();
                // here FirstOrDefault checks the entered data in list
                currentuser = cardHolders.FirstOrDefault(a => a.CardNumber == debitcardnum);
                if(currentuser!=null)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Card insert again");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Invalid Card insert again");
            }
        }
        Console.WriteLine("Pls Enter the Card Pin");
        int userpin=0;

        while (true)
        {
            try
            {
                userpin = Convert.ToInt32(Console.ReadLine());
                // here FirstOrDefault checks the entered data in list
                
                if (currentuser.getPin()==userpin)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid pin");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid Pin Try again");
            }
        }
        Console.WriteLine("Welcome :"+currentuser.getFirstname()+currentuser.getLastName());
        int option= 0; 
        do
        {
            Printoptions();
            try
            {
                option = Convert.ToInt32(Console.ReadLine());
            }
            catch
            { }
            if (option == 1)
                Deposit(currentuser);
            else if (option == 2)
                Withdraw(currentuser);
            else if (option == 3)
                Balance(currentuser);
            else if (option == 4)
                break;
            else
            {
                option = 0;
            }

        }
        while (option != 4);
        Console.WriteLine("Thankyou Keep Visiting");

    }
}
