# Codility-CountDistinctSlices
An integer M and a non-empty array A consisting of N non-negative integers are given.</br> 
All integers in array A are less than or equal to M.</br>
A pair of integers (P, Q), such that 0 ≤ P ≤ Q < N, is called a slice of array A.</br> 
The slice consists of the elements A[P], A[P + 1], ..., A[Q].</br> 
A distinct slice is a slice consisting of only unique numbers.</br> 
That is, no individual number occurs more than once in the slice.

For example, consider integer M = 6 and array A such that:</br>
A[0] = 3</br>
A[1] = 4</br>
A[2] = 5</br>
A[3] = 5</br>
A[4] = 2</br>
There are exactly nine distinct slices: (0, 0), (0, 1), (0, 2), (1, 1), (1, 2), (2, 2), (3, 3), (3, 4) and (4, 4).</br>
The goal is to calculate the number of distinct slices.

Write a function:</br>
class Solution { public int solution(int M, int[] A); }</br>
that, given an integer M and a non-empty array A consisting of N integers, returns the number of distinct slices.</br>
If the number of distinct slices is greater than 1,000,000,000, the function should return 1,000,000,000.

For example, given integer M = 6 and array A such that:</br>
A[0] = 3</br>
A[1] = 4</br>
A[2] = 5</br>
A[3] = 5</br>
A[4] = 2</br>
the function should return 9, as explained above.

Write an efficient algorithm for the following assumptions:</br>
N is an integer within the range [1..100,000];</br>
M is an integer within the range [0..100,000];</br>
each element of array A is an integer within the range [0..M].
