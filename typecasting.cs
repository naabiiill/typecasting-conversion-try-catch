using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            /*var number= 2;
            var count = 10;
            var totalPrice = 20.95f;
            var character= 'A';
            var firstName = "nabil";
            var isWorking = false;
            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);

            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0} {1}",  float.MinValue, float.MaxValue);*/
            // const float Pi = 3.14f;
            //implicit type conversion
            /* byte b = 1;
             int i = b;
             Console.WriteLine(i);*/
            /* explicit type comversion
            int i = 1;
            byte b = (byte) i; //casting is necessary
            Console.WriteLine(b);*/
            /*try
            {
                var number = "1234";
                byte b = Convert.ToByte(number);
                Console.WriteLine(b);
                string str = "true";
                bool b = Convert.ToBoolean(str);
                Console.WriteLine(b);
            }
            catch (Exception)
            {
                Console.WriteLine("the number cannot be converted to a byte");
            }*/
            
                    //arithmetic op
             var a = 1;
             var b = 2;
             var c = 3;
            Console.WriteLine(a+b);
            Console.WriteLine((float) a/ (float) b);
            Console.WriteLine(a+b *c);
            Console.WriteLine(a>b);
            Console.WriteLine(c>b && c>a);

            
        }
    }
}
