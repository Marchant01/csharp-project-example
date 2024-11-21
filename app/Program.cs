using System.Diagnostics;
// See https://aka.ms/new-console-template for more information
// hangman

string[] possible_words = ["new", "console", "template", "https", "information"];
Random random_numbers = new();

string solution = possible_words[random_numbers.Next(possible_words_words.Length)];
string display = new('_', solution.Length);

Console.WriteLine(display);

char guess = get_user_guess();
bool guess_was_correct = false;

for (int i = 0; i < solution.Length; i++)
{
    if (gues[0]== solution[i])
    {
        display.Remove(i,1)
        display.Insert(i, guess)
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

string get_user_guess()
{
    string ? guess == null;

    do
    {
        Console.WriteLine("Please enter a character to guess with")
        string input = Console.Readline();
        Debug.Assert(input != null);
        if (input.Length == 1)
            guess = input[0];
    } while (guess == null);
    return guess;
}