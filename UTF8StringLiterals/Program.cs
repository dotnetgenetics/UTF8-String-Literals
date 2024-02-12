namespace UTF8StringLiterals
{
    public class Program
    {
        static void Main(string[] args)
        {
            ReadOnlySpan<byte> AuthStringLiteral = "Simple Example Of UTF-8 String Literal"u8;
            var stringLiteral = System.Text.Encoding.UTF8.GetString(AuthStringLiteral); 
            Console.WriteLine(stringLiteral);

            Console.WriteLine();
            byte[] AnotherAuthStringLiteral = "Another Example of UTF-8 String Literal"u8.ToArray();
            var stringAnotherLiteral = System.Text.Encoding.UTF8.GetString(AnotherAuthStringLiteral);
            Console.WriteLine(stringAnotherLiteral);

            Console.ReadLine();
        }
    }
}
