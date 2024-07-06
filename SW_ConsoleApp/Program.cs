using SearchWords_ClassLibrary;

namespace Search_Word_Console
{
    class Search_Words
    {
        static void Main(string[] args)
        {
            Console.Write("Input the array of words (word1,word2,word3,etc): ");
            string input = Console.ReadLine();

            List<string> words = input.Split(',').ToList();
            IWordsRepository repository = new WordsRepository(words);
            var search_service = new DDD_Six_Letter_Words(repository);
            var six_letter_words = search_service.Search_SixLetter_Words();

            foreach (string word in six_letter_words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
