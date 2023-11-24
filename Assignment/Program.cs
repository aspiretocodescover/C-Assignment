using Assignment.Dress;

class Program
{
    static void Main()
    {
        // Create a new dress
        Dress myDress = new Dress("Blue", "Casual", 8, false);

        // Display dress information
        myDress.DisplayInformation();

        // Perform actions on the dress
        myDress.Wear();
        myDress.Wash();
    }
}
 