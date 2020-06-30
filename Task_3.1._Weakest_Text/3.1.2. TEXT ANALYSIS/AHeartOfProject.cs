using System;
using System.Collections.Generic;

namespace _3._1._2.TEXT_ANALYSIS
{
    public class AHeartOfProject
    {
        public string Titul { get; } = "Here must to be your text";

        public string[] CheckPhrase(string example)
        {
            try
            {
                example = example.ToLower();
            }
            catch
            {
                //Exception
            }

            string[] castString = example.Split('_', '-', ':', ';', '.', ',', '!', '?', ' ');

            return castString;
        }

        public Dictionary<string, int> FindRetryWords(string [] castString)
        {
            Dictionary<string, int> saveResult = new Dictionary<string, int>();

            for (int i = 0; i < castString.Length; i++) // Run 
            {
                int count = 0;

                for (int j = i + 1; j < castString.Length; j++)
                {
                    if (castString[i].Equals(castString[j])
                        && castString[i] != ""
                        && castString[j] != "")
                    {
                        ++count;
                    }
                }

                if (!saveResult.ContainsKey(castString[i]))
                {
                    saveResult.Add(castString[i], count);
                }
            }
            return saveResult;
        }
    }
}

