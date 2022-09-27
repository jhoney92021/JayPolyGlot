//  Write a function that would iterate through 
//  each item of the given integer array and 
//  print each value to the console. 

export function For(numberArray)
{
    let sum = 0;
    for(var iterator = 0; iterator < numberArray.length - 1; iterator++)
    {
        sum += iterator;        
        console.log(`For Array: ${numberArray[iterator]}`);
    }
}

export function ForIn(numberArray)
{
    for(let number in numberArray)
    {     
        console.log(`For In Array: ${numberArray[number]}`);
    }    
}

export function ForOf(numberArray)
{
    for(let number of numberArray)
    {
        console.log(`For Of Array: ${number}`);     
    }    
}

export function While(numberArray)
{
    let iterator = 0;
    while(iterator < numberArray.length)
    {
        console.log(`While Array: ${numberArray[iterator]}`);
        iterator++;
    }
}

export function DoWhile(numberArray)
{
    let iterator = 0;    
    do{
        console.log(`Do While Array: ${numberArray[iterator]}`);        
        iterator++;
    }    
    while(iterator < numberArray.length)
}