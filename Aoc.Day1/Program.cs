var tokens = File.ReadAllLines("input.txt");
var numbers = new List<int>();

foreach (var token in tokens)
{
    var characters = token.ToCharArray();
    var localNumbers = characters.Where(char.IsDigit).ToList();
    numbers.Add(int.Parse($"{localNumbers.First()}{localNumbers.Last()}"));
}

Console.WriteLine(numbers.Sum());