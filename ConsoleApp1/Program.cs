internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        var sucet = 0;
        while (true) {
            Console.WriteLine("zadaj cislo pre sucet alebo napis ok");
            var input = Console.ReadLine();
            
            if (input == "ok")
            {
                Console.Write("Wysledok je: ");
                Console.WriteLine(sucet);
                break;
            }
            else {
                try
                {
                    sucet += Convert.ToInt32(input);
                }
                catch (Exception)
                {

                    Console.WriteLine("Zle zadany vstup skus znova");
                    continue;
                }

                
            }

        }
    }
}