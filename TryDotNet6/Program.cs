using TryDotNet6;

// A source of inspiration: https://twitter.com/okyrylchuk/status/1441749328943411202/photo/1

DateOnly testingASpecificDate = new(2021, 09, 25);

Console.WriteLine($"Current date: {testingASpecificDate}");

DateTime today = DateTime.Now;

DateOnly dateAfterTwoYears = DateOnly.FromDateTime(today.AddYears(2));

Console.WriteLine($"Two years from now: {dateAfterTwoYears}");

// Another source of inspiration: https://twitter.com/okyrylchuk/status/1441084950518849536/photo/1

List<Animal> animals = new();

Animal dog1 = new() { Name = "Musti", Breed = "Finnish Lapphund" };
animals.Add(dog1);

Animal dog2 = dog1 with { Name = "Rekku", Species = IAnimal.SpeciesEnum.Dog };
animals.Add(dog2);

Animal dog3 = dog1 with { Breed = "Karelian Beer Dog" }; // ;)
animals.Add(dog3);

foreach (var animal in animals)
{
    Console.WriteLine($"Name of the dog: {animal.Name}; breed of the dog: {animal.Breed}; species of the dog: {animal.Species}");
}

