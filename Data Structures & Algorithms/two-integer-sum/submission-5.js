
class Solution {
    /**
     * @param {number[]} nums
     * @param {number} target
     * @return {number[]}
     */
    twoSum(nums, target) {
      let numbers = {}

      for (let i = 0; i < nums.length; i++) {
        const num = nums[i];
        
        numbers[num] = i;
      }

      for (let i = 0; i < nums.length; i++) {
        const toFind = target - nums[i];

        if (!(toFind in numbers)) {
          continue
        }

        const foundIndex = numbers[toFind]
        if (foundIndex == i) {
          continue
        }

        return [i, numbers[toFind]]
      }

      return [0,0]
    }
}
