using System;

class Matrix
{
    //atribute
    private int[,] matrix;

    //properties
    public int Rows
    {
        get
        {
            return this.matrix.GetLength(0);
        }
    }

    public int Cols
    {
        get
        {
            return this.matrix.GetLength(1);
        }
    }

    //indexator
    public int this[int row, int col]
    {
        get
        {
            return this.matrix[row, col];
        }
        set
        {
            this.matrix[row, col] = value;
        }
    }

    //constructor
    public Matrix(int rows, int cols)
    {
        this.matrix = new int[rows, cols];
    }

    //overload adding
    public static Matrix operator +(Matrix first, Matrix second)
    {
        Matrix tempMatrix = new Matrix(first.Rows, first.Cols);

        if (first.Rows != second.Rows || first.Cols != second.Cols)
        {
            Console.WriteLine("Wrong input!");
            return tempMatrix;
        }

        for (int i = 0; i < tempMatrix.Rows; i++)
        {
            for (int j = 0; j < tempMatrix.Cols; j++)
            {
                tempMatrix[i, j] = first[i, j] + second[i, j];
            }
        }

        return tempMatrix;
    }

    //overload subtracting
    public static Matrix operator -(Matrix first, Matrix second)
    {
        Matrix tempMatrix = new Matrix(first.Rows, first.Cols);

        if (first.Rows != second.Rows || first.Cols != second.Cols)
        {
            Console.WriteLine("Wrong input!");
            return tempMatrix;
        }

        for (int i = 0; i < tempMatrix.Rows; i++)
        {
            for (int j = 0; j < tempMatrix.Cols; j++)
            {
                tempMatrix[i, j] = first[i, j] - second[i, j];
            }
        }

        return tempMatrix;
    }

    //overload multiplying
    public static Matrix operator *(Matrix first, Matrix second)
    {
        Matrix tempMatrix = new Matrix(first.Rows, second.Cols);

        if (second.Rows != first.Cols)
        {
            Console.WriteLine("Wrong input!");
            return tempMatrix;
        }

        for (int i = 0; i < tempMatrix.Rows; i++)
        {
            for (int j = 0; j < tempMatrix.Cols; j++)
            {
                int tempMatrixValue = 0;
                for (int firstMatrixCols = 0; firstMatrixCols < first.Cols; firstMatrixCols++)
                {
                    tempMatrixValue += first[i, firstMatrixCols] * second[firstMatrixCols, j];
                }
                tempMatrix.matrix[i, j] = tempMatrixValue;
            }
        }

        return tempMatrix;
    }

    //overriding the method ToString
    public override string ToString()
    {
        string printMatrix = "";
        for (int i = 0; i < this.Rows; i++)
        {
            for (int j = 0; j < this.Cols; j++)
            {
                printMatrix += this.matrix[i, j] + " ";
            }
            printMatrix += Environment.NewLine;
        }
        return printMatrix;
    }

    static void Main()
    {
        //objects of type Matrix
        Matrix matrix1 = new Matrix(2, 3);
        Matrix matrix2 = new Matrix(3, 2);

        //fill the objects with values
        matrix1[0, 0] = 1;
        matrix1[0, 1] = 2;
        matrix1[0, 2] = 3;
        matrix1[1, 0] = 4;
        matrix1[1, 1] = 5;
        matrix1[1, 2] = 6;

        matrix2[0, 0] = 7;
        matrix2[0, 1] = 8;
        matrix2[1, 0] = 9;
        matrix2[1, 1] = 10;
        matrix2[2, 0] = 11;
        matrix2[2, 1] = 12;
        
        //testing
        Console.WriteLine("Printing matrices 1 and 2: ");
        Console.WriteLine(matrix2.ToString());
        Console.WriteLine(matrix1.ToString());
        Console.WriteLine("matix1*matrix2 = \n" + (matrix1 * matrix2));

        Matrix matrix3 = new Matrix(3, 3);
        Matrix matrix4 = new Matrix(3, 3);
        
        for (int i = 0; i < matrix3.Rows; i++)
        {
            for (int j = 0; j < matrix3.Cols; j++)
            {
                matrix3[i, j] = 5;
                matrix4[i, j] = 3;
            }
        }

        Console.WriteLine("Printing matrices 3 and 4: ");
        Console.WriteLine(matrix3.ToString());
        Console.WriteLine(matrix4.ToString());

        Console.WriteLine("matix3+matrix4 = \n" + (matrix3 + matrix4));
        Console.WriteLine("matix3-matrix4 = \n" + (matrix3 - matrix4));
        
    }
}