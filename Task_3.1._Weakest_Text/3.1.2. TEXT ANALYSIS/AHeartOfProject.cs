using System;
using System.Collections.Generic;

namespace _3._1._2.TEXT_ANALYSIS
{
    public class AHeartOfProject
    {
        public string Titul { get; } = "Here must to be your text";

        public string CheckPhraseOnNullOrWhiteSpace(string example)
        {
            try
            {
                if(!string.IsNullOrWhiteSpace(example))
                {
                    example = example.ToLower();
                }
                else
                {
                    throw new ArgumentNullException("Entered uncorrect value");
                }
            }

            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Message);
            }
            return example;
        }

        public string[] DeleteCharacters(string example)
        {
            string[] castString = example.Split('_', '-', ':', ';', '.', ',', '!', '?', ' ');

            return castString;
        }

        public Dictionary<string, int> FindRetryWords(string [] castString)
        {
            Dictionary<string, int> saveResult = new Dictionary<string, int>();

            for (int i = 0; i < castString.Length; i++) // Compare the elements of string each other
            {
                int countRetryWords = 0;

                for (int j = i + 1; j < castString.Length; j++)
                {
                    if (castString[i].Equals(castString[j])
                        && castString[i] != ""
                        && castString[j] != "")
                    {
                        ++countRetryWords;
                    }
                }

                if (countRetryWords > 0 && !saveResult.ContainsKey(castString[i]))
                {
                    saveResult.Add(castString[i], countRetryWords);
                }
            }

            return saveResult;
        }

        public string ResultWriting(Dictionary<string, int> keyValues)
        {
            string result = "";

            if (keyValues.Count > 7)
                result = "Oh, no. It is horrible";
            if (keyValues.Count > 4 && keyValues.Count < 7)
                result = "The text has a lot of retrying";
            if (keyValues.Count > 1 && keyValues.Count < 4)
                result = "Need to be slightly modidfied this text";
            if (keyValues.Count <= 1)
                result = "The text is awesome";

            return result;
        }
    }
}

