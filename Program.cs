// N
using System.Text;

namespace PasswordApp
{
    class main
    {
        static List<char> chars = new List<char>();
        static void Main(string[] args)
        {
            AddChars(ref chars);
            while (true) { Console.WriteLine("Enter the length of the password: ");
                int length = 0;
                if (int.TryParse(Console.ReadLine(), out length)) {
                    Console.WriteLine(GeneratePassword(length));
                    Console.WriteLine();
                }
            }
        }

        static string GeneratePassword(int length) {
            StringBuilder sb = new StringBuilder();
            Random rand = new Random();
            int k = 0;
            while (k < length) {
                sb.Append(chars[rand.Next(0, chars.Count)]);
                k++;
            }
            return sb.ToString();
        }

        static void AddChars(ref List<char> chars)
        {
            char num;
            int i;

            for (i = 33; i <= 126; i++)
            {
                num = (char)i;
                chars.Add(num);
            }
        }
    }
}