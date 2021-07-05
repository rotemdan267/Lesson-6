using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static int Function()
        {
            int num = int.Parse(Console.ReadLine());
            if (num > 3)
            {
                return 3;
            }
            else
            {
                return 4;
            }
        }

        public static bool PrintNumbers(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine(i);
            }

            if (num <= 10 && num >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        //    return (num <= 10 && num >= 1);  אותו דבר כמו ה-if-else 
        //                                      מלמעלה


        }

        #region Qst 13
        /// <summary>
        /// Check Which Array Is bigger
        /// </summary>
        /// <param name="arr1"></param>
        /// <param name="arr2"></param>
        /// <returns>int</returns>
        public static int WhichArrayIsBigger(int[] arr1, int[] arr2)
        {
            int sumOfArr1 = 0, sumOfArr2 = 0, currentNubmer;
            for (int i = 0; i < arr1.Length; i++)
            {
                currentNubmer = arr1[i];
                sumOfArr1 += currentNubmer;
            }

            for (int i = 0; i < arr2.Length; i++)
            {
                currentNubmer = arr2[i];
                sumOfArr2 += currentNubmer;
            }

            return (sumOfArr1 > sumOfArr2 ? 1 : sumOfArr1 < sumOfArr2 ? -1 : 0); // תרגום:
            // אם סאםאוףאר1 גדול מסאםאוףאר2 תחזיר 1
            // אחרת אם סאםאוףאר1 קטן מסאםאוףאר2 תחזיר -1
            // אחרת תחזיר 0

            // ? - "אם"
            // : - "אחרת"



        }

        #endregion

        public static void CheckArrayForPrimeNumbers(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int currentNumber = arr[i];
                bool isPrime = true; ;
                string primeOrNot = isPrime ? "Prime" : "Not Prime"; // תרגום:
                // אם (?) איזפריים הוא "אמת" תציב "פריים" בתוך "פרייםאורנוט" אחרת (:) תציב "נוט פריים"

                Console.WriteLine($"Number {i} Is : {primeOrNot}");
            }
        }
    }
}
