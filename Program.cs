namespace CSharp13._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Ось будинок, який збудував Джек. А це пшениця, яка у темній коморі зберігається у будинку, який збудував Джек. А це веселий птах-синиця, який часто краде пшеницю, яка в темній коморі зберігається у будинку, який збудував Джек.";

            char[] delimiters = new char[] { ' ', ',', '.', '!', '?', ';', ':' };
            var words = text
                .ToLower()
                .Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (wordCount.ContainsKey(word))
                {
                    wordCount[word]++;
                }
                else
                {
                    wordCount[word] = 1;
                }
            }

            foreach (var kvp in wordCount)
            {
                Console.WriteLine($"Word: {kvp.Key}, Count: {kvp.Value}");
            }
        }
    }
}
