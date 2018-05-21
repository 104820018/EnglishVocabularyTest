using Microsoft.VisualStudio.TestTools.UnitTesting;
using EnglishWordSpellingChecker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishWordSpellingChecker.Tests
{
    [TestClass()]
    public class RandomNumberTests
    {
        RandomNumber _randomNumber;

        // Initialize the object
        [TestInitialize()]
        public void Initialize()
        {
            _randomNumber = new RandomNumber();
        }

        // Test RandomNumber.GetRandomList(int questionAmount, int total)
        [TestMethod()]
        public void GetRandomListTest()
        {
            List<int> randomNumber = new List<int>();
            List<int> randomNumber2 = new List<int>();
            randomNumber = _randomNumber.GetRandomList(10, 11);
            for (int i = 0; i < 10; i++)
                randomNumber2.Add(randomNumber[i]);
            for (int i = 0; i < 10; i++)
                for (int j = 0; j < i; j++)
                    Assert.AreNotEqual(randomNumber2[j], randomNumber2[i]);
        }

        // Test RandomNumber.GetRandomList2(int questionAmount, int min, int max)
        [TestMethod()]
        public void GetRandomList2Test()
        {
            bool isRandom = true;
            List<int> randomNumber = new List<int>();
            randomNumber = _randomNumber.GetRandomList2(10, 1, 3);
            for (int i = 0; i < 10; i++)
            {
                if (randomNumber[i] < 1)
                    isRandom = false;
                if (randomNumber[i] > 3)
                    isRandom = false;
            }
            Assert.IsTrue(isRandom);
        }

        // Test RandomNumber.GetRandomList3(int questionOptionNumber, int questionNumber, int total)
        [TestMethod()]
        public void GetRandomList3Test()
        {
            List<int> randomNumber = new List<int>();
            List<int> randomNumber2 = new List<int>();
            randomNumber = _randomNumber.GetRandomList3(10, 540, 11);
            for (int i = 0; i < 10; i++)
                randomNumber2.Add(randomNumber[i]);
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < i; j++)
                    Assert.AreNotEqual(randomNumber2[j], randomNumber2[i]);
                Assert.AreNotEqual(540, randomNumber2[i]);
            }
        }
    }
}