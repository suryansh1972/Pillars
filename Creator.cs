public abstract class Creator
{
    private int creativityLevel = 100;
    private int energy = 100;

    public int CreativityLevl 
    {
        get
        {
            return creativityLevel;
        }
        set 
        {
            if (value >= 0 && value <= 100)
            {
                creativityLevel = value;
            }
            else
            {
                throw new Exception("Creativity level can only be a value between and 100");
            }
        }
    }
    public int Energy
    {
        get
        {
            return energy;
        }
        set
        {
            if (value >= 0 && value <= 100)
            {
                energy = value;
            }
            else
            {
                throw new Exception("Creativity level can only be a value between and 100");
            }
        }
    }

    public abstract void Create();
}