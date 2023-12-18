#include <stdio.h>

const char * hi(){
    return "hi";
}

int main(){
    printf("Hello World!");
    printf(hi());

    return 0;
}