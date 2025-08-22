namespace Counter.Service
{
    public class CounterService:ICounterService
    {
        private int _count = 0;  

        public int Increment()
        {
            _count++;
            return _count;
        }

        public int Decrement()
        {
            _count--;
            return _count;
        }

        public int GetValue()
        {
            return _count;
        }
    }
}

