public static class OldPhonePadTests
{
    public static void RunAll()
    {
        Test("555 88 444 7777 0 2 4 88 444 555 2 777#", "LUIS AGUILAR");
        Test("8 88777444666*664#", "TURING");
        Test("33#", "E");
        Test("227*#", "B");
        Test("4433555 555666#", "HELLO");
        Test("222 2 22#", "CAB");
        Test("4433555 555666*#", "HELL");
        Test("222222#", "C");
        Test("4433555 555666**#", "HEL");
        Test(" 33 555 555 0 666#", "ELL O");
        Test("4666 666 3 0 5 666 22#", "GOOD JOB");
        Test("7777#", "S");
        Test("77777#", "P");
        Test("555 88 444 7777 0 2 4 88 444 555 2 777 0 6 2 3 33 0 8 44 444 7777#", "LUIS AGUILAR MADE THIS");
    }

    private static void Test(string input, string expected)
    {
        var result = OldPhonePadChallenge.OldPhonePad(input);
        if (result == expected){

            Console.WriteLine($"TEST Passed: \"{input}\" => \"{result}\"");

        } else {
            Console.WriteLine($"TEST Failed: \"{input}\" => \"{result}\" (expected: \"{expected}\")");
        }
    }
}
