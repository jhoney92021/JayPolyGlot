module Node
open System
type Node<'T>(index, value: 'T, next) =
    member _.Index: int = index
    member _.Value = value
    member _.Next = next
    