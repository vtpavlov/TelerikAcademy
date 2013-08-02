/*
 * Write an expression that checks for given point (x, y) 
 * if it is within the circle K( (1,1), 3) and out of the 
 * rectangle R(top=1, left=-1, width=6, height=2).
 * 
 * Тъй като имаше много спорове как трябва да се интерпретира задачата
 * аз реших да я направя като горният ляв ъгъл ми се намира в точката
 * (-1, 1) от декартовата координатна система и според мен това е 
 * единственото логично интерпретиране. Незнам защо се е получило такова
 * объркване ама те задачите са направени не толкова да се мисли каква е 
 * координатната система и т.н. ами просто да се запознаем с операторите.
 * Следователно по възможно най-простия начин трябва да се интерпретират.
*/

using System;

class InCircleOutOfRectangle
{
    static void Main()
    {
        //Getting string input for x and converting it to double
        Console.Write("Please enter x coordinate of a point: ");
        double x = double.Parse(Console.ReadLine());

        //Getting string input for y and converting it to double
        Console.Write("Please enter y coordinate of a point: ");
        double y = double.Parse(Console.ReadLine());

        //expression checking if the point is inside the circle K((1,1) ,3)
        string circleResult = ((x - 1) * (x - 1)) + ((y - 1) * (y - 1)) < 3 * 3 ? "The point is inside the circle K((1, 1), 3)"
            : "The point is outside the circle K((1, 1), 3)";

        //expression checking if the point is outside of the rectangle R(top=1, left=-1, width=6, height=2).
        string rectangleResult = ((x < -1) || (x > 5)) || ((y > 1) || (y < -1)) ? " and outside the rectangle R(top=1, left=-1, width=6, height=2)"
            : " and inside the rectangle R(top=1, left=-1, width=6, height=2)";

        //printing the result
        Console.WriteLine(circleResult + rectangleResult);
    }
}

