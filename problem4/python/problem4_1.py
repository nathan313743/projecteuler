#!/usr/bin/env python3
import unittest
import time

# First atempt using strings
class PalindromeTest(unittest.TestCase):

    def setUp(self):
        self.palindrome = Palindrome()

    def test_get_palindrome(self):
        start_time = time.time()
        self.assertEqual(906609, self.palindrome.get_longest_palindrome())
        print(time.time() - start_time)

class Palindrome:

    def get_pair(self, number):
        text = str(number)
        pivot = len(text) // 2
        left = text[:pivot]

        if len(text) % 2 != 0:
            pivot += 1

        right = text[pivot:]
        return (int(left), int(right[::-1]))

    def get_longest_palindrome(self):
        largest = 0
        for i in range(100, 1000):
            for j in range(i, 1000):
                product = i * j
                left, right = self.get_pair(product)
                if left == right and product > largest:
                    largest = product
        return largest


if __name__ == '__main__':
    unittest.main()
