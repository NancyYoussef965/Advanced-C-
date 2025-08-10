using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



using System;

namespace Advanced_C_
{
    public class Range<T> where T : IComparable<T>, IConvertible
    {
        public T Min { get; }
        public T Max { get; }

        public Range(T min, T max)
        {
            if (min.CompareTo(max) > 0)
                throw new ArgumentException("Min must be less than or equal to Max.");

            Min = min;
            Max = max;
        }

        public bool IsInRange(T value)
        {
            return value.CompareTo(Min) >= 0 && value.CompareTo(Max) <= 0;
        }

        public double Length()
        {
            double minValue = Min.ToDouble(null);
            double maxValue = Max.ToDouble(null);
            return maxValue - minValue;
        }

        public override string ToString()
        {
            return $"[{Min} - {Max}]";
        }
    }
}
