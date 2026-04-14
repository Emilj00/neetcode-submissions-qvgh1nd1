class Solution {
  /**
   * @param {string} firstWord
   * @param {string} secondWord
   * @return {boolean}
   */
  isAnagram(firstWord, secondWord) {
    if (firstWord.length != secondWord.length)
      return false

    let firstWordFequencies = {}
    for (const c of firstWord) {
      if (!(c in firstWordFequencies)) {
        firstWordFequencies[c] = 1
        continue
      }

      firstWordFequencies[c]++
    }

    let secondWordFrequencies = {}
    for (const c of secondWord) {
      if (!(c in secondWordFrequencies)) {
        secondWordFrequencies[c] = 1
        continue
      }

      secondWordFrequencies[c]++
    }
  
    return this.areEqual(firstWordFequencies, secondWordFrequencies)
  }

  areEqual(freq1, freq2) {
    const keys1 = Object.keys(freq1)
    const keys2 = Object.keys(freq2)

    if (keys1.length !== keys2.length)
      return false

    for (const key of keys1) {
      if (freq1[key] !== freq2[key])
        return false
    }

    return true
  }
}
