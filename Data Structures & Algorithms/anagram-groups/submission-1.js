class Solution {
    /**
     * @param {string[]} strs
     * @return {string[][]}
     */
    groupAnagrams(strs) {
      let groups = {}
      // [key: "signature"] = list of string
      
      for (const str of strs) {
        const countedLetters = this.countLetters(str)

        if (!groups[countedLetters]) {
          groups[countedLetters] = []
        }

        groups[countedLetters].push(str)
      } 

      let result = []
      for (const group of Object.values(groups)) {
        result.push(group)
      }

      return result
    }

    countLetters(str) {
      let result = []
      for (let i = 0; i < 26; i++) {
        result.push(0)
      }

      for (let i = 0; i < str.length; i++) {
        const index = str.charCodeAt(i) - 97
        result[index]++;
      }

      console.log(result.join(","))
      return result.join(",")
    }
}