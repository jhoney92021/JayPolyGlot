# jhoney's C notes #

### Quick Links ###
* [Home](../README.md)

* [Basic Algo Prompts](../BasicAlgorithmPromts.md)

### Set Up For Windows ###
* Get MYSYS2 https://www.msys2.org/
    - Then run  `$ pacman -S mingw-w64-ucrt-x86_64-gcc`
    - Verify install with `gcc --version` in whatever CLI you prefer, maybe starting with the MYSYS2
        - If  `gcc --version` doesn't bring anything back, you may need to add the binaries (bin) to the windows environment path


Example:

- Creates an exe
  - gcc (filename).c -o (filename)
    - ex gcc main.c -o main
- Runs file
    - ./(filename)
        - ./main

- idk
    ./(filename) 1024 > outputfile.c

- print f stuff
    - %d: for printing ints
    - %f: for printing floating point numbers
    - %c: for printing chars
    - %s: for printing string
    - %p: for printing memory address ie pointer
    - %x: for printing hexadecimal values

- random notes
    - printf("%c", "\n): printed hearts
    