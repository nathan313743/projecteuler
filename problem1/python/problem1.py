class Problem1:
    def is_multiple(self, factors, number):
        is_multiple = False
        for i in range(0, len(factors)):
            if number % factors[i] == 0:
                is_multiple = True
                break
        return is_multiple

    def get_sum(self, factors, limit):
        sum = 0
        for num in range(0, limit):
             if self.is_multiple(factors, num):
                 sum += num
        return sum