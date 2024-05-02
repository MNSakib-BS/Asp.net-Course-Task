using _4._Non_Primitive_Types.Math;

namespace _4._Non_Primitive_Types
{
    internal class Program
    {
        public enum ShippingMethod
        {
            RegularAirMail = 1,
            RegisterdAirMail = 2,
            Express = 3

        }
        static void Main(string[] args)
        {
            //           Console.WriteLine("Hello, World!");
            var john = new Person();
            john.FirstName = "John";
            john.LastName = "Smith";
            john.Introduce();
            Calculator calculator = new Calculator();
            calculator.Calc(10, 5);
            var text = @"Software 
eng  
traine";
            Console.WriteLine(text);

            var method = ShippingMethod.Express;
            Console.WriteLine(method);
            var methodId = 2;
            Console.WriteLine((ShippingMethod)methodId);
            var methodName = "Express";
            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
            Console.WriteLine(shippingMethod);
        }
    }
}
