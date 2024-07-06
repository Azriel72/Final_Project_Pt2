using SearchWords_ClassLibrary;
using SW_ConsoleApp;

namespace Search_Word_Console
{
    class Program
    {
        static public void Main(String[] args)
        {
            Console.WriteLine("Input the list of words separeted by comas (word1,word2,word3): ");
            string input = Console.ReadLine();

            var inputString = new InputString(input);
            var processingService = new InputService();
            var separatedValues = processingService.SeperatedByComas(inputString);

            IWordsRepository repository = new WordsRepository(separatedValues);
            var search_service = new DDD_Six_Letter_Words(repository);
            var six_letter_words = search_service.Search_SixLetter_Words();

            Console.WriteLine("Six letter words that are composed of at least 2 words in given list:");
            foreach (var word in six_letter_words)
            {
                Console.WriteLine("- " + word);
            }
        }
    }
}
