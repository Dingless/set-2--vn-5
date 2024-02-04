using System;
string[] leksaker = new string[] { "boll", "docka", "lego", "kloss", "bil" }; // string-array för leksaker
string[] klasskamrater = new string[] { "yoel", "adam", "theo", " antoni", "arda" }; // string-array flr leksaker
int[] betyg = new int[] { 1, 2, 3, 4, 5 }; // integer-array för nummer betygen

for (int i = 0; i < klasskamrater.Length; i++) // for loopen för att skriva ut vad för betyg de olika klasskamraterna ger leksakerna
{
    Console.WriteLine(klasskamrater[i] + "ger" + leksaker[i] + "betyget" + betyg[i]);
}
