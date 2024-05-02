using System.Text;

namespace Working_with_TText
{
    internal class Program
    {
        static void Main(string[] args)
        {
          /*  var fullName = "M n Sakib    ";
            Console.WriteLine("Trim :" + fullName.Trim());
            Console.WriteLine("Trim :" + fullName.Trim().ToUpper());
            var index = fullName.IndexOf('i');
            Console.WriteLine(index);
            Console.WriteLine(fullName.Replace("n", "Nazmus"));
            
            var sentence = "This is going to be really really really really really really really really really long Text";
            const int maxLen = 20;
            if (sentence.Length < maxLen) {
                Console.WriteLine(sentence);
            }
            else
            {
                var words =sentence.Split(' ');
                var totalChar = 0;
                var summuryWords = new List<string>();
                foreach (var word in words)
                {

                    totalChar += word.Length + 1;
                    if (totalChar > 20)
                        break;
                    summuryWords.Add(word);
                  


                }
                var summury = String.Join(" ", summuryWords)+"....";
                Console.WriteLine(summury);
            }*/
            //String builder__________/------/___________________________________
            var builder = new StringBuilder();
            builder.Append('_', 10)
                   .AppendLine()
                   .Append("Header")
                   .AppendLine()
                   .Append('_', 10);
            builder.Replace('_', '$');
            Console.WriteLine(builder);

        }
    }
}
