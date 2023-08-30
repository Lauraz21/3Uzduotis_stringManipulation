Console.WriteLine("Iveskite zodi");
string word = Console.ReadLine();
char firstLetter = word[0];
Console.WriteLine(firstLetter);

if (char.IsUpper(firstLetter))
{
    Console.WriteLine(word.ToUpper());
}
else
{
    char[] wordArray = word.ToCharArray();
    wordArray[0] = char.ToUpper(wordArray[0]);
    Console.WriteLine(wordArray);
}




//3.1

Console.WriteLine("Iveskite zodi: ");
string word = Console.ReadLine();
char letter = 'a';

if (word.Contains(letter))
{
    Console.WriteLine(word);
    Console.WriteLine(word.IndexOf(letter));
}
else
{
    Console.WriteLine("Simbolis 'a' nerastas");
}





//3.2

Console.WriteLine("Iveskite zodi");
string word = Console.ReadLine();

if (word == "labas")
{
   char[] wordReverse = word.ToArray();
   Array.Reverse(wordReverse);
   Console.WriteLine(wordReverse);
}
else
{
    Console.WriteLine(word);
}