
#include "linked_list.h"

struct list_node {
   struct list_node *prev, *next;
   ll_data_t data;
};

struct list {
   struct list_node *first, *last;
};

// constructs a new (empty) list
struct list *list_create(void){
    struct list *emptyList = malloc(sizeof(struct list));
    emptyList->first = NULL;
    emptyList->last = NULL;
    return (emptyList);
}

// counts the items on a list
size_t list_count(const struct list *list)
{
    size_t counter = 0;
    if (!list)
        return (counter);
    struct list_node *node;
    node = list->first;
    while (node)
    {
        node = node->next;
        counter++;
    }
    return (counter);
}

// inserts item at back of a list
void list_push(struct list *list, ll_data_t item_data)
{
    struct list_node *new_node = malloc(sizeof(struct list_node));
    new_node->data = item_data;
    new_node->next = NULL;
    if (list->last == NULL)
        list->first = new_node;
    else
        list->last->next = new_node;
    new_node->prev = list->last;
    list->last = new_node;
}

// removes item from back of a list
ll_data_t list_pop(struct list *list)
{
    ll_data_t popped = list->last->data;
    struct list_node *to_free = list->last;
    list->last = list->last->prev;
    if (list->last)
        list->last->next = NULL;
    else
        list->first = NULL;
    free(to_free);
    return(popped);
}

// inserts item at front of a list
void list_unshift(struct list *list, ll_data_t item_data)
{
    struct list_node *new_node = malloc(sizeof(struct list_node));
    new_node->data = item_data;
    new_node->prev = NULL;
    if (list->first == NULL)
        list->last = new_node;
    else
        list->first->prev = new_node;
    new_node->next = list->first;
    list->first = new_node;
}

// removes item from front of a list
ll_data_t list_shift(struct list *list)
{
    ll_data_t shifted = list->first->data;
    struct list_node *to_free = list->first;
    list->first = list->first->next;
    if (list->first)
        list->first->prev = NULL;
    else
        list->last = NULL;
    free(to_free);
    return(shifted);
}

// deletes a node that holds the matching data
void list_delete(struct list *list, ll_data_t data)
{
    if (list->first == NULL)
        return ;
    struct list_node *previous = NULL;
    struct list_node *current = list->first;
    while (current->data != data)
    {
        if (current->next)
        {
            previous = current;
            current = current->next;
        }
        else
            return ;
    }
    if (current == list->first)
        list->first = list->first->next;
    else
        current->prev->next = current->next;
    if (current == list->last)
        list->last = current->prev;
    else
        current->next->prev = current->prev;
    previous = current;
    free(previous);
}

// destroys an entire list
// list will be a dangling pointer after calling this method on it
void list_destroy(struct list *list)
{
    struct list_node *node = list->first;
    while (node)
    {
        struct list_node *to_free = node;
        node = node->next;
        free(to_free);
    }
    free(list);
}
