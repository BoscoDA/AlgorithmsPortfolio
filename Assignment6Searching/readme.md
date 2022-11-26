# Searching Algorithms
This week and assignment ultilized common searching algorithms. 
Searching algorithms search for an element in a data structure. 
They are often categorized as either a sequential search or an interval search.
- Sequential: A data structure is traversed sequentially and every element is checked. 
- Interval: Optimized for sorted data-structures, these algorithms can be more efficient.

This week's content and assignment focused on three algorithms, Linear, Binary and Interpolation Search 
and tasked me to implement each of them and use each to search the same data set.

## Linear Search
### Description
Linear search is a sequential search algorithm that iterates through each element
of the data set comparing each element to the target until the 
target is either found or the algorithm reaches the 
end of the data set.
### Asymptotic notation
- Worst Case: O(n) 
- Best Case: O(1) 
- Average: O(n/2)
### Pseudocode
```
Start LinearSearch(array, target)
    for i = 0 to array length
        if array[i] == target
            return i
        i++
    return -1
end LinearSearch
```
## Binary Search
### Description
The Binary search is a interval algorithm and requires a sorted data set.
It starts by calculating a probe, which is always the middle of the set, calculate by probe = (high - low) / 2. 
It then compares the probe, middle index, to the target.
If the values are not equal, the algorithm 
then checks to see which half of the data set will contain 
the target by checking if it is larger or smaller than the target.
This is then recursively or iteratively 
repeated until the target is found or the algorithm 
reachs the end of the data set.
### Asymptotic Notation
- Worst Case: O(logn)
- Best Case: O(1)
- Average: O(logn)
### Pseudocode
```
function binary_search(A, n, T) is
    L := 0
    R := n − 1
    while L ≤ R do
        m := floor((L + R) / 2)
        if A[m] < T then
            L := m + 1
        else if A[m] > T then
            R := m − 1
        else:
            return m
    return unsuccessful
```
## Interpolation Search
### Description
Interpolation Search is a improvement over Binary Search for 
sorted data sets that are uniformally distributed.
Instead of starting a the middle the data set, it
uses the formula for linear interpolation:

y = y1 + ((y2-y1)/(x2-x1))(x-x1)

- x = target (T)
- y = probe 
- y1 = low index (L)
- x1 = array[low index] (a[L])
- y2 = high index (H)
- x2 = array[high index] (a[H])

prode = a[L] + (x-a[L]/a[H]-a[L]) * (H - L)

### Asymptotic Notation
- Worst Case: O(n)
- Best Case: O(1)
- Average Case: O(log log n) 
### Pseudocode
```
being LinearInterpolation(arr[], h, l, t
    probe = a[L] + (x-a[L]/a[H]-a[L]) * (H - L)
    if a[probe] = t
        return probe
    else if a[probe] < t
        return LinearInterpolation(arr[], probe -1, l, t)
    else if a[probe] > t
        return LinearInterpolation(arr[], h, probe + 1, t)
    return -1
```
