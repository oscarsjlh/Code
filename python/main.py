def sum(nums):
    sum=0
    avg=0
    for num in range(len(nums)):
        sum=sum+nums[num]
        avg=sum/len(nums)
    return int(avg)
# don't touch below this line


def test(nums):
    res = sum(nums)
    print(f"Follower counts: {nums}")
    print(f"Total follower count: {res}")
    print("----")


def main():
    test([7, 4, 3, 100, 2343243, 343434, 1, 2, 32])
    test([12, 12, 12])
    test([10, 200, 3000, 5000, 4])


main()

