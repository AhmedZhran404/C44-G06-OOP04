
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Operators_Overloading
{
    class Complex
    {
        public int Real { get; set; }
        public int Imag { get; set; }

        #region Operators Overloading

        // Overloading Operator : Must be Non-Private Class Member Function

        #region Binary Operator

        public static Complex operator +(Complex Left, Complex Right)
        {
            return new Complex()
            {
                Real = (Left?.Real ?? 0) + (Right?.Real ?? 0),
                Imag = (Left?.Imag ?? 0) + (Right?.Imag ?? 0)

                // Left?.Real
                // => Left != null ? Left.Real : 0
            };
        }

        public static Complex operator -(Complex Left, Complex Right)
        {
            return new Complex()
            {
                Real = (Left?.Real ?? 0) - (Right?.Real ?? 0),
                Imag = (Left?.Imag ?? 0) - (Right?.Imag ?? 0)

                // Left?.Real
                // => Left != null ? Left.Real : 0
            };
        }

        #endregion

        #region Unary Operators

        public static Complex operator ++(Complex c)
        {
            return new Complex()
            {
                Real = (c?.Real ?? 0) + 1,
                Imag = (c?.Imag ?? 0),
            };
        }

        public static Complex operator --(Complex c)
        {
            return new Complex()
            {
                Real = (c?.Real ?? 0) - 1,
                Imag = (c?.Imag ?? 0),
            };
        }
        #endregion

        #region Relational Operators

        public static bool operator >(Complex Left, Complex Right)
        {
            if (Left?.Real == Right?.Real)
            {
                return Left?.Imag > Right?.Imag;
            }
            else
            {
                return Left?.Real > Right?.Real;
            }
        }
        public static bool operator <(Complex Left, Complex Right)
        {
            if (Left?.Real == Right?.Real)
            {
                return Left?.Imag < Right?.Imag;
            }
            else
            {
                return Left?.Real < Right?.Real;
            }
        }

        #endregion

        #endregion

        #region Casting Operators Overloading

        // Overloading Casting Operators : Must be Non-Private Class Member Function

        public static /*int*/ explicit operator int(Complex c)
        {
            return c?.Real ?? 0;
        }

        public static /*string*/ implicit operator string(Complex c)
        {
            return c?.ToString() ?? string.Empty;
        }

        #endregion

        public override string ToString()
        {
            return $"{Real} + {Imag}i";
        }
    }
}
