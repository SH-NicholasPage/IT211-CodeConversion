public class Snake : Animal
{
    public bool Poisonous;

    public Snake(string name, bool hasFur, int numberOfLegs, double sizeInFeet, bool poisonous) : base(name, hasFur, numberOfLegs, sizeInFeet)
    {
        this.Poisonous = poisonous;
    }

    public override String GetDescription()
    {
        if(Poisonous == true)
        {
            return base.GetDescription() + " Look out! This snake is poisonous!";
        }
        else
        {
            return base.GetDescription();
        }
    }
}
