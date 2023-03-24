using CODE_language.Exceptions;
using System.IO;

class Program
{
    private static string code = "";
    static void Main(string[] args)
    {
        try
        {
            //Get file and read the source code
            Console.WriteLine("Enter file code: ");
            var file = Console.ReadLine().ToString();

            //Change the file stream to your own directory
            var fileStream = new FileStream(
                @"C:\Users\JMARK\Git Repositories\Programming Language Interpreter\CODE-language\CODE-language\Test\" + file, FileMode.Open, FileAccess.Read);

            //input the file you want from Test folder
            var reader = new StreamReader(fileStream);
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                code += line + "\n";
            }
            reader.Close();
            Print(code);

        }
        catch (Exception e)
        {
            Console.WriteLine("File error: " + e.Message);
        }
    }

    public static void Print(string text)
    {
        Console.WriteLine(text);
        Console.WriteLine("Length: " + text.Length);
    }
}
