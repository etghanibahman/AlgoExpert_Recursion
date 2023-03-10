using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneNumberMnemonics
{
    class Program
    {
        static void Main(string[] args)
        {
            string phoneNumber = "1905";
            Console.WriteLine($"{String.Join(',', PhoneNumberMnemonics(phoneNumber))}");
        }

        public static List<string> PhoneNumberMnemonics(string phoneNumber)
        {
            var mnemonics = new List<string>();
            PhoneNumberMnemonicsHelper(phoneNumber, 0, new StringBuilder(phoneNumber), mnemonics);
            return mnemonics;
        }

        public static void PhoneNumberMnemonicsHelper(string phoneNumber, int idx, StringBuilder mnemonic, List<string> mnemonics)
        {
            if (idx == phoneNumber.Length)
            {
                mnemonics.Add(mnemonic.ToString());
                return;
            }
            foreach (var c in digitToChar[int.Parse(phoneNumber[idx].ToString())])
            {
                mnemonic[idx] = c;
                PhoneNumberMnemonicsHelper(phoneNumber, idx + 1, mnemonic, mnemonics);
            }
        }

        private static Dictionary<int, string> digitToChar = new Dictionary<int, string>() {
            { 0, "0" },
            { 1, "1" },
            { 2, "abc" },
            { 3, "def" },
            { 4, "ghi" },
            { 5, "jkl" },
            { 6, "mno" },
            { 7, "pqrs" },
            { 8, "tuv" },
            { 9, "wxyz" },
        };
    }
}
