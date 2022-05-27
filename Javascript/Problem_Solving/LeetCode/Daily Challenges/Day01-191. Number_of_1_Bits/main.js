//console.log(("str1,str2,str3,str4".match(new RegExp("str", "g")) || []).length);
let HammingWeight = function(num){
    return ((num >>> 0).toString(2).match(new RegExp("1","g")) || []).length;
};