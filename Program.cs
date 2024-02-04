using System;
string[] leksaker = new string[] { "boll", "docka", "lego", "kloss", "bil" };
string[] klasskamrater = new string[] { "yoel", "adam", "theo", " antoni", "arda" };
int[] betyg = new int[] { 1, 2, 3, 4, 5 };

for (int i = 0; i < klasskamrater.Length; i++)
{
    Console.WriteLine(klasskamrater[i] + "ger" + leksaker[i] + "betyget" + betyg[i]);
}
