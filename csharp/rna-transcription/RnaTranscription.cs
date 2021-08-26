public static class RnaTranscription
{
    public static string ToRna(string nucleotide)
    {
        var dnaletters= nucleotide.ToCharArray();
        for (var i = 0; i < dnaletters.Length; i++)
            switch(dnaletters[i])
            {
                case 'C':
                    dnaletters[i] = 'G';
                    break;
                case 'G':
                    dnaletters[i] = 'C';
                    break;
                case 'T':
                    dnaletters[i] = 'A';
                    break;
                case 'A':
                    dnaletters[i] = 'U';
                    break;
            }
        return new string(dnaletters);
    }
}