#!/usr/bin/env python3
import unittest

class PrimeFactorTest(unittest.TestCase):
    
    def setUp(self):
        self.prime_factor = PrimeFactor()
    
    def test_is_prime_number_true(self):
        self.assertTrue(self.prime_factor.is_prime_number(2))
        self.assertTrue(self.prime_factor.is_prime_number(3))
        self.assertTrue(self.prime_factor.is_prime_number(5))
        self.assertTrue(self.prime_factor.is_prime_number(7))
        self.assertTrue(self.prime_factor.is_prime_number(11))
        
    def test_is_prime_number_false(self):
        self.assertFalse(self.prime_factor.is_prime_number(4))
        self.assertFalse(self.prime_factor.is_prime_number(6))
        self.assertFalse(self.prime_factor.is_prime_number(8))
        self.assertFalse(self.prime_factor.is_prime_number(9))
        self.assertFalse(self.prime_factor.is_prime_number(10))
        
class PrimeFactor:
    def is_prime_number(self, n):
        if n < 2:
            return false
        i = 2

        while(i * i <= n):
            if n % i == 0:
                return False
            i += 1
        return True

if __name__ == '__main__':
    unittest.main()