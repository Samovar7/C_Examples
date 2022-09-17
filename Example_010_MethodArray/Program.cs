int[] array = {10,70,36,41,12,22,70,16};

int n = array.Length;
int find = 70;
int index = 0;

while (index < n)
{
    if (array[index] == find)
    {{
        Console.WriteLine($"Искомый элемент {find} находится на {index} позиции в массиве");
        break;
    }}


    index++;
}
