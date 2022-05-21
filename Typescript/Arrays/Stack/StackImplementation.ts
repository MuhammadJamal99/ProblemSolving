import { LinkedList } from "../LinkedList/LinkedListImplementation"
import * as Utils from '../Utils';
export class Stack<T> implements Iterable<T> {
    private Stack : LinkedList<T>;

    constructor() {
        this.Stack = new LinkedList();
    }

    GetSize() : number {
        return this.Stack.GetSize();
    }

    IsEmpty() : boolean {
        return this.Stack.IsEmpty();
    }

    Clear() : void {
        return this.Stack.Clear();
    }

    Push(Element : T) : void {
        this.Stack.AddToFront(Element);
    }

    Pop() : T {
        return this.Stack.RemoveHead();
    }

    Peek() : T {
        return this.Stack.GetListHead();
    }

    Contains(val : T, equalsfunction? : Utils.EqualsFunction<T>) : boolean 
    {
        return this.Stack.Contains(val, equalsfunction ? equalsfunction : undefined);
    }

    *[Symbol.iterator]() : Iterator<T>
    {
        return this.Stack[Symbol.iterator]();
    }
}
