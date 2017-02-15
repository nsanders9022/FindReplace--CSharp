using System.Collections.Generic;
using System;

namespace FindReplaceApp
{
    public class FindReplace
    {
        [Fact]
        public void Replace_ReplaceWord_NewString()
        {
            //Arrange
            string sentence = "Hello world";
            string findWord = "world";
            string replaceWord = "universe";

            //Act
            FindReplace findReplaceTest = new FindReplace(sentence, findWord, replaceWord);
            string result = findReplaceTest.Replace();

            //Assert
            Assert.Equal("Hello universe", result);
        }
    }
}
