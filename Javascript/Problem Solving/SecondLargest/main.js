let GetSecoundLargestInArray = function(arr) {
    let largest = 0,
        secoundLargest = 0;
    if(arr.length == 0)
        return -1;
    else
    {
        MainLoop: for(let i = 0; i < arr.length; i++)
        {
            if(arr[i] > largest)
            {
                secoundLargest = largest;
                largest = arr[i];
            }
            else if(arr[i] > secoundLargest)
            {
                if(arr[i] == largest)
                    continue MainLoop;
                else
                    secoundLargest = arr[i];
            }
        }
        return secoundLargest === 0 ? -1 : secoundLargest;
    }
};
console.log(GetSecoundLargestInArray([1,5,7,7,8,8,9]));
// 8
console.log(GetSecoundLargestInArray([100,51,71,77,78,82,19]));
// 82
console.log(GetSecoundLargestInArray([5,5,5,5,5,5,5]));
// -1
console.log(GetSecoundLargestInArray([-6,-4,-1,-5]));
// -4
console.log(-6 > 0);
//[2,4,6,8]