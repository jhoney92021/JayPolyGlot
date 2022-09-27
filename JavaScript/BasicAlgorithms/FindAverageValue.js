/* 
* Write a function that takes an integer array and prints the AVERAGE of the values in the array.
* For example, with an array [2, 10, 3], your program should write 5 to the console.
*/

export function For(numberArray)
{
    let sum = 0;
    for(var iterator = 0; iterator < numberArray.length; iterator++)
    {
        const number = numberArray[iterator];        
        sum += number;        
    }
    const total = numberArray.length;
    const average = sum/total;
    console.log(`For average of ${numberArray}: ${average}`);
}

export function ForIn(numberArray)
{    
    let sum = 0;
    for(let iterator in numberArray)
    {
        const number = numberArray[iterator];
        sum += number;
    }
    const total = numberArray.length;
    const average = sum/total;
    console.log(`For In average of ${numberArray}: ${average}`);
}

export function ForOf(numberArray)
{    
    let sum = 0;
    for(let number of numberArray)
    {
        sum += number;
    }
    const total = numberArray.length;
    const average = sum/total;
    console.log(`For Of average of ${numberArray}: ${average}`);    
}

export function While(numberArray)
{
    let iterator = 0;
    let sum = 0;
    while(iterator < numberArray.length)
    {
        const number = numberArray[iterator];
        sum += number;
        iterator++;
    }    
    const total = numberArray.length;
    const average = sum/total;
    console.log(`While average of ${numberArray}: ${average}`);     
}

export function DoWhile(numberArray)
{
    let iterator = 0;
    let sum = 0;
    do{        
        const number = numberArray[iterator];       
        sum += number;
        iterator++;
    }    
    while(iterator < numberArray.length)
    const total = numberArray.length;
    const average = sum/total;
    console.log(`Do While average of ${numberArray}: ${average}`);     
}