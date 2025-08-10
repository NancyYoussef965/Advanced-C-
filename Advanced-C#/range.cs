using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_C_
{
    internal class Range<T> where T : IComparable<T>
    {
        public T Max {  get; set; }
        public T Min { get; set; }

        public Range(T min, T max)


        {  Max = min; Min = max; }

        public bool Contains(T value)
        {
            return value.CompareTo(Min) >= 0 && value.CompareTo(Max) <= 0;
        }


        public double Length()
        {
            if (Min is ValueType)
            {
                var minConv = Min as IConvertible;
                var maxConv = Max as IConvertible;

                if (minConv != null && maxConv != null)
                {
                    double minValue = minConv.ToDouble(null);
                    double maxValue = maxConv.ToDouble(null);
                    return maxValue - minValue;
                }
            }

            throw new NotSupportedException("Length is only supported for numeric types.");
        }

        public override string ToString()
        {
            return $"[{Min} - {Max}]";
        }

    }
}
