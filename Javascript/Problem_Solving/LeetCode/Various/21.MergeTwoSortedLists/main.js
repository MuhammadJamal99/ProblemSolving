let ListNode = function (val, next) {
    this.val = (val===undefined ? 0 : val);
    this.next = (next===undefined ? null : next);
}
let mergeTwoLists = function(list1, list2) {
    if(list1 == null)
        return list2;
    if(list2 == null)
        return list1;
    if(list1.val <= list2.val)
    {
        list1.next = mergeTwoLists(list1.next, list2);
        return list1;
    }
    else 
    {
        list2.next = mergeTwoLists(list1, list2.next);
        return list2;
    }
};
let list1 = new ListNode(1);
list1.next = new ListNode(2);
list1.next.next = new ListNode(4);
let list2 = new ListNode(1);
list2.next = new ListNode(3);
list2.next.next = new ListNode(4);
console.log(mergeTwoLists(list1,list2));