using System.Collections.Generic;
using Xunit;

namespace BookingQuest.Test
{
    public class AnagramTest
    {
        private readonly List<string> LineList = new List<string>() { "pear", "amleth", "hamlet", "dormitory", "tinsel", "dirty room", "listen", "silent" };
        private readonly List<string> Expected = new List<string>() { "amleth,hamlet", "dirty room,dormitory", "listen,silent,tinsel", "pear" };
        [Fact]
        public void AnagramNotNull()
        {


            List<string> collection = Anagram.chechAnagrams(LineList);
            Assert.NotNull(collection);
        }
        [Fact]
        public void AnagramNotEmpty()
        {
            List<string> collection = Anagram.chechAnagrams(LineList);
            Assert.NotEmpty(collection);
        }
        [Fact]
        public void AnagramTest0()
        {
            List<string> Actual = Anagram.chechAnagrams(LineList);
            Assert.Equal(Expected[0], Actual[0]);
        }
        [Fact]
        public void AnagramTest1()
        {
            List<string> Actual = Anagram.chechAnagrams(LineList);
            Assert.Equal(Expected[1], Actual[1]);
        }
        [Fact]
        public void AnagramTest2()
        {
            List<string> Actual = Anagram.chechAnagrams(LineList);
            Assert.Equal(Expected[2], Actual[2]);
        }
        [Fact]
        public void AnagramTest3()
        {
            List<string> Actual = Anagram.chechAnagrams(LineList);
            Assert.Equal(Expected[3], Actual[3]);
        }

    }
}
