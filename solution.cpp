```cpp
#include <iostream>
#include <vector>
#include <algorithm>

using namespace std;

int findMaximumXOR(vector<int>& nums) {
    int max = 0, mask = 0;
    for (int i = 31; i >= 0; i--) {
        mask = mask | (1 << i);
        set<int> set;
        for (int num : nums) {
            set.insert(num & mask);
        }
        int tmp = max | (1 << i);
        for (int prefix : set) {
            if (set.find(tmp ^ prefix) != set.end()) {
                max = tmp;
                break;
            }
        }
    }
    return max;
}

int main() {
    vector<int> nums;
    int n, temp;
    cout << "Enter the number of elements: ";
    cin >> n;
    cout << "Enter the elements: ";
    for (int i = 0; i < n; i++) {
        cin >> temp;
        nums.push_back(temp);
    }
    cout << "Maximum XOR is: " << findMaximumXOR(nums) << endl;
    return 0;
}
```