public class Dog : Animal
{
    public String breed;

    public Dog(String name, bool hasFur, int numberOfLegs, double sizeInFeet, String breed) : base(name, hasFur, numberOfLegs, sizeInFeet)
    {
        this.breed = breed;
    }

    public override String GetDescription() => base.GetDescription() + " This dog is a " + breed + ".";
}
