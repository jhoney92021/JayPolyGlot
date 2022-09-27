export function Create(): Array<number>
{
    let numbersTo255: Array<number> = [];
    for(let i = 0; i < 256; i++)
    {
        numbersTo255.push(i);
    }
    return numbersTo255;
}