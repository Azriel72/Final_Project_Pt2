using SearchWords_ClassLibrary;
using SW_ConsoleApp;

namespace UnitTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod_EmptyString()
        {
            string input = "";
            InputString inputString;
            Assert.ThrowsException<ArgumentException>(() => inputString = new InputString(input));
        }

        [TestMethod]
        public void TestMethod_InputString()
        {
            string input = "hola";
            var inputString = new InputString(input);
            Assert.IsTrue(inputString.Value.ToString().Equals(input));
        }

        [TestMethod]
        public void TestMethod_Six_Letter_Words()
        {
            string input = "ho,laas,holaas";
            var inputString = new InputString(input);
            var processingService = new InputService();
            var separatedValues = processingService.SeperatedByComas(inputString);

            IWordsRepository repository = new WordsRepository(separatedValues);
            var search_service = new DDD_Six_Letter_Words(repository);
            var six_letter_words = search_service.Search_SixLetter_Words();
            List<string> expected_result = new List<string>() { "holaas" };
            Assert.IsTrue(expected_result.SequenceEqual(six_letter_words));
        }
    }
}