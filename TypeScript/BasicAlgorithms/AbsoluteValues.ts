/* 
* Given an integer array "numbers", say [1, -5, 10, -2], 
* create a function that replaces any negative number with the positive value. 
* When the program is done, "numbers" should have no negative values, say [1, 5, 10, 2].
*/

export function For(numberArray: Array<number>)
{
    let newArray: Array<number> = new Array<number>();
    for(var iterator: number = 0; iterator < numberArray.length; iterator++)
    {
        const number: number = numberArray[iterator];        
        newArray.push(Math.abs(number));        
    }    
    console.log(`For Negative Array Old: ${numberArray} New: ${newArray}`);
}

export function ForIn(numberArray: Array<number>)
{    
    let newArray: Array<number> = new Array<number>();
    for(let iterator in numberArray)
    {
        const number: number = numberArray[iterator];
        newArray.push(Math.abs(number));
    }
    console.log(`For In Negative Array Old: ${numberArray} New: ${newArray}`);
}

export function ForOf(numberArray: Array<number>)
{    
    let newArray: Array<number> = new Array<number>();
    for(let number of numberArray)
    {
        newArray.push(Math.abs(number));
    }
    console.log(`For Of Negative Array Old: ${numberArray} New: ${newArray}`); 
}

export function While(numberArray: Array<number>)
{
    let iterator: number = 0;
    let newArray: Array<number> = new Array<number>();
    while(iterator < numberArray.length)
    {
        const number = numberArray[iterator];
        newArray.push(Math.abs(number));
        iterator++;
    }    
    console.log(`While Negative Array Old: ${numberArray} New: ${newArray}`); 
}

export function DoWhile(numberArray: Array<number>)
{
    let iterator: number = 0;
    let newArray: Array<number> = new Array<number>();
    do{        
        const number = numberArray[iterator];       
        newArray.push(Math.abs(number));
        iterator++;
    }    
    while(iterator < numberArray.length)
    console.log(`Do While Negative Array Old: ${numberArray} New: ${newArray}`); 
}