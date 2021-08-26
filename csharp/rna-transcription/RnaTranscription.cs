public static class RnaTranscription
{
    public static string ToRna(string nucleotide)
    {
        var length = nucleotide.Length;
        var dnaLetters = nucleotide.ToCharArray();
        var rnaLetters = new char[length];

        for (var i = 0; i < dnaLetters.Length; i++)
        {
            var letter = dnaLetters[i] switch
            {
                'C' => 'G',
                'G' => 'C',
                'T' => 'A',
                'A' => 'U',
                 _  => rnaLetters[i]
            };
            rnaLetters[i] = letter;
        }

        return new string(rnaLetters);
    }
} 