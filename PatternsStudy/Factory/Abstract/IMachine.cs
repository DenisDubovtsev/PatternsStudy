namespace Factory.Abstract
{
    public interface IMachine
    {
        string Name { get; }

        void TurnOn();
        void TurnOff();
    }
}
