import {List} from "./LinkedList"
import { LinkedListNode } from "./LinkedListNode";
import * as Utils from '../Utils';

export class LinkedList<T> implements Iterable<T> {
    private List: List<T> | undefined
    
    constructor() {
        this.List = undefined;
    }

    GetSize():number 
    {
        if(this.List)
            return this.List.size;
        else
            return 0;
    };

    IsEmpty(): boolean
    {
        return !this.List;
    };

    AddToFront(val: T): void 
    {
        const NewNode = new LinkedListNode(val);
        if(!this.IsEmpty())
        {
            this.List.head.prev = NewNode;
            NewNode.next = this.List.head;
            this.List.head = NewNode;
            this.List.size += 1;
        }
        else
        {
            this.List = {
                head:NewNode,
                tail:NewNode,
                size: 1
            }
        }
    };

    AddToBack(val: T):void 
    { 
        const NewNode = new LinkedListNode(val);
        if(!this.IsEmpty())
        {
            this.List.tail.next = NewNode;
            NewNode.prev = this.List.tail;
            this.List.tail = NewNode;
            this.List.size += 1;
        }
        else
        {
            this.List = {
                head:NewNode,
                tail:NewNode,
                size: 1
            }
        }
    };

    AddAtIndex(index: number, val: T):void {
        if(index == 0)
        {
            this.AddToFront(val);
            return;
        }
        if(index == this.List.size) 
        {
            this.AddToBack(val);
            return;
        }
        if(index < 0 || index >= this.List.size || !this.List)
        {   
            throw new Error(Utils.OUT_OF_BOUNDS_ERROR);
        }
        const NewNode = new LinkedListNode(val);
        let CurrentNode = this.List.head;
        for(let i = 0; i < index - 1; i++)
        {
            CurrentNode = CurrentNode.next!;
        }

        CurrentNode.next!.prev = NewNode;
        NewNode.next = CurrentNode.next;
        NewNode.prev = CurrentNode;
        CurrentNode.next = NewNode;
        this.List.size += 1;
    };

    GetListHead(): T {
        if(!this.List) throw new Error(Utils.Empty_ERROR);
        else return this.List.head.val;
    };

    GetListTail(): T {
        if(!this.List) throw new Error(Utils.Empty_ERROR);
        else return this.List.tail.val;
    };
    
    GetAtIndex(index: number):T 
    {
        if(index < 0 || index >= this.GetSize() || !this.List)
        {
            throw new Error(Utils.OUT_OF_BOUNDS_ERROR);
        }
        let j = 0,
            CurrentNode = this.List.head;
        while(j < index)
        {
            CurrentNode = CurrentNode.next;
            j++;
        }
        return CurrentNode.val;
    }

    GetIndexOf(val:T , equalsfunction?: Utils.EqualsFunction<T>) : number 
    {
        if(!this.List) return -1;
        const equalsfun = equalsfunction || Utils.defaultEquals;
        let index = 0,
            CurrentNode = this.List.head;
        while(!equalsfun(CurrentNode.val, val))
        {
            CurrentNode = CurrentNode.next!;
            index += 1;
        }
        return index;
    }

    Contains(val:T, equalsfunction?:Utils.EqualsFunction<T>) : boolean 
    {
        const Index = this.GetIndexOf(val, equalsfunction? equalsfunction:undefined);
        return Index !== -1;
    }

    RemoveHead():T 
    {
        if(!this.List)
            throw new Error(Utils.Empty_ERROR);
        const val = this.List.head.val;
        if(this.List.head.next)
        {
            this.List.head.next.prev = null;
            this.List.head = this.List.head.next;
            this.List.size -= 1;
        }
        else 
        {
            this.List = undefined;
        }
        return val;
    }

    RemoveTail():T 
    {
        if(!this.List)
            throw new Error(Utils.Empty_ERROR);
        const val = this.List.tail.val;
        if(this.List.tail.prev)
        {
            this.List.tail.prev.next = null;
            this.List.tail = this.List.tail.prev;
            this.List.size -= 1;
        }
        else 
        {
            this.List = undefined;
        }
        return val;
    }

    RemoveElement(val: T,):T 
    {
        const index = this.GetIndexOf(val);
        if(index === -1) throw new Error(Utils.VALUE_DOES_NOT_EXIST_ERROR);
        else return this.RemoveAtIndex(index);
    }

    RemoveAtIndex(index:number):T 
    {
        if(index == 0)
        {
            return this.RemoveHead();
        }
        if(index == this.GetSize() - 1) 
        {
            return this.RemoveTail();
        }
        if(index < 0 || index >= this.List.size || !this.List)
        {   
            throw new Error(Utils.OUT_OF_BOUNDS_ERROR);
        }

        let j =0,
            CurrentNode = this.List.head;
        while(j < index)
        {
            CurrentNode = CurrentNode.next;
            j++;
        }
        CurrentNode.next.prev = CurrentNode.prev;
        CurrentNode.prev.next = CurrentNode.next;
        this.List.size -= 1;
        return CurrentNode.val;
    }

    Clear():void 
    {
        this.List = undefined;
    }

    FromArray(Array: T[]): LinkedList<T> {
        for(let a of Array)
        {
            this.AddToBack(a);
        }
        return this;
    }

    *[Symbol.iterator]():Iterator<T>
    {
        if(!this.List)
            return
        let CurNode : LinkedListNode<T> | null;
        for(CurNode = this.List.head; CurNode != null; CurNode = CurNode.next) 
        {
            yield CurNode.val;
        }
    }
}