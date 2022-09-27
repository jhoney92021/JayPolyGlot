/* 
* Write a function that takes an integer array "numbers", and then multiplies each value by itself.
* For example, [1,5,10,-10] should become [1,25,100,100]
*/


export function For(numberArray: Array<number>)
{
    let newArray: Array<number> = new Array<number>();
    for(var iterator: number = 0; iterator < numberArray.length; iterator++)
    {
        const number: number = numberArray[iterator];        
        newArray.push(number*number);        
    }    
    console.log(`For Square Array Old: ${numberArray} New: ${newArray}`);
}

export function ForIn(numberArray: Array<number>)
{    
    let newArray: Array<number> = new Array<number>();
    for(let iterator in numberArray)
    {
        const number: number = numberArray[iterator];
        newArray.push(number*number);
    }
    console.log(`For In Square Array Old: ${numberArray} New: ${newArray}`);
}

export function ForOf(numberArray: Array<number>)
{    
    let newArray: Array<number> = new Array<number>();
    for(let number of numberArray)
    {
        newArray.push(number*number);
    }
    console.log(`For Of Square Array Old: ${numberArray} New: ${newArray}`); 
}

export function While(numberArray: Array<number>)
{
    let iterator: number = 0;
    let newArray: Array<number> = new Array<number>();
    while(iterator < numberArray.length)
    {
        const number = numberArray[iterator];
        newArray.push(number*number);
        iterator++;
    }    
    console.log(`While Square Array Old: ${numberArray} New: ${newArray}`); 
}

export function DoWhile(numberArray: Array<number>)
{
    let iterator: number = 0;
    let newArray: Array<number> = new Array<number>();
    do{        
        const number = numberArray[iterator];       
        newArray.push(number*number);
        iterator++;
    }    
    while(iterator < numberArray.length)
    console.log(`Do While Square Array Old: ${numberArray} New: ${newArray}`); 
}