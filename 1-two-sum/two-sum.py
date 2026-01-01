class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        sum ={}

        for idx in range(len(nums)):
            current = target - nums[idx]
            if current in sum:
                return [sum[current], idx]
            sum[nums[idx]] = idx

        return []

        