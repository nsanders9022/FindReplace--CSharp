using Xunit;

namespace FindReplaceApp
{
    public class FindReplaceTest
    {
        [Fact]
        public void Replacein_ReplaceWord_NewString()
        {
            //Arrange
            string sentence = "Hello world";
            string findWord = "world";
            string replaceWord = "universe";

            //Act
            FindReplace findReplaceTest = new FindReplace(sentence, findWord, replaceWord);
            string result = findReplaceTest.Replacein();

            //Assert
            Assert.Equal("Hello universe", result);
        }

        [Fact]
        public void Replacein_ReplacePartialWord_NewString()
        {
            //Arrange
            string sentence = "I am walking my cat to the cathedral";
            string findWord = "cat";
            string replaceWord = "dog";

            //Act
            FindReplace findReplaceTest = new FindReplace(sentence, findWord, replaceWord);
            string result = findReplaceTest.Replacein();

            //Assert
            Assert.Equal("I am walking my dog to the doghedral", result);
        }

        [Fact]
        public void Replacein_ReplaceCapitalizedWord_NewString()
        {
            //Arrange
            string sentence = "I am walking my cat to the cathedral";
            string findWord = "CAT";
            string replaceWord = "dog";

            //Act
            FindReplace findReplaceTest = new FindReplace(sentence, findWord, replaceWord);
            string result = findReplaceTest.Replacein();

            //Assert
            Assert.Equal("I am walking my dog to the doghedral", result);
        }

        [Fact]
        public void Replacein_ReplacenameWord_NewString()
        {
            //Arrange
            string sentence = "I am walking my Cat to the cathedral";
            string findWord = "CAT";
            string replaceWord = "dog";

            //Act
            FindReplace findReplaceTest = new FindReplace(sentence, findWord, replaceWord);
            string result = findReplaceTest.Replacein();

            //Assert
            Assert.Equal("I am walking my dog to the doghedral", result);
        }
    }
}
