/*
 * Declare five variables choosing for each of them the 
 * most appropriate of the types byte, sbyte, short, 
 * ushort, int, uint, long, ulong to represent the 
 * following values: 52130, -115, 4825932, 97, -10000.
*/

using System;

class DeclareVariables
{
    static void Main()
    {
        ushort numberOne = 52130;    // ushort  -[0, 65 535]
        sbyte numberTwo = -115;      // sbyte   -[-128, 127]
        int numberThree = 4825932;   // int     -[-2 147 483 648, 2 147 483 647]
        byte numberFour = 97;        // byte    -[0, 255]
        short numberFive = -10000;   // short   -[-32 768, 32767]
    }
}
