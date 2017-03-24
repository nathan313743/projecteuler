class Problem1:
    def is_multiple(self, factors, number):
        is_multiple = False
        for i in range(0, len(factors)):
            if number % factors[i] == 0:
                is_multiple = True
                break
        return is_multiple
        
    def get_sum(self, factors, limit):
        sum = 0;
        for num in range(0, limit):
             if self.is_multiple(factors, num):
                 sum += num
        return sum

problem = Problem1()          
sum = problem.get_sum([3,5], 1000)
print(sum)
