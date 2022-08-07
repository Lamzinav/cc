int [] array = { 11, 211, 31, 4, 15, 4, 17, 18, 19};

int n = array.Length;
int find = 4;

int  index = 0;

while (index < n)
{

    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    //index = index + 1;
    index++;
}