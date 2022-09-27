/* Print all of the integers from 1 to 255.*/

export function For()
{
    for(var iterator = 0; iterator < 256; iterator++)
    {
        console.log(`For to 255  ${iterator}`);
    }
}

export function ForIn()
{
    var arr = [...Array(256).keys()];
    for(var number in arr)
    {
        console.log(`For In to 255  ${number}`);
    }
}

export function ForOf()
{
    var arr = [...Array(256).keys()];
    for(var number of arr)
    {
        console.log(`For Of to 255  ${number}`);
    }
}

export function While()
{
    let iterator = 0;
    while(iterator < 256)
    {
        console.log(`While to 255  ${iterator}`);
        iterator++;
    }
}

export function DoWhile()
{
    let iterator = 0;
    do{
        console.log(`Do While to 255  ${iterator}`);
        iterator++;
    }        
    while(iterator < 256)
}