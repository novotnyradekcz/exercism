fun transcribeToRna(dna: String): String {
    var rna = ""
    for (nucleotide in dna) {
        when (nucleotide) {
            'G' -> rna += "C"
            'C' -> rna += "G"
            'T' -> rna += "A"
            'A' -> rna += "U"
        }
    }
    return rna
}
