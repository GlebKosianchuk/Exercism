public static class RnaTranscription
{
    public static string ToRna(string nucleotide)
    {
        var dnaletters = nucleotide.ToCharArray();
        for (var i = 0; i < dnaletters.Length; i++)
          
            if (dnaletters[i] == 'C')
                dnaletters[i] = 'G';
            else
                if (dnaletters[i] == 'G')
                dnaletters[i] = 'C';
            else
                if (dnaletters[i] == 'T')
                dnaletters[i] = 'A';
            else
                if (dnaletters[i] == 'A')
                dnaletters[i] = 'U';

        string rna = new string(dnaletters);
        return rna;


    }
}