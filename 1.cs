using System.Numerics;

class MyMatrix
{
    private int[,] matrix;
    public int rows;
    public int cols;

    public MyMatrix(int rows, int cols, int minV, int maxV)
    {
        matrix = new int[rows, cols];
        this.rows = rows;
        this.cols = cols;

        Fill(rows, cols, minV, maxV);
    }

    public void Fill(int rows, int cols, int minV, int maxV)
    {
        Random rand = new Random();

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = rand.Next(minV, maxV + 1);
            }
        }
    }

    public void ChangeSize(int newRows, int newCols, int minV, int maxV)
    {
        int[,] newMatrix = new int[newRows, newCols];
        Random rand = new Random();

        for (int i = 0; i < Math.Min(matrix.GetLength(0), newRows); i++)
        {
            for (int j = 0; j < Math.Min(matrix.GetLength(1), newCols); j++)
            {
                newMatrix[i, j] = matrix[i, j];
            }
        }

        for (int i = 0; i < newRows; i++)
        {
            for (int j = 0; j < newCols; j++)
            {
                if (newMatrix[i, j] == 0)
                {
                    newMatrix[i, j] = rand.Next(minV, maxV + 1);
                }
            }
        }
    }

    public void ShowPartialy(int startRow, int startCol, int endRow, int endCol)
    {
        for (int i = startRow; i < endRow; i++)
        {
            for (int j = startCol; j < endCol; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    public void Show()
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    public int this[int index1, int index2]
    {
        get { return matrix[index1, index2]; }
        set { matrix[index1, index2] = value; }
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Введите количесвто строк: ");
        int rows = int.Parse(Console.ReadLine());

        Console.Write("Введите количество столбцов: ");
        int cols = int.Parse(Console.ReadLine());

        Console.Write("Введите минимальное значение: ");
        int minV = int.Parse(Console.ReadLine());

        Console.Write("Введите максимальное значение: ");
        int maxV = int.Parse(Console.ReadLine());

        MyMatrix matrix = new MyMatrix(rows, cols, minV, maxV);

        Console.WriteLine("Матрица:");
        matrix.Show();

        Console.Write("Введите количество новых строк: ");
        int newRows = int.Parse(Console.ReadLine());

        Console.Write("Введите количество новых столбцов: ");
        int newCols = int.Parse(Console.ReadLine());

        MyMatrix newMatrix = new MyMatrix(newRows, newCols, minV, maxV);

        Console.WriteLine("Новая матрица:");
        newMatrix.Show();

        Console.Write("Введите начальную строку: ");
        int startRow = int.Parse(Console.ReadLine());

        Console.Write("Введите начальный столбец: ");
        int startCol = int.Parse(Console.ReadLine());

        Console.Write("Введите конечную строку: ");
        int endRow = int.Parse(Console.ReadLine());

        Console.Write("Введите конечный столбец: ");
        int endCol = int.Parse(Console.ReadLine());

        Console.WriteLine("Часть матрицы:");
        newMatrix.ShowPartialy(startRow, startCol, endRow, endCol);
    }
}