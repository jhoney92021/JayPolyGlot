#print odds 1-255

def PrintOddsTo255_For():
    for i in range(0,256):
        if i % 2 == 1:
            print  ("For to 255 value: ", i)

def PrintOddsTo255_While():
    i = 1
    while i < 256:
        if i % 2 == 1:
            print("While to 255 value: ", i)
        i += 1