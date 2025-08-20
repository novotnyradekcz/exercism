#include "high_scores.h"

#include <stdlib.h>

int32_t latest(const int32_t *scores, size_t scores_len)
{
    return (scores[scores_len - 1]);
}

int32_t personal_best(const int32_t *scores, size_t scores_len)
{
    size_t i = 0;
    int32_t best = 0;
    while (i < scores_len)
    {
        if (scores[i] > best)
            best = scores[i];
        i++;
    }
return (best);
}

int compare(const void *one, const void *two)
{
    return ((int)(*(int *)one - *(int *)two));
}

size_t personal_top_three(const int32_t *scores, size_t scores_len, int32_t *output)
{
    size_t i = 0;
    int32_t sort_scores[scores_len];
    while (i < scores_len)
    {
        sort_scores[i] = scores[i];
        i++;
    }
    qsort(sort_scores, scores_len, sizeof(int32_t), compare);
    if (scores_len > 0)
        output[0] = sort_scores[scores_len - 1];
    if (scores_len > 1)
        output[1] = sort_scores[scores_len - 2];
    if (scores_len > 2)
        output[2] = sort_scores[scores_len - 3];
    if (scores_len > 3)
        return (3);
    return (scores_len);
}