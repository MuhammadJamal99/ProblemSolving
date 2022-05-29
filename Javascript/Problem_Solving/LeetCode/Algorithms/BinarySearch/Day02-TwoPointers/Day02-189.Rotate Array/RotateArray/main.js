let rotateArray = function(nums,k){
    let n = nums.length
    k = k%n;
    let ary = nums.slice(n-k);
    nums.unshift(...ary);
    nums.length = n;
    return nums;
};
console.log(rotateArray([1,2,3,4,5,6,7], 3));
console.log(rotateArray([-1, -100, 3, 99], 2));