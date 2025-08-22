namespace Counter
{
    public interface ICounterService
    {

        int Increment();
        int Decrement();
        int GetValue();
    }
}
