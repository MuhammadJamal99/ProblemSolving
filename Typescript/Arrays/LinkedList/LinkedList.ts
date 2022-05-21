import { LinkedListNode } from "./LinkedListNode";

export interface List<T> {
    head: LinkedListNode<T>,
    tail: LinkedListNode<T>,
    size: number
}