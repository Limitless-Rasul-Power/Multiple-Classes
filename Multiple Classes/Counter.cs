using System;

namespace Multiple_Classes
{
    public class Counter
    {
        public int MinValue { get; set; }
        public int CurrentValue { get; set; }

        private int _maxValue;
        public int MaxValue
        {
            get { return _maxValue; }
            set
            {
                if (value <= MinValue)
                    throw new ArgumentOutOfRangeException(nameof(_maxValue), "Maximum counter must be more than Minimum counter!");

                _maxValue = value;
            }
        }

        public Counter(in int minValue, in int maxValue)
        {
            MinValue = minValue;
            MaxValue = maxValue;
            CurrentValue = minValue;
        }
        public int Increment()
        {
            return (CurrentValue == MaxValue - 1) ? CurrentValue = MinValue : ++CurrentValue;
        }
    }
}
