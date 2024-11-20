// See https://aka.ms/new-console-template for more information
// hangman

string[] possible_words = ["new", "console", "template", "https", "information"];
Random random_numbers = new();

string solution = possible_words[random_numbers.Next(possible_words_words.Length)];

char guess;
string? input;

do
{
    Console.WriteLine("Please enter a character to guess with")
    input = Console.Readline();
    Debug.Assert(input != null);
} while (input.Length != 1)
    
bool guess_was_correct = false;

foreach (char c in solution)
{
    if (guess == c)
    {
        guess_was_correct = true;
    }
}

if (guess_was_correct)
{
    Console.WriteLine($"{guess} exists in the word");
}
else
{
    Console.WriteLine($"{guess} doesn't exists in the word");
}