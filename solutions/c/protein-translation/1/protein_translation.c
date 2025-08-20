#include "protein_translation.h"

#include <stdbool.h>
#include <stddef.h>
#include <string.h>
#include <stdio.h>


static const char *CODONS[] = {
    "AUG", "UUU", "UUC", "UUA", "UUG", 
    "UCU", "UCC", "UCA", "UCG", "UAU", 
    "UAC", "UGU", "UGC", "UGG", "UAA", 
    "UAG", "UGA"
};

static const protein_t PROTEINS[] = {
    Methionine, Phenylalanine, Phenylalanine, Leucine, Leucine, 
    Serine, Serine, Serine, Serine, Tyrosine, 
    Tyrosine, Cysteine, Cysteine, Tryptophan, 
};

static const size_t NUM_CODONS = sizeof(CODONS) / sizeof(CODONS[0]);

static protein_t get_protein_from_codon(const char *codon) {
    for (size_t i = 0; i < NUM_CODONS; ++i) {
        if (strcmp(codon, CODONS[i]) == 0) {
            return PROTEINS[i];
        }
    }
    return -1; // Invalid protein
}

static bool is_stop_codon(const char *codon) {
    return strcmp(codon, "UAA") == 0 || strcmp(codon, "UAG") == 0 || strcmp(codon, "UGA") == 0;
}

proteins_t proteins(const char *const rna) {
    proteins_t result = { .valid = true, .count = 0 };
    
    size_t rna_len = strlen(rna);

    for (size_t i = 0; i < rna_len; i += 3) {
        char codon[4] = { rna[i], rna[i + 1], rna[i + 2], '\0' };
        
        if (is_stop_codon(codon)) {
            break;
        }

        protein_t protein = get_protein_from_codon(codon);
        if ((int)protein == -1) {
            result.valid = false;
            return result;
        }

        if (result.count >= MAX_PROTEINS) {
            result.valid = false;
            return result;
        }

        result.proteins[result.count++] = protein;
    }

    return result;
}
