/* 
* Write a function that takes an integer array and returns an object array 
* that replaces any negative number with the string "Fizz".
* that replaces any number that is a factor of 3 with the string "Buzz".
* that replaces any number that is negative and a factor of 3 with the string "FizzBuzz".
* For example, if array "numbers" is initially [-1, -3, 2, 12, 3, 4] 
* your function should return an array with values ["Fizz", "FizzBuzz", 2, "Buzz", "Buzz", 4].
*/

export function For(numberArray)
{
    let newArray = [];
    for(var iterator = 0; iterator < numberArray.length; iterator++)
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
    }    
    console.log(`For FizzBuzz Array Old: ${numberArray} New: ${newArray}`);
}

export function ForIn(numberArray)
{    
    let newArray = [];
    for(let iterator in numberArray)
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
    }
    console.log(`For In FizzBuzz Array Old: ${numberArray} New: ${newArray}`);
}

export function ForOf(numberArray)
{    
    let newArray = [];
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

export function While(numberArray)
{
    let iterator = 0;
    let newArray = [];
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

export function DoWhile(numberArray)
{
    let iterator = 0;
    let newArray = [];
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