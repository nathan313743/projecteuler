#!/usr/bin/env python3
import unittest

class PrimeFactorTest(unittest.TestCase):
    
    def setUp(self):
        self.prime_factor = PrimeFactor()
    
    def test_sum_amount_1000(self):
        self.assertEqual(2, self.prime_factor.largest_prime_factor(2))
        self.assertEqual(5, self.prime_factor.largest_prime_factor(5))
        self.assertEqual(5, self.prime_factor.largest_prime_factor(10))
        self.assertEqual(29, self.prime_factor.largest_prime_factor(13195))
        self.assertEqual(6857, self.prime_factor.largest_prime_factor(600851475143))
        
        # The following takes too long as we cannot reduce the original number
        # self.assertEqual(600851475149, self.prime_factor.largest_prime_factor(600851475149))

class PrimeFactor:
    
    def largest_prime_factor(self, num):
        largest_factor = 1
 
        # remove any factors of 2 first
        while num % 2 == 0:
            largest_factor = 2
            num = num // 2
    
        # now look at odd factors
        divisor = 3
        while num != 1:
            while num % divisor == 0:
                largest_factor = divisor
                num = num // divisor
            divisor += 2
    
        return largest_factor

if __name__ == '__main__':
    unittest.main()
