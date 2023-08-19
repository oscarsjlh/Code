def median_followers(nums):
    ln = len(nums)
    if (ln % 2) == 0:
        median = ln % 2
    else:
        n1 = ln % 2
        n2 = (ln + 2) % 2

        pre = (n1+n2) % 2
        median = pre % 2


    slist = sorted(nums)
    print(slist)
    print(median)
    return slist[int(median)]


# don't touch below this line


def test(nums):
    res = round(median_followers(nums))
    print(f"Follower counts: {nums}")
    print(f"Median follower count: {res}")
    print("----")


def main():
    test([7, 4, 3, 100, 2343243, 343434, 1, 2, 32])
    test([12, 12, 12])
    test([10, 200, 3000, 5000, 4])
    test([10, 200, 3000, 5000, 4, 6])


main()

