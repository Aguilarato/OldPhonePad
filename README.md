# OldPhonePad
C# solution to Iron Software's coding Challenge, Coded by Luis Aguilar
Simulate an old phone keypad text input

This C# solution simulates typing on an old mobile phone keypad.
It handles letters, backspaces, pauses, and ends input with a send key.

## Funcionality
- Translates old-style keypad input into English letters
- Supports:
  - Multi-tap characters (e.g., `2`, `22`, `222` → A, B, C)
  - Pauses between characters with the same button (`space`)
  - Backspace (`*`)
  - Send/submit (`#`)
- Includes a set of well-documented test cases

## Input Rules
- Digits 2–9 map to multiple letters (as on old keypads)
- Pressing the same digit multiple times cycles through the letters
- Use `' '` (space) to pause between characters using the same button
- Use `*` to delete the last character
- Input always ends with `#`

## Sample Test Cases
```csharp
        Test("555 88 444 7777 0 2 4 88 444 555 2 777#", "LUIS AGUILAR");
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

