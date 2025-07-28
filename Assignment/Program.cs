namespace Assignment
{
    class Program
    {

        #region Q01 And Q02 And Q03
        // 1. Define Class Duration To include Three Attributes Hours, Minutes and Seconds. 
        class Duration
        {
            #region Q01

            public int Hours { get; set; }
            public int Minutes { get; set; }
            public int Seconds { get; set; }

            #endregion

            #region Q02

            public Duration()
            {

            }

            public Duration(int housr, int minutes, int seconds)
            {
                Hours = housr;
                Minutes = minutes;
                Seconds = seconds;
            }

            public Duration(int seconds)
            {

                int result = 0;
                if (seconds >= 3600)
                {
                    Hours = seconds / (60 * 60);
                    result = seconds % (60 * 60);
                    Minutes = result / 60;
                    Seconds = result % 60;
                }
                else if (seconds >= 60)
                {
                    result = seconds % (60 * 60);
                    Minutes = result / 60;
                    Seconds = result % 60;
                }
                else
                {
                    Seconds = seconds;
                }

            }

            #endregion

            #region Q03
            /// D3=D1+D2
            public static Duration operator +(Duration Left, Duration Right)
            {
                return new Duration()
                {
                    Hours = Left.Hours + Right.Hours,
                    Minutes = Left.Minutes + Right.Minutes,
                    Seconds = Left.Seconds + Right.Seconds
                };
            }

            /// D3=D1 + 7800 
            public static Duration operator +(Duration Left, int Right)
            {
                return new Duration()
                {
                    Hours = Left.Hours + (Right / (60 * 60)),
                    Minutes = Left.Minutes + ((Right % (60 * 60)) / 60),
                    Seconds = Left.Seconds + ((Right % (60 * 60)) % 60)
                };
            }

            /// D3=666+D1
            public static Duration operator +(int Left, Duration Right)
            {
                return new Duration()
                {
                    Hours = Right.Hours + (Left / (60 * 60)),
                    Minutes = Right.Minutes + ((Left % (60 * 60)) / 60),
                    Seconds = Right.Seconds + ((Left % (60 * 60)) % 60)
                };
            }

            /// D3= ++D1 (Increase One Minute)
            public static Duration operator ++(Duration duration)
            {
                return new Duration()
                {
                    Hours = duration.Hours,
                    Minutes = duration.Minutes + 1,
                    Seconds = duration.Seconds
                };
            }

            /// D3 = --D2 (Decrease One Minute)
            public static Duration operator --(Duration duration)
            {
                return new Duration()
                {
                    Hours = duration.Hours,
                    Minutes = duration.Minutes - 1,
                    Seconds = duration.Seconds
                };
            }

            /// D1= D1 -D2
            public static Duration operator -(Duration Left, Duration Right)
            {
                return new Duration()
                {
                    Hours = Left.Hours - Right.Hours,
                    Minutes = Left.Minutes - Right.Minutes,
                    Seconds = Left.Seconds - Right.Seconds
                };
            }

            /// If (D1>D2)

            public static bool operator >(Duration Left, Duration Right)
            {
                if (Left.Hours > Right.Hours)
                    return true;
                else if (Left.Hours == Right.Hours)
                {
                    if (Left.Minutes > Right.Minutes)
                        return true;
                    else if (Left.Minutes == Right.Minutes)
                    {
                        return Left.Seconds > Right.Seconds;
                    }
                }
                return false;
            }

            public static bool operator <(Duration Left, Duration Right)
            {
                if (Left.Hours < Right.Hours)
                    return true;
                else if (Left.Hours == Right.Hours)
                {
                    if (Left.Minutes < Right.Minutes)
                        return true;
                    else if (Left.Minutes == Right.Minutes)
                    {
                        return Left.Seconds < Right.Seconds;
                    }
                }
                return false;
            }
            #endregion

            public override string ToString()
            {
                if (Hours > 0)
                    return $"{Hours} Hours, {Minutes} Minutes, {Seconds} Seconds";
                else
                    return $"{Minutes} Minutes, {Seconds} Seconds";
            }
        }

        #endregion

        static void Main(string[] args)
        {

            /// 
            Duration D1 = new Duration(1, 2, 3);
            Duration D2 = new Duration(7800);
            Duration D4 = new Duration(3400);

            Console.WriteLine($"D1: {D1}");
            Console.WriteLine($"D2: {D2}");
            Console.WriteLine($"D4: {D4}");

            Console.WriteLine("*****************************");
            /// -----------------------
            Duration D3;
            D3 = D1 + D2; // D3=D1+D2
            Console.WriteLine($"D3: D1 + D2 \n{D3} ");

            Console.WriteLine("*****************************");

            D3 = D1 + 7800; // D3=D1 + 7800
            Console.WriteLine($"D3: D1 + 7800 \n{D3} ");

            Console.WriteLine("*****************************");

            D3 = 666 + D1; // D3=666+D1
            Console.WriteLine($"D3: 666 + D1 \n{D3} ");

            Console.WriteLine("*****************************");

            D3 = ++D1; // D3= ++D1 (Increase One Minute)
            Console.WriteLine($"D3: ++D1 \n{D3} ");

            Console.WriteLine("*****************************");

            D3 = --D2; // D3 = --D2 (Decrease One Minute)
            Console.WriteLine($"D3: --D2 \n{D3} ");

            Console.WriteLine("*****************************");

            D3 = D1 - D2; // D3= D1 -D2
            Console.WriteLine($"D3: D1 - D2 \n{D3} ");

            Console.WriteLine("*****************************");

            // If (D1>D2)

            if (D1 > D2)
            {
                Console.WriteLine("D1 is greater than D2");
            }
            else if (D1 < D2)
            {
                Console.WriteLine("D1 is less than D2");
            }
            else
            {
                Console.WriteLine("D1 is equal to D2");
            }

            


        }
    }
}
