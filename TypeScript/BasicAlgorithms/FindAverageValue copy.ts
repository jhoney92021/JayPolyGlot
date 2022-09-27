/* 
* Write a function that takes an integer array and prints the AVERAGE of the values in the array.
* For example, with an array [2, 10, 3], your program should write 5 to the console.
*/

export function For(numberArray: Array<number>)
{
    let sum: number = 0;
    for(var iterator: number = 0; iterator < numberArray.length; iterator++)
    {
        const number: number = numberArray[iterator];        
        sum += number;        
    }
    const total: number = numberArray.length;
    const average: number = sum/total;
    console.log(`For average of ${numberArray}: ${average}`);
}

export function ForIn(numberArray: Array<number>)
{    
    let sum: number = 0;
    for(let iterator in numberArray)
    {
        const number: number = numberArray[iterator];
        sum += number;
    }
    const total: number = numberArray.length;
    const average: number = sum/total;
    console.log(`For In average of ${numberArray}: ${average}`);
}

export function ForOf(numberArray: Array<number>)
{    
    let sum: number = 0;
    for(let number of numberArray)
    {
        sum += number;
    }
    const total: number = numberArray.length;
    const average: number = sum/total;
    console.log(`For Of average of ${numberArray}: ${average}`);    
}

export function While(numberArray: Array<number>)
{
    let iterator: number = 0;
    let sum: number = 0;
    while(iterator < numberArray.length)
    {
        const number = numberArray[iterator];
        sum += number;
        iterator++;
    }    
    const total: number = numberArray.length;
    const average: number = sum/total;
    console.log(`While average of ${numberArray}: ${average}`);     
}

export function DoWhile(numberArray: Array<number>)
{
    let iterator: number = 0;
    let sum: number = 0;
    do{        
        const number = numberArray[iterator];       
        sum += number;
        iterator++;
    }    
    while(iterator < numberArray.length)
    const total: number = numberArray.length;
    const average: number = sum/total;
    console.log(`Do While average of ${numberArray}: ${average}`);     
}