#ifndef CIRCULAR_BUFFER_H
#define CIRCULAR_BUFFER_H

#include <errno.h>
#include <stdlib.h>
#include <stdint.h>

typedef uint16_t buffer_value_t;
typedef struct circular_buffer_s
{
    size_t capacity;
    size_t count;
    size_t head;
    size_t tail;
    buffer_value_t *data;
} circular_buffer_t;

circular_buffer_t *new_circular_buffer(int capacity);
int16_t read(circular_buffer_t *buffer, buffer_value_t *value);
int16_t write(circular_buffer_t *buffer, buffer_value_t value);
int16_t overwrite(circular_buffer_t *buffer, buffer_value_t value);
void clear_buffer(circular_buffer_t *buffer);
void delete_buffer(circular_buffer_t *buffer);

#endif
