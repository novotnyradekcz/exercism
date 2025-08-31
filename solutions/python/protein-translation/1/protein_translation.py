def proteins(strand):
    codons = [strand[i:i+3] for i in range(0, len(strand), 3)]
    aminoacids = []
    for codon in codons:
        if codon == "AUG":
            aminoacids.append("Methionine")
        elif codon == "UUU" or codon == "UUC":
            aminoacids.append("Phenylalanine")
        elif codon == "UUA" or codon == "UUG":
            aminoacids.append("Leucine")
        elif codon == "UCU" or codon == "UCC" or codon == "UCA" or codon == "UCG":
            aminoacids.append("Serine")
        elif codon == "UAU" or codon == "UAC":
            aminoacids.append("Tyrosine")
        elif codon == "UGU" or codon == "UGC":
            aminoacids.append("Cysteine")
        elif codon == "UGG":
            aminoacids.append("Tryptophan")
        elif codon == "UAA" or codon == "UAG" or codon == "UGA":
            break
        else:
            return ["Error"]
    return aminoacids