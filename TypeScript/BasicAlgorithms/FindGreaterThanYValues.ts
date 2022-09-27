/* 
* Write a function that takes an integer array, and a integer "y" and returns the number of array values 
* That are greater than the "y" value. 
* For example, if array = [1, 3, 5, 7] and y = 3. Your function should return 2 
* (since there are two values in the array that are greater than 3).
*/


export function For(numberArray: Array<number>, y: number)
{
    let newArray: Array<number> = new Array<number>();
    for(var iterator: number = 0; iterator < numberArray.length; iterator++)
    {
        const number: number = numberArray[iterator];        
        if(number > y)
        {
            newArray.push(number);
        }
    }    
    console.log(`For Greater Than Y Array Old: ${numberArray} New: ${newArray}`);
}

export function ForIn(numberArray: Array<number>, y: number)
{    
    let newArray: Array<number> = new Array<number>();
    for(let iterator in numberArray)
    {
        const number: number = numberArray[iterator];
        if(number > y)
        {
            newArray.push(number);
        }
    }
    console.log(`For In Greater Than Y Array Old: ${numberArray} New: ${newArray}`);
}

export function ForOf(numberArray: Array<number>, y: number)
{    
    let newArray: Array<number> = new Array<number>();
    for(let number of numberArray)
    {
        if(number > y)
        {
            newArray.push(number);
        }
    }
    console.log(`For Of Greater Than Y Array Old: ${numberArray} New: ${newArray}`); 
}

export function While(numberArray: Array<number>, y: number)
{
    let iterator: number = 0;
    let newArray: Array<number> = new Array<number>();
    while(iterator < numberArray.length)
    {
        const number = numberArray[iterator];
        if(number > y)
        {
            newArray.push(number);
        }
        iterator++;
    }    
    console.log(`While Greater Than Y Array Old: ${numberArray} New: ${newArray}`); 
}

export function DoWhile(numberArray: Array<number>, y: number)
{
    let iterator: number = 0;
    let newArray: Array<number> = new Array<number>();
    do{        
        const number = numberArray[iterator];       
        if(number > y)
        {
            newArray.push(number);
        }
        iterator++;
    }    
    while(iterator < numberArray.length)
    console.log(`Do While Greater Than Y Array Old: ${numberArray} New: ${newArray}`); 
}