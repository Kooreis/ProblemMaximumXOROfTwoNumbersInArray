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