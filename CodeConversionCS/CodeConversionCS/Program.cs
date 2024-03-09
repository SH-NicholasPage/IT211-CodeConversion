const int numberOfAnimals = 4;

Animal[] animals = new Animal[numberOfAnimals];
animals[0] = new Dog("Piper", true, 4, 3.1, "German Shepard");
animals[1] = new Snake("Scalez", false, 0, 5, true);
animals[2] = new Snake("Viper", false, 0, 4.2, false);
animals[3] = new Dog("Fido", false, 4, 1.9, "Xoloitzcuintli");

Console.WriteLine("Printing snakes...");

foreach(Animal a in animals)
{
    if(a.GetType() == typeof(Snake))
    {
        Console.WriteLine(a.GetDescription());
    }
}

Animal favoriteAnimal = animals[Random.Shared.Next(animals.Length)];
Console.WriteLine("My favorite animal is " + favoriteAnimal.Name);

Animal secondFavoriteAnimal = animals[Random.Shared.Next(animals.Length)];

while (secondFavoriteAnimal.Name.Equals(favoriteAnimal.Name))
{
    secondFavoriteAnimal = animals[Random.Shared.Next(animals.Length)];
}
Console.WriteLine("My second favorite animal is " + secondFavoriteAnimal.Name);