internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        // syntex 
        // operators 
        // basic class writting 
        // modifiers 
        // Condistional statement 
       
        // for loop
        for(int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
        }

        List<string> names = new List<string>
        {
            "Ajit",
            "Ashar"
        };
        //foreach 
        foreach(var name in names)
        {
            Console.WriteLine(name);
        }

        Console.WriteLine("Is Ashar Join Today?"); // Y Ashar , N,xz Ajit )

        var input = Console.ReadLine();

        // conditional operator 
        var outputPrint = input == "Y" ? "Ashar" : "Ajit";
        Console.WriteLine(outputPrint);


        // while loop 

        // do while loop 

        // switch case 
        // if , if eles
    }
}