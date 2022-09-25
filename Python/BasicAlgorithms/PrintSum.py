#  Print all of the numbers from 0 to 255, 
#  but this time, also print the sum as you go. 
#  For example, your output should be something like this:            
#  New number: 0 Sum: 0
#  New number: 1 Sum: 1
#  New Number: 2 Sum: 3
#  Here we will just print the final output

def PrintSum_For():
    sum = 0
    for i in range(0,256):
        sum += i
    print  ("For Sum of 255:  ", sum)

def PrintSum_While():
    i = 1
    sum = 0
    while i < 256:
        sum += i
        i += 1
    print("While Sum of 255: ", sum)