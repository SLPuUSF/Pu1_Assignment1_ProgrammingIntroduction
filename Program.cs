using System;

namespace Pu1_Assignment1ProgrammingIntroduction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Question 1");
            int n = 5;
            PrintPattern(n);

            Console.WriteLine("Question 2");
            int n2 = 6;
            printseries(n2);


            Console.WriteLine("Question 3");
            string s = "09:15:35pm";
            string t = usftime(s);
            Console.WriteLine(t);


            Console.WriteLine("Question 4");
            int n3 = 110;
            int k = 11;
            usfnumbers(n3, k);

            Console.WriteLine();
            Console.WriteLine("Question 5");
            string[] words = new string[] { "abcd", "dcba", "lls", "s", "sssll" };
            Palindromepairs(words);

            Console.WriteLine();
            Console.WriteLine("Question 6");
            int n4 = 7;
            Stones(n4);

        }


        /// question 1:
        private static void PrintPattern(int n)
        {
            double num = 0;
            try
            {
                //write your code here .!!
                for (int count = n; count > 0; count--)
                {
                    for (int index = count; index > 0; index--)
                    {
                        var power = Math.Pow(10, (index - 1));

                        num += (index * power);

                    }
                    Console.WriteLine(num.ToString());
                    num = 0;
                }
                Console.WriteLine();
            }
            catch
            {
                Console.WriteLine("exception occured while computing printpattern");
            }
        }


        /// question 2:
        private static void printseries(int n2)
        {
            try
            {
                // Solution One:

                int size = n2;
                double[] seriesarray = new double[size];
                for (int count = 1; count <= n2; count++)
                {
                    seriesarray[count - 1] = (1 + count) * count / 2;
                }

                Console.WriteLine(string.Join(",", seriesarray));
                Console.WriteLine();

                // Solution Two
                //int size = n2; // there are n2 type combinations.
                //int[] sumArray = new int[size]; // create an array to store sums.

                //for (int itemIndex = 0; itemIndex < n2; itemIndex++) // go into items of sumArray one by one and store sum.
                //{
                //    int sum = 0;

                //    for (int Num = 1; Num <= itemIndex + 1; Num++) // caculate sum of each combination.
                //                                                   // each combination includes numbers from 1 to (itemIndex + 1)
                //    {
                //        sum = sum + Num;
                //    }
                //    sumArray[itemIndex] = sum;
                //}
                //Console.WriteLine(string.Join(",", sumArray));
                //Console.WriteLine();
            }
            catch
            {
                Console.WriteLine("exception occured while computing printseries");
            }
        }


        /// question 3:
        public static string usftime(string s)
        {
            try
            {
                // earth date input
                //Console.WriteLine("enter the date of earth with the format of hh:mm:ssam or hh:mm:sspm: ");
                //string earthdateinput = Console.ReadLine();

                string earthdateinput = s;
                DateTime dateofearth = Convert.ToDateTime(earthdateinput);

                // calculateions
                int enteredhours = dateofearth.Hour;
                int enteredminutes = dateofearth.Minute;
                int enteredseconds = dateofearth.Second;

                // total seconds of dateofearth
                int totalsecofearth = enteredhours * 3600 + enteredminutes * 60 + enteredseconds;

                // calculate the date of usf
                int usfhours = totalsecofearth / (60 * 45);
                int usfminutes = (totalsecofearth - usfhours * (60 * 45)) / 45;
                int usfseconds = totalsecofearth - usfhours * (60 * 45) - usfminutes * 45;

                //datetime usfdate = new datetime(0, 0, 0, usfhours, usfminutes, usfseconds);
                int[] usfdate = new int[] { usfhours, usfminutes, usfseconds };

                Console.WriteLine("usf format: " + string.Join(":", usfdate));

                Console.WriteLine();
            }
            catch
            {
                Console.WriteLine("exception occured while computing usftime");
            }
            return null;
        }



        /// question 4:

        public static void usfnumbers(int n3, int k)
        {
            try
            {
                // write your code here
                //Console.WriteLine("select the numbers 1 to 110, 11 numbers per line.");

                string[] myIntArray = new string[110];
                int[] numbersArray = new int[110];
                for (int i = 1; i <= 110; i++)
                {
                    numbersArray[i - 1] = i;
                }
                foreach (int myNumber in numbersArray)
                {
                    if (myNumber % 15 == 0)
                    {
                        myIntArray[myNumber - 1] = "us";
                    }
                    else if (myNumber % 35 == 0)
                    {
                        myIntArray[myNumber - 1] = "sf";
                    }
                    else if (myNumber % 3 == 0)
                    {
                        myIntArray[myNumber - 1] = "u";
                    }
                    else if (myNumber % 5 == 0)
                    {
                        myIntArray[myNumber - 1] = "s";
                    }
                    else if (myNumber % 7 == 0)
                    {
                        myIntArray[myNumber - 1] = "f";
                    }
                    else
                    {
                        myIntArray[myNumber - 1] = myNumber.ToString();
                    }

                }
                // print the list
                for (int a = 0; a < myIntArray.Length; a++)
                {
                    Console.Write(myIntArray[a] + " ");
                    if ((a + 1) % 11 == 0)
                    {
                        Console.WriteLine();
                    }
                }
            }
            catch
            {
                Console.WriteLine("exception occured while computing usfnumbers()");
            }
        }



        // Question 5:
        public static void Palindromepairs(string[] words)
        {
            try
            {
                // write your code here

                string[] wordsArray = words;

                int n = wordsArray.Length;
                int SIZE = n * (n - 1);
                string[] compareArray = new string[SIZE];
                string outPut = null;

                // combine any two of wordsArray's items and store into the compareArray
                for (int countNum = 0; countNum < n; countNum++)
                {
                    for (int countOne = 0; countOne < countNum; countOne++)
                    {
                        string combineWords = wordsArray[countNum] + wordsArray[countOne];
                        // Split all chars of string variable to CharArray
                        char[] inputWordsAsChars = combineWords.ToCharArray();

                        int lengthOfChars = inputWordsAsChars.Length;
                        char[] resortCharsArray = new char[lengthOfChars];
                        // Resort chars
                        for (int charIndex = 0; charIndex < lengthOfChars; charIndex++)
                        {
                            resortCharsArray[charIndex] = inputWordsAsChars[lengthOfChars - 1 - charIndex];
                        }

                        // Store resortCharsArray into a string variable.
                        string resortWords = new string(resortCharsArray);

                        // Display the results.
                        //Console.WriteLine("Resort: " + resortWords);

                        if (resortWords == combineWords)
                        {
                            int lWordsIndex = countNum;
                            int rWordsIndex = countOne;
                            outPut = outPut + "[" + lWordsIndex.ToString() + "," + rWordsIndex.ToString() + "]" + " ";
                        }
                    }
                    for (int countTwo = countNum + 1; countTwo < n; countTwo++)
                    {
                        string combineWords = wordsArray[countNum] + wordsArray[countTwo];
                        // Split all chars of string variable to CharArray
                        char[] inputWordsAsChars = combineWords.ToCharArray();

                        int lengthOfChars = inputWordsAsChars.Length;
                        char[] resortCharsArray = new char[lengthOfChars];
                        // Resort chars
                        for (int charIndex = 0; charIndex < lengthOfChars; charIndex++)
                        {
                            resortCharsArray[charIndex] = inputWordsAsChars[lengthOfChars - 1 - charIndex];
                        }

                        // Store resortCharsArray into a string variable.
                        string resortWords = new string(resortCharsArray);     // Display the results.

                        if (resortWords == combineWords)
                        {
                            int lWordsIndex = countNum;
                            int rWordsIndex = countTwo;
                            outPut = outPut + "[" + lWordsIndex.ToString() + "," + rWordsIndex.ToString() + "]" + " ";
                        }
                    }

                }

                Console.WriteLine("Output: " + outPut);
            }
            catch
            {
                Console.WriteLine("exception occured while computing Palindromepairs()");
            }
        }


        // Question 6:
        public static void Stones(int n4)
        {
            try
            {
                // Write your code here
                int stoneNum = n4;
                canWinGame(stoneNum);

                bool canWinGame(int n)
                {
                    return (n % 4 != 0);
                }
                int remainderNum = stoneNum % 4;
                int quotientNum = stoneNum / 4;
                int roundForPlyerTwo = (stoneNum - remainderNum) / 4;
                int totalGame = 2 * quotientNum + 1;

                int rowSize = 2 * quotientNum + 1;
                int columSize = (int)Math.Pow(3, quotientNum);

                int MATRIX_ROWS = 1;
                int MATRIX_COLUMNS = 1;
                int MATRIX2_ROWS = 0;
                int MATRIX3_ROWS = 0;
                int MATRIX3_COLUMNS = 0;
                
                int[,] solutionMatrix = new int[rowSize, columSize]; 
                int[,] solutionMatrix2 = new int[rowSize, 3];
                int[,] solutionMatrix3 = new int[rowSize, columSize];

                if (canWinGame(stoneNum) == true)
                {
                    for (int count = 0; count < columSize; count++) // first round player 1 have to pick up storns amount to remainderNum.
                    {
                        solutionMatrix[0, count] = remainderNum;
                    }

                    for (int num = 1; num <= roundForPlyerTwo; num++) // after player 1 pick up storns first time, there are num rounds left.
                    {
                        MATRIX2_ROWS = 2 * num + 1;

                        MATRIX3_ROWS = 2 * num + 1;
                        MATRIX3_COLUMNS = (int)Math.Pow(3, num);

                        // Each column is a solution set. For coming game, play has three ways to take off storn
                        for (int numOne = 0; numOne < MATRIX_COLUMNS; numOne++) // scan the columns of solutionMatrix
                        {
                            for (int pickNum = 1; pickNum <= 3; pickNum++) // add new solution to previous solution set.
                            {
                                // solution new soluton into solutionMatrix2
                                for (int numTwo = 0; numTwo < MATRIX_ROWS; numTwo++)
                                {
                                    solutionMatrix2[numTwo, pickNum - 1] = solutionMatrix[numTwo, numOne];
                                }
                                solutionMatrix2[MATRIX2_ROWS - 2, pickNum - 1] = pickNum;
                                solutionMatrix2[MATRIX2_ROWS - 1, pickNum - 1] = 4 - pickNum;
                            }

                            // add each solutionMatrix2 to solutionMatrix3
                            for (int numThr = 3 * numOne; numThr < (3 * (numOne +1)) && numThr < MATRIX3_COLUMNS; numThr++)
                            {
                                for (int numFou = 0; numFou < MATRIX2_ROWS; numFou++)
                                {
                                    solutionMatrix3[numFou, numThr] = solutionMatrix2[numFou, (numThr - 3 * numOne)];
                                }
                            }
                        }

                        // copy solutionMatrix3 to solutionMatrix
                        for (int numFiv = 0; numFiv < columSize; numFiv++)
                        {
                            for (int numSix = 0; numSix < rowSize; numSix++)
                            {
                                solutionMatrix[numSix, numFiv] = solutionMatrix3[numSix, numFiv];
                            }
                        }
                        MATRIX_ROWS = 2 * num + 1;
                        MATRIX_COLUMNS = (int)Math.Pow(3, num);
                    }

                    // Print each columun 
                    Console.Write("Output: ");
                    for (int j = 0; j < columSize; j++)
                    {
                        Console.Write(" [");
                        for (int i = 0; i < rowSize; i++)
                        {
                            Console.Write(solutionMatrix[i, j] + ",");
                        }
                        Console.Write("] ");
                         //Console.WriteLine("");
                    }
                    Console.WriteLine("");

                    Console.WriteLine(" ");
                    for (int i = 0; i < rowSize; i++)
                    {
                        Console.Write("  ");
                        for (int j = 0; j < columSize; j++) 
                        {
                            Console.Write(solutionMatrix[i, j] + " ");
                        }
                        Console.Write(" ");
                        Console.WriteLine("");
                    }
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("Output: " + "false");
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing Stones()");
            }
        }
    }
}
