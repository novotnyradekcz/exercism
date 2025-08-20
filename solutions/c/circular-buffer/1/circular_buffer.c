#include "circular_buffer.h"

circular_buffer_t *new_circular_buffer(int capacity)
{
    circular_buffer_t *buffer = malloc(sizeof(circular_buffer_t));
    buffer->capacity = capacity;
    buffer->data = malloc(capacity * sizeof(buffer_value_t));
    clear_buffer(buffer);
    return buffer;
}

int16_t read(circular_buffer_t *buffer, buffer_value_t *value)
{
    if (buffer->count == 0)
    {
        errno = ENODATA;
        return 1;
    }
    *value = buffer->data[buffer->tail];
    buffer->tail = (buffer->tail + 1) % buffer->capacity;
    buffer->count--;
    return 0;
}

int16_t write(circular_buffer_t *buffer, buffer_value_t value)
{
    if (buffer->count == buffer->capacity)
    {
        errno = ENOBUFS;
        return 1;
    }
    buffer->data[buffer->head] = value;
    buffer->head = (buffer->head + 1) % buffer->capacity;
    buffer->count++;
    return 0;
}

int16_t overwrite(circular_buffer_t *buffer, buffer_value_t value)
{
    
    buffer->data[buffer->head] = value;
    buffer->head = (buffer->head + 1) % buffer->capacity;
    if (buffer->count != buffer->capacity)
        buffer->count++;
    else
        buffer->tail = buffer->head;
    return 0;
}

void clear_buffer(circular_buffer_t *buffer)
{
    buffer->count = 0;
    buffer->head = 0;
    buffer->tail = 0;
}

void delete_buffer(circular_buffer_t *buffer)
{
    free(buffer->data);
    free(buffer);
}