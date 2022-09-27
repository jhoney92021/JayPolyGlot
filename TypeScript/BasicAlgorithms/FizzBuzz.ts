/* 
* Write a function that takes an integer array and returns an object array 
* that replaces any negative number with the string "Fizz".
* that replaces any number that is a factor of 3 with the string "Buzz".
* that replaces any number that is negative and a factor of 3 with the string "FizzBuzz".
* For example, if array "numbers" is initially [-1, -3, 2, 12, 3, 4] 
* your function should return an array with values ["Fizz", "FizzBuzz", 2, "Buzz", "Buzz", 4].
*/

export function For(numberArray: Array<number>)
{
    let newArray: Array<string> = new Array<string>();
    for(var iterator: number = 0; iterator < numberArray.length; iterator++)
    {
        const number: number = numberArray[iterator];
        if (number % 3 == 0 && number < 0)
        {
            newArray.push("FizzBuzz");
        }
        else if (number % 3 == 0)
        {
            newArray.push("Buzz");
        }
        else if (number < 0)
        {
            newArray.push("Fizz");
        }
        else 
        {
            newArray.push(number.toString());           
        }  
    }    
    console.log(`For FizzBuzz Array Old: ${numberArray} New: ${newArray}`);
}

export function ForIn(numberArray: Array<number>)
{    
    let newArray: Array<string> = new Array<string>();
    for(let iterator in numberArray)
    {
        const number: number = numberArray[iterator];
        if (number % 3 == 0 && number < 0)
        {
            newArray.push("FizzBuzz");
        }
        else if (number % 3 == 0)
        {
            newArray.push("Buzz");
        }
        else if (number < 0)
        {
            newArray.push("Fizz");
        }
        else 
        {
            newArray.push(number.toString());           
        }  
    }
    console.log(`For In FizzBuzz Array Old: ${numberArray} New: ${newArray}`);
}

export function ForOf(numberArray: Array<number>)
{    
    let newArray: Array<string> = new Array<string>();
    for(let number of numberArray)
    {
        if (number % 3 == 0 && number < 0)
        {
            newArray.push("FizzBuzz");
        }
        else if (number % 3 == 0)
        {
            newArray.push("Buzz");
        }
        else if (number < 0)
        {
            newArray.push("Fizz");
        }
        else 
        {
            newArray.push(number.toString());           
        }  
    }
    console.log(`For Of FizzBuzz Array Old: ${numberArray} New: ${newArray}`); 
}

export function While(numberArray: Array<number>)
{
    let iterator: number = 0;
    let newArray: Array<string> = new Array<string>();
    while(iterator < numberArray.length)
    {
        const number = numberArray[iterator];
        if (number % 3 == 0 && number < 0)
        {
            newArray.push("FizzBuzz");
        }
        else if (number % 3 == 0)
        {
            newArray.push("Buzz");
        }
        else if (number < 0)
        {
            newArray.push("Fizz");
        }
        else 
        {
            newArray.push(number.toString());           
        }   
        iterator++;
    }    
    console.log(`While FizzBuzz Array Old: ${numberArray} New: ${newArray}`); 
}

export function DoWhile(numberArray: Array<number>)
{
    let iterator: number = 0;
    let newArray: Array<string> = new Array<string>();
    do{        
        const number = numberArray[iterator];       
        if (number % 3 == 0 && number < 0)
        {
            newArray.push("FizzBuzz");
        }
        else if (number % 3 == 0)
        {
            newArray.push("Buzz");
        }
        else if (number < 0)
        {
            newArray.push("Fizz");
        }
        else 
        {
            newArray.push(number.toString());           
        }   
        iterator++;
    }    
    while(iterator < numberArray.length)
    console.log(`Do While FizzBuzz Array Old: ${numberArray} New: ${newArray}`); 
}