using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLongInt
{
    class LongNumber
    {
        enum NumTypes
        {
            Positive,Negative
        }

        private List <int> digits;
        private NumTypes numTypes;

        public LongNumber()
        {
            digits = new List<int>(){0};
            numTypes = NumTypes.Positive;
        }

        public LongNumber(string number)
        {
            digits = new List<int>();

            if (number.StartsWith("-"))
            {
                numTypes = NumTypes.Negative;
                number = number.Remove(0, 1);
            }
            else
            {
                numTypes = NumTypes.Positive;
            }

            number = number.TrimStart('0');

            for (int i = number.Length-1; i >=0; i--)
            {
                digits.Add(Convert.ToInt32(number[i].ToString()));
            }
        }
        public LongNumber(LongNumber longNumber)
        {
            digits = new List<int>();
            numTypes = longNumber.numTypes;

            for (int i = 0; i < longNumber.digits.Count; i++)
            {
                digits.Add(longNumber.digits[i]);
            }
        }

        public int AbsCompareTo(LongNumber longNumber)
        {

            if ((digits.Count - 1) > longNumber.digits.Count)
            {
                return 1;
            }
            else if ((digits.Count - 1) < longNumber.digits.Count)
            {
                return -1;
            }
            else
            {
                for (int i = digits.Count - 1; i >= 0; i++)
                {
                    if (digits[i] > longNumber.digits[i])
                    {
                        return 1;
                    }
                    else if (digits[i] < longNumber.digits[i])
                    {
                        return -1;
                    }
                }
            }
            return 0;
        }

        public int CompareTo(LongNumber longNumber)
        {
            if (numTypes==NumTypes.Positive&&longNumber.numTypes==NumTypes.Negative)
            {
                return 1;
            }
            else if(numTypes == NumTypes.Negative && longNumber.numTypes == NumTypes.Positive)
            {
                return -1;
            }
            else if(numTypes==NumTypes.Positive&&longNumber.numTypes==NumTypes.Positive)
            {
                return AbsCompareTo(longNumber);
            }
            else if(numTypes==NumTypes.Negative&&longNumber.numTypes==NumTypes.Negative)
            {
                return -AbsCompareTo(longNumber);
            }
            else
            {
                return 0;
            }
        }

        public void AbcSum(LongNumber longNumber)
        {

        }
        public static bool operator==(LongNumber longNumber1, LongNumber longNumber2)
        {
            return longNumber1.CompareTo(longNumber2) == 0;
        }
        public static bool operator !=(LongNumber longNumber1, LongNumber longNumber2)
        {
            return longNumber1.CompareTo(longNumber2) != 0;
        }
        public static bool operator>=(LongNumber longNumber1,LongNumber longNumber2)
        {
            int CompareResult = longNumber1.CompareTo(longNumber2);
            return CompareResult == 1 || CompareResult == 0;
        }
        public static bool operator <=(LongNumber longNumber1, LongNumber longNumber2)
        {
            int CompareResult = longNumber1.CompareTo(longNumber2);
            return CompareResult == 0 || CompareResult == -1;
        }
        public static bool operator >(LongNumber longNumber1, LongNumber longNumber2)
        {
            return longNumber1.CompareTo(longNumber2) == 1;
        }
        public static bool operator <(LongNumber longNumber1, LongNumber longNumber2)
        {
            return longNumber1.CompareTo(longNumber2) == -1;
        }

        public override string ToString()
        {
            string result = "";
            if(numTypes==NumTypes.Negative)
            {
                result += "-";
            }
            for (int i = digits.Count - 1; i >= 0; i--)
            {
                result += digits[i];
            }
            return result;
        }
    }
}
