using System;
using System.Collections.Generic;

public static class ProteinTranslation
{
    private static List<string> SplitStrand(string strand)
    {
        var splitStrand = new List<string>();
        for (int i = 0; i < strand.Length; i += 3)
        {
            if (i + 3 < strand.Length)
                splitStrand.Add(strand.Substring(i, 3));
            else
                splitStrand.Add(strand.Substring(i));
        }
        return splitStrand;
    }
    
    public static string[] Proteins(string strand)
    {
        var splitStrand = SplitStrand(strand);
        var translatedStrand = new List<string>();
        
        foreach (string codon in splitStrand)
        {
            var protein = codon switch
                {
                    "AUG" => "Methionine",
                    "UUU" or "UUC" => "Phenylalanine",
                    "UUA" or "UUG" => "Leucine",
                    "UCU" or "UCC" or "UCA" or "UCG" => "Serine",
                    "UAU" or "UAC" => "Tyrosine",
                    "UGU" or "UGC" => "Cysteine",
                    "UGG" => "Tryptophan",
                    "UAA" or "UAG" or "UGA" => "STOP",
                    _ => throw new ArgumentException("Invalid codon found in strand.")
                };
            if (protein != "STOP")
                translatedStrand.Add(protein);
            else
                break;
        }
    
        return translatedStrand.ToArray();
    }
}