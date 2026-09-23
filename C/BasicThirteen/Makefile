CC = gcc
CFLAGS = -Wall -Wextra -std=c11 -O2
TARGET = main.out

all: $(TARGET)

$(TARGET): main.c
	$(CC) $(CFLAGS) -o $(TARGET) main.c

main: $(TARGET)

run: $(TARGET)
	./$(TARGET)

clean:
	rm -f $(TARGET)

.PHONY: all main run clean
