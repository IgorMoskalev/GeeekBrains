void fillarray 


int [] array = new int[10];
int n = array.Length;
int find = 4;
int index = 0;
while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}