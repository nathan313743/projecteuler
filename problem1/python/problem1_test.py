import unittest
from problem1 import Problem1

class Problem1Test(unittest.TestCase):
    def setUp(self):
        self.problem1 = Problem1()

    def test_sum_amount_10(self):
        sum = self.problem1.get_sum([3,5], 10)
        self.assertEqual(23, sum)

    def test_sum_amount_1000(self):
        sum = self.problem1.get_sum([3,5], 1000)
        self.assertEqual(233168, sum)
