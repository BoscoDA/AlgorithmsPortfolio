# PROG 366 Algorithms Portfolio

This is first and foremost a portfolio  documenting my progress learning algorithms throughout the my fall 2022 semester at Columbia College Chicago. When finished it will be a semi-living library of algorithms and algorithm information for easy to access future use.

## Week 2 - 

This weeks assignmented required implenting methods that illustrate my understanding of three big-O time complexities:
  1. Constant Time: O(1)
  2. Linear Time: O(n)
  3. Quadratic time: O(n^2)

The methods exemplifying each of these can be found in the Algorithms library in the project in BigOExamples
  
## Week 5 - Fisher Yates Shuffle

The Fisher Yates shuffle is algorithm for generating a random unbiased permutation, every permutation is equally likely, of a finite sequence. The original form of the algorithm could be carried out as follows:

  1. Write down the numbers from 1 through N.
  2. Pick a random number k between one and the number of unstruck numbers remaining (inclusive).
  3. Counting from the low end, strike out the kth number not yet struck out, and write it down at the end of a separate list.
  4. Repeat from step 2 until all the numbers have been struck out.
  5. The sequence of numbers written down in step 3 is now a random permutation of the original numbers.
  
If implemented in code it would result in a run time of O(n^2) because each loop in step three it would have to loop through the array counting the entrices to strike out the needed one. To adapt this algorithm to computers the striking out of entrices was changed to moving the struck entrices to the end of the array by swapping them with the last unstruck number. This modern implementation of the Fisher Yates Shuffle, also know as the Knuth Shuffle is implemented below as extension methods in C#:
      
```cs
    public static void DoFisherYatesShuffle(this object[] objects)
        {
            for(int i = objects.Length-1; i > 0; i--)
            {
                //j is a random index chosen from the unsorted side of the array. this length is represented by i
                int j = GetRandNumBetweenZeroAnd(i);
                //operating on the array in place allows for the time complexity to be O(n), n being the size of the input array
                objects.SwapValuesAtIndices(i, j);
            }
        }
        
    private static int GetRandNumBetweenZeroAnd(int i)
        {
            return randNum.Next(i + 1);
        }
        
    public static void SwapValuesAtIndices(this object[] objects, int i, int j)
        {
            object temp = objects[i];
            objects[i] = objects[j];
            objects[j] = temp;
        }
```

An example of the Fisher Yates shuffle in the context of a simple console application which generates a deck of cards and them shuffles was also completed for this week.

[Example Application](https://github.com/BoscoDA/AlgorithmsPortfolio/tree/master/FisherYatesCardShuffle "Named link title")



  
