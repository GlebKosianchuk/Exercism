public static class RnaTranscription
{
    public static string ToRna(string nucleotide)
    {
        var dnaletters= nucleotide.ToCharArray();
        for (var i = 0; i < dnaletters.Length; i++)
        {
            var letter = dnaletters[i] switch
            {
                'C' => 'G',
                'G' => 'C',
                'T' => 'A',
                'A' => 'U',
                 _  => dnaletters[i]
            };
            dnaletters[i] = letter;
        }
        return new string(dnaletters);
    }
}   