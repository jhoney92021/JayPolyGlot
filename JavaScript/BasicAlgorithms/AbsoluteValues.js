/* 
* Given an integer array "numbers", say [1, -5, 10, -2], 
* create a function that replaces any negative number with the positive value. 
* When the program is done, "numbers" should have no negative values, say [1, 5, 10, 2].
*/

export function For(numberArray)
{
    let newArray = [];
    for(var iterator = 0; iterator < numberArray.length; iterator++)
    {
        const number = numberArray[iterator];        
        newArray.push(Math.abs(number));        
    }    
    console.log(`For Negative Array Old: ${numberArray} New: ${newArray}`);
}

export function ForIn(numberArray)
{    
    let newArray = [];
    for(let iterator in numberArray)
    {
        const number = numberArray[iterator];
        newArray.push(Math.abs(number));
    }
    console.log(`For In Negative Array Old: ${numberArray} New: ${newArray}`);
}

export function ForOf(numberArray)
{    
    let newArray = [];
    for(let number of numberArray)
    {
        newArray.push(Math.abs(number));
    }
    console.log(`For Of Negative Array Old: ${numberArray} New: ${newArray}`); 
}

export function While(numberArray)
{
    let iterator = 0;
    let newArray = [];
    while(iterator < numberArray.length)
    {
        const number = numberArray[iterator];
        newArray.push(Math.abs(number));
        iterator++;
    }    
    console.log(`While Negative Array Old: ${numberArray} New: ${newArray}`); 
}

export function DoWhile(numberArray)
{
    let iterator = 0;
    let newArray = [];
    do{        
        const number = numberArray[iterator];       
        newArray.push(Math.abs(number));
        iterator++;
    }    
    while(iterator < numberArray.length)
    console.log(`Do While Negative Array Old: ${numberArray} New: ${newArray}`); 
}