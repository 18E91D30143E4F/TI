using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_lab
{
    static class RailFence
    {
        public static string Encrypt(string Text, short key)
        {
            // Array of text as rails
            char[,] Rails = new char[key, Text.Length];
            bool GoDown = true;
            string Result = "";


            for (int i = 0, Row = 0, Column = 0; i < Text.Length; i++)
            {
                Rails[Row, Column] = Text[i];
                Column++;

                if (GoDown) Row++;
                else Row--;

                if ((Row == 0) || (Row == key - 1))
                    GoDown = !GoDown;
            }

            foreach (char Sym in Rails)
                if (Sym != 0) Result += Sym;

            return Result;
        }

        public static string Decrypt(string EncryptedText, short key)
        {
            string Result = ""; int Ind = 0;

            // Array of text as rails
            char[,] Rails = new char[key, EncryptedText.Length];
            bool GoDown = true;

            // Fill array[][] as rails
            for (int i = 0, Row = 0, Column = 0; i < EncryptedText.Length; i++)
            {
                // S - random char
                Rails[Row, Column] = 'S';
                Column++;

                if (GoDown) Row++;
                else Row--;

                if ((Row == 0) || (Row == key - 1))
                    GoDown = !GoDown;
            }

            // Fill array encrypted text
            for (int i = 0; i < key; i++)
                for (int j = 0; j < EncryptedText.Length; j++)
                    if (Rails[i, j] == 'S')
                    {
                        Rails[i, j] = EncryptedText[Ind];
                        Ind++;
                    }

            GoDown = true;
            for (int i = 0, Row = 0, Column = 0; i < EncryptedText.Length; i++)
            {
                Result += Rails[Row, Column];
                Column++;

                if (GoDown) Row++;
                else Row--;

                if ((Row == 0) || (Row == key - 1))
                    GoDown = !GoDown;
            }

            return Result;
        }
    }
}
