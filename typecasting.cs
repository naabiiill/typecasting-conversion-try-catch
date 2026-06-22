using System;
//cd typecasting-conversion-try-catch
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
            /*var a = 1;
            var b = 2;
            var c = 3;
           Console.WriteLine(a+b);
           Console.WriteLine((float) a/ (float) b);
           Console.WriteLine(a+b *c);
           Console.WriteLine(a>b);
           Console.WriteLine(c>b && c>a); */


            /* Console.WriteLine("    /|");
 Console.WriteLine("   / |");
 Console.WriteLine("  /  |");
 Console.WriteLine(" /   |");
 Console.WriteLine("/____|\n");
 */
            //methods
            /*
             string name= "nabil mahmud";
             Console.WriteLine(name.ToUpper());
             Console.WriteLine(name.ToLower());
             Console.WriteLine(name.Contains("mahmud"));
             Console.WriteLine(name[3]);
             Console.WriteLine(name.IndexOf("mahmud"));
             Console.WriteLine(name.IndexOf('n'));
             Console.WriteLine(name.Substring(6,3));
             Console.WriteLine(name.ToUpper());*/

            /* Console.WriteLine(Math.Abs(-10));
             Console.WriteLine(Math.Pow(3,2));
             Console.WriteLine(Math.Sqrt(36));
             Console.WriteLine(Math.Max(3,9));
             Console.WriteLine(Math.Round(4.3));
            */

             //takin user inpuut

 Console.Write("enter your name: ");
 string name = Console.ReadLine();
 Console.Write("enter your age");
 string age = Console.ReadLine();
 Console.WriteLine("hello " + name + "you are "+ age);

 Console.ReadLine();

            
        }
    }
}
