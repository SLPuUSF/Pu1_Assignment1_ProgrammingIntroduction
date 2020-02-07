using System;

namespace Pu1_Assignment1ProgrammingIntroduction
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Question 1");
            //int n = 5;
            //PrintPattern(n);

            //Console.WriteLine("question 2");
            //int n2 = 6;
            //printseries(n2);


            //Console.WriteLine("question 3");
            //string s = "09:15:35pm";
            //string t = usftime(s);
            //Console.WriteLine(t);


            //Console.WriteLine("question 4");
            //int n3 = 110;
            //int k = 11;
            //usfnumbers(n3, k);

            //Console.WriteLine();
            //Console.WriteLine("Question 5");
            //string[] words = new string[] { "abcd", "dcba", "lls", "s", "sssll" };
            //Palindromepairs(words);

            Console.WriteLine();
            Console.WriteLine("Question 6");
            int n4 = 7;
            Stones(n4);

        }


        // question 1:
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

        // question 2:
        private static void printseries(int n2)
        {
            try
            {
                int size = n2; // there are n2 type combinations.
                int[] sumArray = new int[size]; // create an array to store sums.

                for (int itemIndex = 0; itemIndex < n2; itemIndex++) // go into items of sumArray one by one and store sum.
                {
                    int sum = 0;

                    for (int Num = 1; Num <= itemIndex + 1; Num++) // caculate sum of each combination.
                                                                   // each combination includes numbers from 1 to (itemIndex + 1)
                    { 
                        sum = sum + Num; 
                    }
                    sumArray[itemIndex] = sum;
                }
                Console.WriteLine(string.Join(",", sumArray));

                ////write your code here .!!
                //int size = n2;
                //double[] seriesarray = new double[size];
                //for (int count = 1; count <= n2; count++)
                //{
                //    seriesarray[count - 1] = (1 + count) * count / 2;
                //}

                //Console.WriteLine(string.Join(",", seriesarray));
                //Console.WriteLine();
            }
            catch
            {
                Console.WriteLine("exception occured while computing printseries");
            }
        }

        // question 3:
        public static string usftime(string s)
        {
            try
            {

                // earth date input
                Console.WriteLine("enter the date of earth with the format of hh:mm:ssam or hh:mm:sspm: ");
                string earthdateinput = Console.ReadLine();
                DateTime dateofearth = Convert.ToDateTime(earthdateinput);

                // calculateions
                int enteredhours = dateofearth.Hour;
                int enteredminutes = dateofearth.Minute;
                int enteredseconds = dateofearth.Second;

                //var enteredispm = (dateofearth.hour >= 12);

                /*int enteredispm = 0;
                if (dateofearth.hour >= 12)
                    enteredispm = 1;
                else
                    enteredispm = 0;
               */
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


        // question 4:
        /*n- total number of integers( 110 )
         * k-number of numbers per line ( 11)
         * usf numbers : this method prints the numbers 1 to 110, 11 numbers per line.
         * the method shall print 'u' in place of numbers which are multiple of 3,"s" for 
         * multiples of 5,"f" for multiples of 7, 'us' in place of numbers which are multiple 
         * of 3 and 5,'sf' in place of numbers which are multiple of 5 and 7 and so on. 
         * the output shall look like 
         * 1 2 u 4 s u f 8 u s 11 
         * u 13 f us 16 17 u 19 s uf 22
         * 23 u s 26 u f 29 us 31 32 u....
         * 
         * returns      : n/a
         * return type  : void
         */

        public static void usfnumbers(int n3, int k)
        {
            try
            {
                // write your code here
                Console.WriteLine("select the numbers 1 to 110, 11 numbers per line.");
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
        /*You are given a list of unique words, the task is to find all the pairs of 
         distinct indices (i,j) in the given list such that, the concatenation of two
         words i.e. words[i]+words[j] is a palindrome.
         Example:
         Input: ["abcd","dcba","lls","s","sssll"]
         Output: [[0,1],[1,0],[3,2],[2,4]] 
         Explanation: The palindromes are ["dcbaabcd","abcddcba","slls","llssssll"]
         Example:
         Input: ["bat","tab","cat"]
         Output: [[0,1],[1,0]] 
         Explanation: The palindromes are ["battab","tabbat"]
          
         returns      : N/A
         return type  : void
         */

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
                        Console.WriteLine("Resort: " + resortWords);
                        

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
                        string resortWords = new string(resortCharsArray);

                        // Display the results.
                        //Console.WriteLine("Resort: " + resortWords);


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
        /*
         You are playing a stone game with one of your friends. There are N number of 
         stones in a bag, each time one of you take turns to take out 1 to 3 stones. 
         The player who takes out the last stone will be the winner. In this case you
         will be the first player to remove the stone(s)(Player 1).
          
         Write a method to determine whether you can win the game given the number of 
         stones in the bag. Print false if you cannot win the game, otherwise print any
         one set of moves where you are winning the game. Array should contain moves by
         both the players.

         *Input: 4
         Output: false
         Explanation: As there are 4 stones in the bag, you will never win the game. 
         No matter 1,2 or 3 stones you take out, the last stone will always be removed by   
         your friend.

         *Input: 5
         Output: [1,1,3]   or [1,2,2] or [1,3,1]
         Player 1 picks up 1 stone then player 2 picks up 1 or 2 or 3 stones and the  
         remaining stones are picked up by player 1.
         Explanation: As there are 5 stones in the bag, you take out one stone.
         As there are 4 stones in the bag and it’s your friend’s turn. He will never win 
         the game because no matter 1,2 or 3 stones he takes out, you will the one to take 
         out the last stone.
          
            returns      : N/A
            return type  : void
         */

        public static void Stones(int n4)
        {
            try
            {
                // Write your code here

            }
            catch
            {
                Console.WriteLine("Exception occured while computing Stones()");
            }
        }

    }
}
