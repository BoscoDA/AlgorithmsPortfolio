## Week 2 - Big O

This weeks assignmented required implenting methods that illustrate my understanding of three big-O time complexities:
  1. Constant Time: O(1)
  2. Linear Time: O(n)
  3. Quadratic time: O(n^2)

The methods exemplifying each of these can be found in the Algorithms library in the project in BigOExamples

BigOConstantTime(): This method illustrates constant time: O(1). The size of an input does not effect the time in which it will run. 
It will always just require one step.


BigOLinearTime(): This method illustrates linear time because the rate at which the output grows is linear in relation to the size of n, 
the input of the method. Meaning as the input grows, the algorithm takes proportionally longer to complete. n can represent both the size
of a structure being inputted or the number itself being intputted.

BigOQuadraticTime(): This method illustrates quadratic time because the rate at which the ouput grows is n * n (n^2) because of the nest for loops.
For each time that the first loop iterates it must then go through 0..n in the inner loop causing a quadratic relationship.
