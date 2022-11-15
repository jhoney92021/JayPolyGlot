/* 
* for a given number
* return the fibbonacci number
* at that position
* ex 0 -> 0
* 11 -> 144
*/


export function AtPosition(positionLimit: number, currentPosition: number = 1, a: number = 0, b: number = 1): number
{
    if(positionLimit == 0)
    {
        console.log("was zero");
        return 0;
    }
    else if(positionLimit == currentPosition)
    {
        console.log(`was ${a+b} at ${positionLimit}`);
        return a + b;
    }
    else
    {
        const nextPostition = currentPosition + 1;
        const nextA = b;
        const nextB = a+b;
        // console.log(`~~~ continuing ~~~ current ${currentPosition} to ${positionLimit} ~~~ next nums ${nextA} ${nextB} ~~~`);

        return AtPosition(positionLimit, nextPostition, nextA, nextB);
    }
}