import { LinkedList } from "../LinkedList/LinkedListImplementation"
import * as Utils from '../Utils';
export class Queue<T> implements Iterable<T> {
    private Queue : LinkedList<T>;

    constructor(equalsfunction? : Utils.EqualsFunction<T>) {
        this.Queue = new LinkedList();
    }

    GetSize() : number {
        return this.Queue.GetSize();
    }

    IsEmpty() : boolean {
        return this.Queue.IsEmpty();
    }

    Clear() : void {
        return this.Queue.Clear();
    }

    Enqueue(Element : T) : void {
        this.Queue.AddToBack(Element);
    }

    Dequeue() : T {
        return this.Queue.RemoveHead();
    }

    PeakFront() : T {
        return this.Queue.GetListHead();
    }

    PeekBack() : T {
        return this.Queue.GetListTail();
    }

    Contains(val : T, equalsfunction? : Utils.EqualsFunction<T>) : boolean 
    {
        return this.Queue.Contains(val, equalsfunction ? equalsfunction : undefined);
    }


    *[Symbol.iterator]() : Iterator<T>
    {
        return this.Queue[Symbol.iterator]();
    }
}