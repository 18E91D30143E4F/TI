using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_lab
{
    static class Columns
    {
        public static string Encrypt(string plainText, string key)
        {

            int columnCount = key.Length;
            int rowsCount = (int)Math.Ceiling((double)plainText.Length / columnCount);
            char[,] matrix = new char[rowsCount, columnCount];
            int Index = 0;
            int[,] Order = new int[2, columnCount];
            for (int i = 0; i < columnCount; i++)
            {
                Order[0, i] = (int)key[Index];
                Order[1, i] = Index;
                if (Index != key.Length)
                    Index++;
            }
            Index = 0;
            for (int i = 0; i < rowsCount; i++)
            {
                for (int j = 0; j < columnCount; j++)
                {
                    if (Index < plainText.Length)
                    {
                        matrix[i, j] = plainText[Index];
                        Index++;
                    }
                    else
                        break;
                }
            }

            int temp = 0;
            int IndexTemp;
            for (var i = 1; i < columnCount; i++)
            {
                for (var j = 0; j < columnCount - i; j++)
                {
                    if (Order[0, j] > Order[0, j + 1])
                    {
                        temp = Order[0, j + 1];
                        IndexTemp = Order[1, j + 1];
                        Order[0, j + 1] = Order[0, j];
                        Order[1, j + 1] = Order[1, j];
                        Order[0, j] = temp;
                        Order[1, j] = IndexTemp;
                    }
                }
            }

            int column;
            string cipherText = "";
            for (int i = 0; i < columnCount; i++)
            {
                column = Order[1, i];
                for (int j = 0; j < rowsCount; j++)
                    cipherText += matrix[j, column];
            }

            int index = cipherText.Length;
            for (int i = 0; i < index; i++)
            {
                if (cipherText[i] == '\0')
                {
                    cipherText = cipherText.Remove(i, 1);
                    index--;
                }

            }

            return cipherText;
        }

        public static string Decrypt(string cipherText, string key)
        {
            int columnCount = key.Length;
            int rowsCount = (int)Math.Ceiling((double)cipherText.Length / columnCount);
            char[,] matrix = new char[rowsCount, columnCount];

            int Index = 0;
            int[,] Order = new int[2, columnCount];
            for (int i = 0; i < columnCount; i++)
            {
                Order[0, i] = (int)key[Index];
                Order[1, i] = Index;
                if (Index != key.Length)
                    Index++;
            }

            Index = 0;
            for (int i = 0; i < rowsCount; i++)
            {
                for (int j = 0; j < columnCount; j++)
                {
                    if (Index < cipherText.Length)
                    {
                        matrix[i, j] = cipherText[Index];
                        Index++;
                    }
                    else
                        break;
                }
            }

            int temp;
            int IndexTemp;
            for (var i = 1; i < columnCount; i++)
            {
                for (var j = 0; j < columnCount - i; j++)
                {
                    if (Order[0, j] > Order[0, j + 1])
                    {
                        temp = Order[0, j + 1];
                        IndexTemp = Order[1, j + 1];
                        Order[0, j + 1] = Order[0, j];
                        Order[1, j + 1] = Order[1, j];
                        Order[0, j] = temp;
                        Order[1, j] = IndexTemp;
                    }
                }
            }

            int column;
            Index = 0;

            for (int i = 0; i < columnCount; i++)
            {
                column = Order[1, i];
                for (int j = 0; j < rowsCount; j++)
                    if (Index != cipherText.Length)
                    {
                        if (matrix[j, column] != '\0')
                        {
                            matrix[j, column] = cipherText[Index++];
                        }
                    }
            }

            // Получение текста из матрицы
            string plainText = "";
            for (int i = 0; i < rowsCount; i++)
                for (int j = 0; j < columnCount; j++)
                    if (matrix[i, j] != '\0')
                        plainText += matrix[i, j];

            return plainText;
        }
    }
}
