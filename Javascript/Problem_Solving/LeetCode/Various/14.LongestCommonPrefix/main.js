let longestCommonPrefix = function(strs)
{
    if(strs.length == 0)
        return "";
    else
    {
        let perfix = strs[0];
        for(let i = 0; i < strs.length;i++){
            while(strs[i].indexOf(perfix) != 0)
                perfix = perfix.substring(0, perfix.length - 1);
        }
        return perfix;
    }
};
console.log(longestCommonPrefix(["flower","flow","flight"]));
console.log(longestCommonPrefix(["dog","racecar","car"]));
console.log(longestCommonPrefix([]));