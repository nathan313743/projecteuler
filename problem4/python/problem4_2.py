#!/usr/bin/env python3
import unittest
import time

# Second attempt. No need to convert to string.
class PalindromeTest(unittest.TestCase):

    def setUp(self):
        self.palindrome = Palindrome()

    def test_get_palindrome_improved(self):
        start_time = time.time()
        self.assertEqual(906609, self.palindrome.get_longest_palindrome())
        print(time.time() - start_time)


class Palindrome:

    def reverse(self, number):
        reversed_num = 0
        while number > 0:
            reversed_num = 10 * reversed_num + number % 10
            number = number // 10
        return reversed_num


    def get_longest_palindrome(self):
        largest = 0
        for i in range(100, 1000):
            for j in range(i, 1000):
                product = i * j
                if product < largest:
                    continue
                reversed_num = self.reverse(product)
                if product == reversed_num and product > largest:
                    largest = product
        return largest


if __name__ == '__main__':
    unittest.main()
