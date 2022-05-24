let GetUniqueNum = function(arr)
{
	let Unique = -1;
	MainLoop: for(let i = 0; i < arr.length; i++){
		if(!arr.slice(i + 1,arr.length).includes(arr[i]))
			Unique = arr[i];
		else
			continue MainLoop;
	}
	return Unique;
};
let arr = [1,2,3,4,5,1,2,4,5];//3
let arr2 = [1,2,5,6,1,2,5,6,7];//7
let arr3 = [1,1,1,1,1,1,1,1,1];//-1
console.log(GetUniqueNum(arr));//3
console.log(GetUniqueNum(arr2));//3
console.log(GetUniqueNum(arr3));//3