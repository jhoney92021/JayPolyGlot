/* Print all of the odd integers from 1 to 255.*/

export function For()
{
    for(var iterator = 0; iterator < 256; iterator++)
    {
        if(iterator % 2 === 1)
        {
            console.log(`For odds to 255  ${iterator}`);
        }
    }
}

export function ForIn()
{
    var arr = [...Array(256).keys()];
    for(var number in arr)
    {
        if(number % 2 === 1)
        {            
            console.log(`For In odds to 255  ${number}`);
        }
    }
}

export function ForOf()
{
    var arr = [...Array(256).keys()];
    for(var number of arr)
    {
        if(number % 2 === 1)
        {            
            console.log(`For Of odds to 255  ${number}`);
        }
    }
}

export function While()
{
    let iterator = 0;
    while(iterator < 256)
    {
        if(iterator % 2 === 1)
        {            
            console.log(`While to odds 255  ${iterator}`);
        }
        iterator++;
    }
}

export function DoWhile()
{
    let iterator = 0;
    do{
        if(iterator % 2 === 1)
        {            
            console.log(`Do While to odds 255  ${iterator}`);
        }
        iterator++;
    }
        
    while(iterator < 256)
}