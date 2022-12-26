var matrix = new int[7, 7];
Random r = new();

int rows = matrix.GetUpperBound(0) + 1;
int cols = matrix.Length / rows;

for (int row_index = 0; row_index < rows; row_index++)
{
    for (int col_index = 0; col_index < cols; col_index++)
    {
        int num = r.Next(-99, 100);
        matrix[row_index, col_index] = num;
        Console.ForegroundColor = (num % 2 == -1) ? ConsoleColor.Red : ConsoleColor.White;
        Console.Write(num switch
        {
            < -10 => "",
            < 0 => " ",
            < 10 => "  ",
            < 100 => " ",
        });
        Console.Write($"{num} ");
    }
    Console.WriteLine();
}
Console.ResetColor();
int sum = 0;

for (int row_index = 0; row_index < rows; row_index++)
{
    for (int col_index = 0; col_index < cols; col_index++)
    {
        if (matrix[row_index, col_index] % 2 == -1)
        {
            sum += Math.Abs(matrix[row_index, col_index]);
        }
    }
}

Console.WriteLine(sum);