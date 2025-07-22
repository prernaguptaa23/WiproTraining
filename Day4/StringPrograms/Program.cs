class StringPrograms
{
    static void Main()
    {

        string text = "CSharp Language invented in 2002";

        int length = text.Length; //15
        Console.WriteLine("The Length of a string : " + length);
        string subString = text.Substring(7, 8);
        Console.WriteLine("The text from a string : " + subString);
        Console.WriteLine(text.IndexOf("harp"));
        Console.WriteLine(text.ToUpper());
        string newString = text.Replace("CSharp", "Java");
        Console.WriteLine(newString);

        String replaced = text.Replace(" ", "");
        Console.WriteLine("Without space : " + replaced.Length);

        int pos = text.IndexOf("Language");
        string newText = text.Substring(pos, 8);
        Console.WriteLine("New Text Value " + newText.ToUpper());


        string data = "CSharp,Language";
        String[] lang = data.Split(',');
        foreach (string valuess in lang)
        {
            Console.WriteLine(valuess);
        }



        //Count all the blank space
        string blankspace = "Hello World! Welcome to CSharp.";

        int spaceCount = 0;

        foreach (char ch in blankspace)
        {
            if (ch == ' ')
            {
                spaceCount++;
            }
        }

        Console.WriteLine("Total blank spaces: " + spaceCount);



        //Count all the special characters
        string specialChar = "Hello@ C#";
        int specialCharCount = 0;
        foreach (char ch in specialChar)
        {
            if (!char.IsLetterOrDigit(ch) && ch != ' ')
            {
                specialCharCount++;
            }
        }
        Console.WriteLine("Total number of special characters: " + specialCharCount);



        //Count the words in a sentence
        string sentence = "CSharp is a modern programming language";

        string[] words = sentence.Split(' ');
        int wordCount = words.Length;
        Console.WriteLine("Total words: " + wordCount);

        
        //Count vowels
       string vowel = "CSharp is Amazing!";
        int vowelCount = 0;

        foreach (char ch in vowel.ToLower())  // convert all to lowercase
        {
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
            {
                vowelCount++;
            }
        }

        Console.WriteLine("Total vowels: " + vowelCount);



    }
}