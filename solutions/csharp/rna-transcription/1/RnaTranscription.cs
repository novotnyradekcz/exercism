using System;
using System.Linq;

public static class RnaTranscription
{
    private static char GetComplement(char nucleotide)
    {
        switch (nucleotide)
        {
            case 'G':
                return 'C';
                break;
            case 'C':
                return 'G';
                break;
            case 'T':
                return 'A';
                break;
            case 'A':
                return 'U';
                break;
            default:
                throw new ArgumentException("Invalid nucleotide.");
                break;
        }
    }
    
    public static string ToRna(string strand) =>
        String.Concat(strand.Select(GetComplement));
}