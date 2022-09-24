# Loops #
* [Main Notes](../../README.md#quick-links)
* [CSharp Notes](../README.md#quick-links)

## FOR LOOP EX ##
    loop from 1 to 5 including 5
    for (int i = 1; i <= 5; i++)
    {
        Console.WriteLine(i);
    }

    loop from 1 to 5 excluding 5
    for (int i = 1; i < 5; i++)
    {
        Console.WriteLine(i);
    }

    loop from start to end including end    
    int start = 0;
    int end = 5;
    for (int i = start; i <= end; i++)
    {
        Console.WriteLine(i);
    }

    loop from start to end excluding end
    for (int i = start; i < end; i++)
    {
        Console.WriteLine(i);
    }

    The execution section does not always have to use ++  
    for (int i = 1; i < 6; i = i + 1)
    {
        Console.WriteLine(i);
    }

## WHILE LOOP EX ##
    int i = 1;
    while (i < 6)
      {
          Console.WriteLine(i);
          i = i + 1;
      }