/* 
* Given an integer array, say [1, -5, 10, -2, 1, 12, 3, 4, 6], 
* Write a function that shifts each number by one to the front and adds '0' to the end. 
* For example, when the program is done, 
* if the array [1, -5, 10, -2, 1, 12, 3, 4, 6] is passed to the function, 
* it should become [-5, 10, -2, 1, 12, 3, 4, 6, 0].
*/

export function For(numberArray)
{
    let newArray = [];
    for(var iterator = 0; iterator < numberArray.length; iterator++)
    {
        const number = numberArray[iterator];     
        if (number == numberArray[numberArray.length-1])
        {
            newArray.push(0);
        }
        else 
        {
            newArray.push(numberArray[iterator+1]);
        }  
    }    
    console.log(`For Shift Array Old: ${numberArray} New: ${newArray}`);
}

export function ForIn(numberArray)
{    
    let newArray = [];
    for(let iterator in numberArray)
    {
        const number = numberArray[iterator];
        if (number == numberArray[numberArray.length-1])
        {
            newArray.push(0);
        }
        else 
        {
            newArray.push(numberArray[iterator+1]);
        }  
    }
    console.log(`For In Shift Array Old: ${numberArray} New: ${newArray}`);
}

export function ForOf(numberArray)
{    
    let newArray = [];
    let iterator = 0;
    for(let number of numberArray)
    {
        if (number == numberArray[numberArray.length-1])
        {
            newArray.push(0);
        }
        else 
        {
            newArray.push(numberArray[iterator+1]);
        }  
        iterator++;
    }
    console.log(`For Of Shift Array Old: ${numberArray} New: ${newArray}`); 
}

export function While(numberArray)
{
    let iterator = 0;
    let newArray = [];
    while(iterator < numberArray.length)
    {
        const number = numberArray[iterator];
        if (number == numberArray[numberArray.length-1])
        {
            newArray.push(0);
        }
        else 
        {
            newArray.push(numberArray[iterator+1]);
        }  
        iterator++;
    }    
    console.log(`While Shift Array Old: ${numberArray} New: ${newArray}`); 
}

export function DoWhile(numberArray)
{
    let iterator = 0;
    let newArray = [];
    do{        
        const number = numberArray[iterator];       
        if (number == numberArray[numberArray.length-1])
        {
            newArray.push(0);
        }
        else 
        {
            newArray.push(numberArray[iterator+1]);
        }  
        iterator++;
    }    
    while(iterator < numberArray.length)
    console.log(`Do While Shift Array Old: ${numberArray} New: ${newArray}`); 
}