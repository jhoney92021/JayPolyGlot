/* 
* Write a function that creates, and then returns
* 
* an array that contains all the odd numbers 
* of a given array. 
* 
* When the program is done, 
* ex: [1, 12, 3, 4, 6]
* output: [1, 3]
*/


export function For(numberArray: Array<number>)
{
    let newArray: Array<number> = new Array<number>();
    for(var iterator: number = 0; iterator < numberArray.length; iterator++)
    {
        const number: number = numberArray[iterator];        
        if(number % 2 === 1)
        {
            newArray.push(number);
        }
    }    
    console.log(`For Odd Array Old: ${numberArray} New: ${newArray}`);
}

export function ForIn(numberArray: Array<number>)
{    
    let newArray: Array<number> = new Array<number>();
    for(let iterator in numberArray)
    {
        const number: number = numberArray[iterator];
        if(number % 2 === 1)
        {
            newArray.push(number);
        }
    }
    console.log(`For In Odd Array Old: ${numberArray} New: ${newArray}`);
}

export function ForOf(numberArray: Array<number>)
{    
    let newArray: Array<number> = new Array<number>();
    for(let number of numberArray)
    {
        if(number % 2 === 1)
        {
            newArray.push(number);
        }
    }
    console.log(`For Of Odd Array Old: ${numberArray} New: ${newArray}`); 
}

export function While(numberArray: Array<number>)
{
    let iterator: number = 0;
    let newArray: Array<number> = new Array<number>();
    while(iterator < numberArray.length)
    {
        const number = numberArray[iterator];
        if(number % 2 === 1)
        {
            newArray.push(number);
        }
        iterator++;
    }    
    console.log(`While Odd Array Old: ${numberArray} New: ${newArray}`); 
}

export function DoWhile(numberArray: Array<number>)
{
    let iterator: number = 0;
    let newArray: Array<number> = new Array<number>();
    do{        
        const number = numberArray[iterator];       
        if(number % 2 === 1)
        {
            newArray.push(number);
        }
        iterator++;
    }    
    while(iterator < numberArray.length)
    console.log(`Do While Odd Array Old: ${numberArray} New: ${newArray}`); 
}