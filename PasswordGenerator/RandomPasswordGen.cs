using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * A class that generates a random password based on critera: length, lowercase, uppercase, numbers, & symbols.
 */ 

namespace PasswordGenerator
{
    class RandomPasswordGen
    {
        private const int DEFAULT_LENGTH = 10;

        // Character libraries
        private const string LOWERCASE = "abcdefghijklmnopqrstuvwxyz";
        private const string UPPERCASE = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string NUMBERS = "0123456789";
        private const string SYMBOLS = "~!@#$%^&*-+=_";

        private string password = "";



        // Constructs a password of the default length
        public RandomPasswordGen()
        {
            string characterSet = LOWERCASE + UPPERCASE + NUMBERS + SYMBOLS;
            password = generatePW(DEFAULT_LENGTH, characterSet);
        }

        // Constructs a password with a length of n
        public RandomPasswordGen(int n)
        {
            string characterSet = LOWERCASE + UPPERCASE + NUMBERS + SYMBOLS;
            password = generatePW(n, characterSet);
        }

        // Constructs a random password with the option of choosing what kind of characters are used in the password.
        public RandomPasswordGen(int n, bool lowercase, bool uppercase, bool numbers, bool symbols)
        {
            string characterSet = "";

            // Concats characterSet w/ the appropriate characters based on with options are chosen
            if (lowercase)
                characterSet += LOWERCASE;
            if (uppercase)
                characterSet += UPPERCASE;
            if (numbers)
                characterSet += NUMBERS;
            if (symbols)
                characterSet += SYMBOLS;

            password = generatePW(n, characterSet);

        }

        // Generates a random password string based on the length n provided and the characterSet provided.
        public string generatePW(int n, string characterSet)
        {
            Random r = new Random();

            for (int i = 0; i < n; i++)
            {
                int rand = r.Next(characterSet.Length);
                char randChar = characterSet[rand];
                password = password + randChar.ToString();
            }

            return password;
        }

        public String getPassword()
        {
            return password;
        }
    }
}
