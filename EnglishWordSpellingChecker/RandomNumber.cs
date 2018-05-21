using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishWordSpellingChecker
{
    public class RandomNumber
    {
        // Constants
        public RandomNumber()
        {
        }

        // Randomly pick up some unduplicated numbers and save them in list
        public List<int> GetRandomList(int questionAmount, int total)
        {
            List<int> randomNumber = new List<int>();
            Random random = new Random();
            for (int i = 0; i < (questionAmount + 1); i++)
            {
                randomNumber.Add(random.Next(0, total));
                for (int j = 0; j < i; j++)
                {
                    while (randomNumber[j] == randomNumber[i])
                    {
                        j = 0;
                        randomNumber[i] = random.Next(0, total);
                    }
                }
            }
            return randomNumber;
        }

        // Randomly pick up some numbers and save them in list
        public List<int> GetRandomList2(int questionAmount, int min, int max)
        {
            List<int> randomNumber = new List<int>();
            Random random = new Random();
            for (int i = 0; i < (questionAmount + 1); i++)
                randomNumber.Add(random.Next(min, max + 1));
            return randomNumber;
        }

        // Randomly pick up some unduplicated numbers which except for questionNumber and save them in list
        public List<int> GetRandomList3(int questionOptionNumber, int questionNumber, int total)
        {
            List<int> randomNumber = new List<int>();
            Random random = new Random();
            for (int i = 0; i < questionOptionNumber; i++)
            {
                randomNumber.Add(random.Next(0, total));
                for (int j = 0; j < i; j++)
                {
                    while (randomNumber[j] == randomNumber[i] || questionNumber == randomNumber[i] )
                    {
                        j = 0;
                        randomNumber[i] = random.Next(0, total);
                    }
                }
            }
            return randomNumber;
        }
    }
}
