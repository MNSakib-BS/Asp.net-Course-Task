namespace Day2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* var numbers = new List<int>() { 1,2,3,4};
             numbers.Add(1);
             numbers.Add(2);
             numbers.AddRange(new int[] { 6,7,8});
             foreach(var i  in numbers)
             {
                 Console.WriteLine(i);
             }*/

            var dateTime = new DateTime(2015, 12, 1);
            var now = DateTime.Now;
            var today = DateTime.Today;
            /*Console.WriteLine(today);
            Console.WriteLine(today.ToString());
            Console.WriteLine(now.Hour);
            Console.WriteLine(now.Minute);
            Console.WriteLine(now.Second);
            Console.WriteLine(now.Millisecond);
            Console.WriteLine(now.ToString());*/
            var tommorrow = now.AddDays(1);
            Console.WriteLine(tommorrow.ToString());
            var yesterday = now.AddDays(-1);
            Console.WriteLine(yesterday.ToString());
            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
        }
    }
}
