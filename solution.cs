Here is a JavaScript solution for the problem:

```javascript
function findMaxXOR(arr) {
    let max = 0, mask = 0;
    for (let i = 31; i >= 0; i--) {
        mask = mask | (1 << i);
        let set = new Set();
        for (let num of arr) {
            set.add(num & mask);
        }
        let temp = max | (1 << i);
        for (let prefix of set) {
            if (set.has(temp ^ prefix)) {
                max = temp;
                break;
            }
        }
    }
    return max;
}

let arr = [3, 10, 5, 25, 2, 8];
console.log(findMaxXOR(arr));
```

This console application can be run in a Node.js environment. It finds the maximum XOR of two numbers in an array. The `findMaxXOR` function takes an array of numbers as input and returns the maximum XOR value. The array `[3, 10, 5, 25, 2, 8]` is used as an example here, and the result will be printed to the console.