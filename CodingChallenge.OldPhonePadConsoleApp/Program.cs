using CodingChallenge.OldPhonePadConsoleApp.OldPhonePad;

public class Program
{
    public static void Main(string[] args)
    {
        OldPhonePadService service = new OldPhonePadService();
        string input = "8 88777444666*664#";
        string result = service.OldPhonePad(input);
        Console.WriteLine($"{input} => {result}");
    }
}