class Solution {
  /**
   * @param {number[]} nums
   * @param {number} k
   * @return {number[]}
   */
  topKFrequent(nums, k) {
    let countedNums = {}
    
    for (let num of nums) {
      if (!countedNums[num])
        countedNums[num] = 0

      countedNums[num]++
    }

    let buckets = []
    for (let i = 0; i < nums.length + 1; i++) {
      buckets[i] = []
    }
    for (const [num, occ] of Object.entries(countedNums)) {
      buckets[occ].push(Number(num))
    }

    let result = []
    for (let i = buckets.length - 1; i >= 0 && result.length < k; i--) {
      for (const item of buckets[i])
        result.push(item)
    }

    return result
  }
}
