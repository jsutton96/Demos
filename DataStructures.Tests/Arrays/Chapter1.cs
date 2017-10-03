using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructures.Tests
{
    [TestClass]
    public class Chapter1
    {
        [TestMethod]
        public void TestHasUniqueCharactersWithHashTable()
        {
            Assert.AreEqual(true, DataStructures.HashTables.Chapter1.HasUniqueCharacters("true"));
            Assert.AreEqual(false, DataStructures.HashTables.Chapter1.HasUniqueCharacters("falsee"));
        }

        [TestMethod]
        public void TestHasUniqueCharactersWithArray()
        {
            Assert.AreEqual(true, Arrays.Chapter1.HasUniqueCharacters("true"));
            Assert.AreEqual(false, Arrays.Chapter1.HasUniqueCharacters("falsee"));
        }

        [TestMethod]
        public void TestReplaceSpacesInString()
        {
            var word = Arrays.Chapter1.ReplaceAllSpaces(new char[] { 'M', 'r', ' ', 'J', 'o', 'h', 'n', ' ', 'S', 'm', 'i', 't', 'h', ' ', ' ', ' ', ' ', ' ' }, 13);
        }
    }
}