namespace main;
using common;

    internal class Program
    {
        static void Main(string[] args)
    {
        Console.WriteLine("Numeric functions:");

        Console.WriteLine("Addition: " + NumericFunctions.Add(10, 20));
        Console.WriteLine("Subtraction: " + NumericFunctions.Subtract(30, 10));
        Console.WriteLine("Multiplication: " + NumericFunctions.Multiply(5, 4));
        Console.WriteLine("Division: " + NumericFunctions.Divide(20, 5));

        Console.WriteLine("Max: " + NumericFunctions.FindMax(10, 50));
        Console.WriteLine("Min: " + NumericFunctions.FindMin(10, 50));

        Console.WriteLine("Is Even (10): " + NumericFunctions.IsEven(10));
        Console.WriteLine("Is Odd (7): " + NumericFunctions.IsOdd(7));

        Console.WriteLine("Prime Numbers up to 20:");

        List<int> primes = NumericFunctions.FindPrimes(20);

        foreach (int prime in primes)
        {
            Console.WriteLine(prime);
        }



        Console.WriteLine();

        
        Console.WriteLine("string functions:");


        string sentence = "Hello World 123 !!";
        string sentence2 = "This is second sentence";
        common.StringFunctions sf2 = new common.StringFunctions();

        //1. Count characters
        Console.WriteLine("Character Count: " + StringFunctions.CountCharacters(sentence));

        //2. Palindrome
        StringFunctions sf = new StringFunctions();
        Console.WriteLine("Is Palindrome (madam): " + sf.IsPalindrome("madam"));

        //3. Reverse sentence
        Console.WriteLine("Reversed: " + StringFunctions.ReverseSentence(sentence));

        //4. Count vowels, consonants, digits, special characters
        var result = StringFunctions.CountCharacterTypes(sentence);
        Console.WriteLine("Vowels: " + result.vowels);
        Console.WriteLine("Consonants: " + result.consonants);
        Console.WriteLine("Digits: " + result.digits);
        Console.WriteLine("Special Characters: " + result.specialChars);

        //5. Convert to Upper Case
        Console.WriteLine("Upper Case: " + StringFunctions.ToUpperCase(sentence));

        //6. Proper Case
        Console.WriteLine("Proper Case: " + StringFunctions.ToProperCase(sentence));

        //7. Combine Sentences
        Console.WriteLine("Combined: " + StringFunctions.CombineSentences(sentence, sentence2));

        //8. Remove Extra Spaces
        string spaced = "Hello     World   CSharp";
        Console.WriteLine("Without Extra Spaces: " + StringFunctions.RemoveExtraSpaces(spaced));

        //9. Count Words
        Console.WriteLine("Word Count: " + StringFunctions.CountWords(sentence));

        //10. Search substring
        Console.WriteLine("Contains 'World': " + StringFunctions.ContainsSubstring(sentence, "World"));

        //11. Count substring occurrences
        string text = "hello hello hello";
        Console.WriteLine("Occurrences of 'hello': " + StringFunctions.CountSubstringOccurrences(text, "hello"));



    }
}

