/* 
* Print all of the numbers from 0 to 255, 
* but this time, also print the sum as you go. 
* For example, your output should be something like this:            
* New number: 0 Sum: 0
* New number: 1 Sum: 1
* New Number: 2 Sum: 3
*
* Here we will just print the final output
*/

export function For()
{
    let sum = 0;
    for(var iterator = 0; iterator < 256; iterator++)
    {
        sum += iterator;        
    }
    console.log(`For Sum of 255: ${sum}`);
}

export function ForIn()
{
    let arr = [...Array(256).keys()];
    let sum = 0;
    for(let number in arr)
    {
        sum += parseInt(number);
    }
    console.log(`For In Sum of 255: ${sum}`);
}

export function ForOf()
{
    let arr = [...Array(256).keys()];
    let sum = 0;
    for(let number of arr)
    {
        sum += number;
    }
    console.log(`For Of Sum of 255: ${sum}`);
}

export function While()
{
    let iterator = 0;
    let sum = 0;
    while(iterator < 256)
    {
        sum += iterator;
        iterator++;
    }
    console.log(`While Sum of 255: ${sum}`);
}

export function DoWhile()
{
    let iterator = 0;
    let sum = 0;
    do{
        sum += iterator;
        iterator++;
    }    
    while(iterator < 256)
    console.log(`Do While Sum of 255: ${sum}`);
}