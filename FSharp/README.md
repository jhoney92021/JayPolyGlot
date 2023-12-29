# jhoney's FSharp notes

### Quick Links

- [Home](../README.md)

### Random Notes
> All "variables" are imutable by default
    the documentation therefor refers to them as ["Values"](https://learn.microsoft.com/en-us/dotnet/fsharp/language-reference/values/)
    the `mutable` keyword allows. 
    Correspondingly when you need to acutally change the [Value](https://learn.microsoft.com/en-us/dotnet/fsharp/language-reference/values/) you need to use the `<-` operator a short example

```fsharp
let mutable number = 0
number <- 1
```

> In that example this is a literal reasignment from 0 to 1.
    If you want to something like a `i++`, then you need to 
    do soething more like.

```fsharp
let mutable number = 0
number <- number + 1
```
