using Demo.Casting_Operators_Overloading;
using Demo.Operators_Overloading;
using Demo.Polymorphism.Overriding;

namespace Demo
{
    internal class Program
    {

        #region Polymorphism .Overloading [Methods]
        static int sum(int a, int b)
        {
            return a + b;
        }

        static double sum(double a, double b)
        {
            return a + b;
        }

        static double sum(int a, double b)
        {
            return a + b;
        }
        static int sum(int a, int b, int c)
        {
            return a + b + c;
        }
        #endregion

        static void Main(string[] args)
        {


            #region Polymorphism .Overloading 

            #region Operators Overloading

            #region Methods Overloading

            /// dynamic result = sum(10, 20);
            /// result = sum(10.5, 20.5);
            /// result = sum(10, 20.5);
            /// result = sum(10, 20, 30);
            /// 
            /// Console.WriteLine($"Sum of 10 and 20: {result}");
            /// 
            /// // The Best Example of Polymorphism is Console.WriteLine
            /// // => Console.WriteLine Has 18 Overloads
            /// Console.WriteLine("Hello World!");
            /// Console.WriteLine(100);
            /// Console.WriteLine(100.5);
            /// Console.WriteLine(true);
            /// Console.WriteLine(new DateTime(2023, 10, 1));
            #endregion

            Complex C1 = new Complex() { Real = 6, Imag = 15 };

            Complex C2 = new Complex() { Real = 8, Imag = 5 };

            #region Binary Operators

            Complex? C3 = default;

            C3 = C1 + C2; // This will call the overloaded operator + if defined

            Complex C4 = C1 - C2; // This will call the overloaded operator - if defined

            Console.WriteLine($"Complex Number 1: {C1}");
            Console.WriteLine($"Complex Number 2: {C2}");
            Console.WriteLine($"----------------------");
            Console.WriteLine($"Complex Number 1: {C3}");
            Console.WriteLine($"Complex Number 2: {C4}");

            #endregion

            #region Unary Operators

            Console.WriteLine($"Complex Number C1 : {C1}");

            Complex C5 = ++C1; Console.WriteLine($"Complex Number C1 After C++");

            Console.WriteLine($"Complex Number C1 : {C1}");
            Console.WriteLine($"Complex Number C5 : {C5}");

            #endregion

            #region Relational Operators

            if (C1 > C2)
            {
                Console.WriteLine($"Complex Number C1 is Greater than C2");
            }
            else if (C1 < C2)
            {
                Console.WriteLine($"Complex Number C1 is Less than C2");
            }
            else
            {
                Console.WriteLine($"Complex Number C1 is Equal to C2");
            }

            #endregion

            #endregion

            #region Casting Operators Overloading

            #region Example 01

            object obj = 5; // Implicitly casted to object type

            int X = (int)obj; // Explicitly casted back to int type

            Complex complex = new Complex() { Real = 10, Imag = 20 };

            int Y = (int)complex; // Explicitly casted Complex To int Must Be Using Explicit Operator Overloading

            Console.WriteLine($" Y = {Y}");

            #endregion

            #region Example 02

            object obj02 = "Ahmed"; // Implicitly casted to object type

            string X02 = (string)obj02; // Explicitly casted back to int type

            Complex complex02 = new Complex() { Real = 10, Imag = 20 };

            string Y02 = complex02; // Implicitly casted Complex To int Must Be Using Explicit Operator Overloading

            Console.WriteLine($" Y = {Y02}");

            #endregion

            #endregion

            #region Casting Operator Overloading - Buisness Need [Mapping]

            User user = new User()
            {
                Id = 4564,
                FullName = "Mohamed Elbarbary",
                Email = "mohamedelbarbary511@gmail.com",
                Password = "p@ssw0rd",
                SecurityStmp = Guid.NewGuid()
            };

            UserViewModel userViewModel = (UserViewModel)user; // Explicitly casted User To UserViewModel

            Console.WriteLine($"UserViewModel Id: {userViewModel.Id}");
            Console.WriteLine($"UserViewModel FName: {userViewModel.FName}");
            Console.WriteLine($"UserViewModel LName: {userViewModel.LName}");
            Console.WriteLine($"UserViewModel Email: {userViewModel.Email}");
            Console.WriteLine($"UserViewModel Password: {userViewModel.Password}");

            #endregion

            #endregion


            #region Polymorphism .Overriding

            TypeA typeA = new TypeA(1);
            typeA.A = 11;
            typeA.MyFun01(); // Base Method
            typeA.MyFun02(); // Virtual Method

            TypeB typeB = new TypeB(2, 3);
            typeB.A = 22;
            typeB.B = 33;

            typeB.MyFun01(); // New Method (Hiding/Masking Old Method)
            typeB.MyFun02(); // Overridden Method

            #endregion

            #region Binding
            TypeA typeA1 = new TypeB(10, 20);
            typeA1.A = 50;
            // Static Binding - Early Binding (Compilation Time) - Ref Type
            typeA1.MyFun01();
            // Dynamic Binding - Late Binding (Run Time) - Obj Type
            typeA1.MyFun01();
            #endregion

        }
    }
}
