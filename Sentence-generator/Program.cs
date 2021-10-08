using System;

namespace Sentence_generator
{
    class Program
    {
        //Create 100 sentence unique and make a count of the avoided same sentences
        static string randomPickUp(string[] sentence)
        {
            var rand = new Random();
            int number = rand.Next(0, sentence.Length);
            return sentence[number];
        }

        static void sentenceMaker(int number, string[] subjects, string[] verbs, string[] complements)
        {
            var arrSentence = new string[number];
            int numberAvoidedSentences = 0;
            for(int i=0; i < number;)
            {
                var subject = randomPickUp(subjects);
                var verb = randomPickUp(verbs);
                var complement = randomPickUp(complements);
                var sentence = subject + verb + complement;

                if(!Array.Exists(arrSentence, e=>e==sentence))
                {
                    arrSentence[i] = sentence;
                    i++;
                    Console.WriteLine(sentence);
                }
                else
                {
                    numberAvoidedSentences++;
                }
            }
            Console.WriteLine("Double sentence avoided: " + numberAvoidedSentences);
        }

        
        static void Main(string[] args)
        {
            // Subject verb complement

            var subjects = new string[]
            {
                "A rabbit",
                "A grand-mother",
                "A children",
                "A cat",
                "A dog"
            };

            var verbs = new string[]
            {
                " eat ",
                " destroy ",
                " catch ",
                " wash ",
                " hang on "
            };

            var complements = new string[]
            {
                "a meal",
                "a fly",
                "a steak",
                "the table",
                "the curtain",
            };


            sentenceMaker(20, subjects, verbs, complements);

        }
    }
}
