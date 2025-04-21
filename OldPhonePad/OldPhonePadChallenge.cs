using System.Text;

public static class OldPhonePadChallenge
{
    private static readonly Dictionary<char, string> keypad = new()
    {
        { '1', "" },{ '2', "ABC" },{ '3', "DEF" },
        { '4', "GHI" },{ '5', "JKL" },{ '6', "MNO" },
        { '7', "PQRS" },{ '8', "TUV" },{ '9', "WXYZ" },
        { '0', " " }
    };

    public static string OldPhonePad(string input)
    {
        if (string.IsNullOrEmpty(input) || input[^1] != '#')
            throw new ArgumentException("Input must end with '#'");

        var output = new StringBuilder();
        var currentSequence = new StringBuilder();
        char? previousChar = null;

        foreach (char c in input)
        {
            if (c == '#')
            {
                CommitSequence(currentSequence, output);
                break;
            }

            if (c == '*')
            {
                CommitSequence(currentSequence, output);
                if (output.Length > 0)
                    output.Length--;
                continue;
            }

            if (c == ' ')
            {
                CommitSequence(currentSequence, output);
                previousChar = null;
                continue;
            }

            if (previousChar != null && c != previousChar)
            {
                CommitSequence(currentSequence, output);
            }

            currentSequence.Append(c);
            previousChar = c;
        }

        return output.ToString();
    }

    private static void CommitSequence(StringBuilder sequence, StringBuilder output)
    {
        if (sequence.Length == 0) return;

        char digit = sequence[0];
        int count = sequence.Length;

        if (keypad.ContainsKey(digit) && keypad[digit].Length > 0)
        {
            string letters = keypad[digit];
            int index = (count - 1) % letters.Length;
            output.Append(letters[index]);
        }

        sequence.Clear();
    }
}