using System;

namespace _1_lab
{
    static class RotateGrid
    {
        public static string Encrypt(string plaintext, string key)
        {
            string ciphertext = "";
            int index = 0;
            bool[,] punchingMask;
            int sizeMatr = 5;
            punchingMask = new bool[sizeMatr, sizeMatr];
            char[,] cipherMatrix = new char[sizeMatr, sizeMatr];
            bool saveCenterCell;

            for (int i = 0; i < sizeMatr; ++i)
                for (int j = 0; j < sizeMatr; ++j)
                    if (key[index++] == '0')
                        punchingMask[i, j] = false;
                    else
                        punchingMask[i, j] = true;

            saveCenterCell = punchingMask[sizeMatr / 2, sizeMatr / 2];
            index = 0;

            while (plaintext.Length % (sizeMatr * sizeMatr) != 0)
                plaintext += ' ';

            while (index < plaintext.Length - 1)
            {
                for (int i = 0; i < sizeMatr; ++i)
                {
                    for (int j = 0; j < sizeMatr; ++j)
                    {
                        if (punchingMask[i, j])
                            cipherMatrix[i, j] = plaintext[index++];
                    }
                }

                if (punchingMask[sizeMatr / 2, sizeMatr / 2])
                    punchingMask[sizeMatr / 2, sizeMatr / 2] = false;

                for (int i = 0; i < sizeMatr; i++)
                {
                    for (int j = 0; j < sizeMatr; j++)
                    {
                        if (punchingMask[i, j])
                            cipherMatrix[j, sizeMatr - 1 - i] = plaintext[index++];
                    }
                }

                for (int i = sizeMatr - 1; i >= 0; i--)
                {
                    for (int j = sizeMatr - 1; j >= 0; j--)
                    {
                        if (punchingMask[sizeMatr - 1 - i, sizeMatr - 1 - j])
                            cipherMatrix[i, j] = plaintext[index++];
                    }
                }

                for (int i = 0; i < sizeMatr - 1; i++)
                {
                    for (int j = sizeMatr - 1; j >= 0; j--)
                    {
                        if (punchingMask[i, sizeMatr - 1 - j])
                            cipherMatrix[j, i] = plaintext[index++];
                    }
                }

                for (int i = 0; i < sizeMatr; ++i)
                {
                    for (int j = 0; j < sizeMatr; ++j)
                    {
                        ciphertext += cipherMatrix[i, j];
                    }
                }

                punchingMask[sizeMatr / 2, sizeMatr / 2] = saveCenterCell;
            }

            return ciphertext;
        }
        public static string Decrypt(string ciphertext, string key)
        {
            string plaintext = "";
            int index = 0;
            bool[,] punchingMask;
            int sizeMatr = 5;
            punchingMask = new bool[sizeMatr, sizeMatr];
            char[,] plainMatrix = new char[sizeMatr, sizeMatr];
            bool saveCenterCell;

            for (int i = 0; i < sizeMatr; ++i)
                for (int j = 0; j < sizeMatr; ++j)
                    if (key[index++] == '0')
                        punchingMask[i, j] = false;
                    else
                        punchingMask[i, j] = true;

            saveCenterCell = punchingMask[sizeMatr / 2, sizeMatr / 2];
            index = 0;

            while (ciphertext.Length % (sizeMatr * sizeMatr) != 0)
                ciphertext += ' ';

            for (int i = 0; i < sizeMatr; i++)
            {
                for (int j = 0; j < sizeMatr; j++)
                {
                    plainMatrix[i, j] = ciphertext[index++];
                }
            }

            for (int i = 0; i < sizeMatr; ++i)
            {
                for (int j = 0; j < sizeMatr; ++j)
                {
                    if (punchingMask[i, j])
                        plaintext += plainMatrix[i, j];
                }
            }

            if (punchingMask[sizeMatr / 2, sizeMatr / 2])
                punchingMask[sizeMatr / 2, sizeMatr / 2] = false;

            for (int i = 0; i < sizeMatr; i++)
            {
                for (int j = 0; j < sizeMatr; j++)
                {
                    if (punchingMask[i, j])
                        plaintext += plainMatrix[j, sizeMatr - 1 - i];
                }
            }

            for (int i = sizeMatr - 1; i >= 0; i--)
            {
                for (int j = sizeMatr - 1; j >= 0; j--)
                {
                    if (punchingMask[sizeMatr - 1 - i, sizeMatr - 1 - j])
                        plaintext += plainMatrix[i, j];
                }
            }

            for (int i = 0; i < sizeMatr - 1; i++)
            {
                for (int j = sizeMatr - 1; j >= 0; j--)
                {
                    if (punchingMask[i, sizeMatr - 1 - j])
                        plaintext += plainMatrix[j, i];
                }
            }
            punchingMask[sizeMatr / 2, sizeMatr / 2] = saveCenterCell;

            return plaintext;
        }
    }
}

