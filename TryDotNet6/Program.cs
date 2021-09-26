using TryDotNet6;

// A source of inspiration: https://twitter.com/okyrylchuk/status/1441749328943411202/photo/1

DateOnly testingASpecificDate = new(2021, 09, 25);

Console.WriteLine($"Specific date: {testingASpecificDate}");

DateTime today = DateTime.Now;

// NEW: DateOnly

DateOnly dateAfterTwoYears = DateOnly.FromDateTime(today.AddYears(2));

Console.WriteLine($"Two years from now: {dateAfterTwoYears}");

// Another source of inspiration: https://twitter.com/okyrylchuk/status/1441084950518849536/photo/1

List<Animal> animals = new();

Animal dog1 = new() { Name = "Musti", Breed = "Finnish Lapphund", Age = 3 };
animals.Add(dog1);

Animal dog2 = dog1 with { Name = "Rekku", Species = IAnimal.SpeciesEnum.Dog, Age = 5 };
animals.Add(dog2);

Animal dog3 = dog1 with { Breed = "Karelian Beer Dog", Age = 1 }; // ;)
animals.Add(dog3);

Animal dog4 = new() { Species = IAnimal.SpeciesEnum.Cat, Name = "Mirri", Age = 2, Breed = "Maine Coon" };
animals.Add(dog4);

foreach (var animal in animals)
{
    Console.WriteLine($"Name of the animal: {animal.Name}; breed of the animal: {animal.Breed}; species of the animal: {animal.Species}");
}

// Third source of inspiration: https://dev.to/satish/net-6-linq-new-features-opb

// NEW: MaxBy and MinBy

var oldestAnimal = animals.MaxBy(animal => animal.Age);
var youngestAnimal = animals.MinBy(animal => animal.Age);

Console.WriteLine($"The oldest animal: {oldestAnimal.Name}, {oldestAnimal.Breed}, {oldestAnimal.Age} years old");
Console.WriteLine($"The youngest animal: {youngestAnimal.Name}, {youngestAnimal.Breed}, {youngestAnimal.Age} years old");

// NEW: Chunk

var cluster = animals.Chunk(2);

foreach (var clusteredAnimals in cluster)
{
    Console.WriteLine($"Size of the cluster: {clusteredAnimals.Length}");
}