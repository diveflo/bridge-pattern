namespace bridge
{
    // "Implementation"
    public interface IColor
    {
        string Draw();
    }

    // "Concrete Implementation"
    class Red : IColor
    {
        public string Draw()
        {
            return "Red";
        }
    }

    // "Concrete Implementation"
    class Blue : IColor
    {
        public string Draw()
        {
            return "Blue";
        }
    }

    // "Concrete Implementation"
    class Green : IColor
    {
        public string Draw()
        {
            return "Green";
        }
    }
}