# Problem 3

The prime factors of 13195 are 5, 7, 13 and 29.

What is the largest prime factor of the number 600851475143 ?


Notes:
https://stackoverflow.com/questions/5811151/why-do-we-check-up-to-the-square-root-of-a-prime-number-to-determine-if-it-is-pr
https://stackoverflow.com/questions/12025378/project-euler-3-takes-forever-in-java


If a number n is not a prime, it can be factored into two factors a and b:

n = a*b

If both a and b were greater than the square root of n, a*b would be greater than n. 
So at least one of those factors must be less than or equal to the square root of n, 
and to check if n is prime, we only need to test for factors less than or equal to the square root.

In the end, I decided to remove the brute force approach in favour of Prime Factorization - which is more succinct (and works).
http://www.mathsisfun.com/prime-factorization.html