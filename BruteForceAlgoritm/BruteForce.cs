namespace Algorithms_and_data_structure.BruteForceAlgoritm
{
    using System;
    using System.Linq;

    public class BruteForce
    {
        private char[] charactersToTest;
        private int charactersToTestLength;
        private bool isMatched;

        private string password;
        private static string result;

        private static long computedKeys = 0;

        public BruteForce(string passwordToCrack)
        {
            this.charactersToTest = new char[] {
                'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j',
                'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't',
                'u', 'v', 'w', 'x', 'y', 'z','A','B','C','D','E',
                'F','G','H','I','J','K','L','M','N','O','P','Q','R',
                'S','T','U','V','W','X','Y','Z','1','2','3','4','5',
                '6','7','8','9','0','!','$','#','@','-'
             };

            this.isMatched = false;
            this.charactersToTestLength = charactersToTest.Length;
            this.password = passwordToCrack;
        }

        public void Run()
        {
            var timeStarted = DateTime.Now;
            Console.WriteLine($"Start BruteForce - {timeStarted.ToString()}");

            int estimatedPasswordLength = 0;

            while (!isMatched)
            {
                estimatedPasswordLength++;
                var keyChars = createCharArray(estimatedPasswordLength, charactersToTest[0]);

                var indexOfLastChar = estimatedPasswordLength - 1;
                createNewKey(0, keyChars, estimatedPasswordLength, indexOfLastChar);
            }

            Console.WriteLine($"Password matched. - {DateTime.Now.ToString()}");
            Console.WriteLine($"Time passed: {DateTime.Now.Subtract(timeStarted).TotalSeconds}s");
            Console.WriteLine($"Resolved password: {result}");
            Console.WriteLine($"Computed keys: {computedKeys}");
        }

        private char[] createCharArray(int length, char defaultChar)
        {
            return (from c in new char[length] select defaultChar).ToArray();
        }

        private void createNewKey(int currentCharPosition, char[] keyChars, int keyLength, int indexOfLastChar)
        {
            var nextCharPosition = currentCharPosition + 1;
            for (int i = 0; i < charactersToTestLength; i++)
            {
                keyChars[currentCharPosition] = charactersToTest[i];

                if (currentCharPosition < indexOfLastChar)
                {
                    createNewKey(nextCharPosition, keyChars, keyLength, indexOfLastChar);
                }

                else
                {
                    computedKeys++;

                    if ((new String(keyChars)) == password)
                    {
                        if (!isMatched)
                        {
                            isMatched = true;
                            result = new String(keyChars);
                        }

                        return;
                    }
                }
            }
        }
    }
}
