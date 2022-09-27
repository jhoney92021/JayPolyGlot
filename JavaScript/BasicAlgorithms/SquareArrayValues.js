/* 
* Write a function that takes an integer array "numbers", and then multiplies each value by itself.
* For example, [1,5,10,-10] should become [1,25,100,100]
*/


export function For(numberArray)
{
    let newArray = [];
    for(var iterator = 0; iterator < numberArray.length; iterator++)
    {
        const number = numberArray[iterator];        
        newArray.push(number*number);        
    }    
    console.log(`For Square Array Old: ${numberArray} New: ${newArray}`);
}

export function ForIn(numberArray)
{    
    let newArray = [];
    for(let iterator in numberArray)
    {
        const number = numberArray[iterator];
        newArray.push(number*number);
    }
    console.log(`For In Square Array Old: ${numberArray} New: ${newArray}`);
}

export function ForOf(numberArray)
{    
    let newArray = [];
    for(let number of numberArray)
    {
        newArray.push(number*number);
    }
    console.log(`For Of Square Array Old: ${numberArray} New: ${newArray}`); 
}

export function While(numberArray)
{
    let iterator = 0;
    let newArray = [];
    while(iterator < numberArray.length)
    {
        const number = numberArray[iterator];
        newArray.push(number*number);
        iterator++;
    }    
    console.log(`While Square Array Old: ${numberArray} New: ${newArray}`); 
}

export function DoWhile(numberArray)
{
    let iterator = 0;
    let newArray = [];
    do{        
        const number = numberArray[iterator];       
        newArray.push(number*number);
        iterator++;
    }    
    while(iterator < numberArray.length)
    console.log(`Do While Square Array Old: ${numberArray} New: ${newArray}`); 
}