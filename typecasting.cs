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

 /*Console.Write("enter your name: ");
 string name = Console.ReadLine();
 Console.Write("enter your age");
 string age = Console.ReadLine();
 Console.WriteLine("hello " + name + "you are "+ age);

 Console.ReadLine();*/

 //building a calculator

//int num = Convert.ToInt32("45");
//Console.WriteLine(num+6);

/* Console.Write("enter a number ");
 int num1= Convert.ToInt32(Console.ReadLine());
 Console.Write("enter another number ");
 int num2= Convert.ToInt32 (Console.ReadLine());

 Console.WriteLine(num1 + num2);
 Console.ReadLine();



 Console.Write("enter a number ");
 double num3 = Convert.ToDouble(Console.ReadLine());
 Console.Write("enter another number ");
 double num4 = Convert.ToDouble(Console.ReadLine());

 Console.WriteLine(num3 + num4);
 Console.ReadLine();*/

//building a madLib with taking user input


/*string color, plualNoun, celebrity;

Console.Write("enter a color");
color = Console.ReadLine();


Console.Write("enter a plural noun");
plualNoun = Console.ReadLine();

Console.Write("enter a celebrity");
celebrity = Console.ReadLine();



Console.WriteLine("roses are" + color);
Console.WriteLine(plualNoun +" are blue");
Console.WriteLine("i love "+ celebrity);

Console.ReadLine();*/


//creating a classs student with fields and siplay info

/*using System;

class Student
{

    public int id;
    public string name;
    public double cgpa;


    public void DisplayInfo()
    {
        Console.WriteLine("Student ID: " + id);
        Console.WriteLine("Student Name: " + name);
        Console.WriteLine("CGPA: " + cgpa);

    }
}

class Program
{
    static void Main()
    {

        Student s1 = new Student();


        s1.id = 101;
        s1.name = "Nabil";
        s1.cgpa = 3.75;
        s1.DisplayInfo();
    }
}*/


            //Array 
           /* int[] luckyNumbers = { 4, 8, 16, 32, 64, 128, 256 };
            //for updating
            //luckyNumbers[1] = 9;

            string[] friends = new string[5];
            friends[0] = "jim";
            friends[1] = "lol";
            Console.WriteLine(luckyNumbers[1]);


            Console.ReadLine(); */

                        //methods
/*
            SayHi("nabil " , 22);
            SayHi("mahmud ",23);
            SayHi("lol ",24);

        }

        static void SayHi (string name, int age)
        {
            Console.WriteLine("hello "+ name+ "you are "+ age); */
            
/* //using return type int
            Console.WriteLine(Cube(5))  ;
        } 

        static int Cube (int num)
        {
            int result = num * num* num;
            return result; */
             /*       //if statements

        bool isMale = false;
        bool isTall = false;

        if (isMale && isTall)
        {
            Console.WriteLine("you are a tall male");


        } else if (isMale && !isTall) {
            Console.WriteLine("youre a short male");
        }else if (!isMale && isTall)
        {
            Console.WriteLine("youre a tall female");
        }
        else
        {
            Console.WriteLine("you are a short female");
        }
  */
        //adding new codes.


            
        }
    }
}
