CC = gcc
CFLAGS = -Wall -Wextra -std=c11 -O2
TARGET = runner
SRCS = PrintTo255.c PrintOddsTo255.c PrintSum.c IterateArray.c \
       FindMaximumValue.c FindAverageValue.c FindOddValues.c \
       FindGreaterThanYValues.c SquareArrayValues.c AbsoluteValues.c \
       GetMinMaxAverageValues.c ShiftArray.c FizzBuzz.c main.c
OBJS = $(SRCS:.c=.o)

all: $(TARGET)

$(TARGET): $(OBJS)
	$(CC) $(CFLAGS) -o $(TARGET) $(OBJS)

%.o: %.c basic_algorithms.h
	$(CC) $(CFLAGS) -c $< -o $@

run: $(TARGET)
	./$(TARGET)

clean:
	rm -f $(OBJS) $(TARGET)

.PHONY: all run clean
