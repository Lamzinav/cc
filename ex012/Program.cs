// Виды 1
void Method1 ()
{
    Console.WriteLine("Автор");
}
Method1();

// Вид 2
void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Method2(msg: "Текст сообщения");
// Вид 2.1
void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Method21("Текст", 4);
// Еще вариант
Method21(count: 4, msg: "новый текст");

//Вид 3

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);

//Вид 4

/*string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;   result = пустой стонке

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(10, "adsf");
Console.WriteLine(res);
*/



string Method4(int count, string text)
{
    string result = String.Empty;
     for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

string res = Method4(10, "z");
//Console.WriteLine(res);

for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        //Console.WriteLine($"{i} * {j} = {i * j}");
    }
    Console.WriteLine();
}

/*Другие определения понятия «задача» согласно международным стандартам:

деятельность, необходимая для достижения некоторой цели[2];
требуемые, рекомендуемые или допустимые действия, направленные на содействие достижению одного или нескольких результатов некоторого процесса[3];
наименьшая единица работы, подлежащая учёту; чётко определённое рабочее задание для одного или нескольких участников проекта[4].
В самом широком смысле под задачей понимается то, что нужно выполнить — задание, поручение, дело, упражнение, например логическая задача, математическая задача, шахматная задача.
*/
string text = "Выделяют следующие характеристики условия задачи"
            + "Привычность или непривычность ситуации, новизна задачи для субъекта"
            + "Степень выделенности (явности) существенных отношений"
            + "Форма условий (реальная ситуация / изображение / словесное описание)"
            + "Соотношение условия — решение: условия достаточны / недостаточны / избыточны для решения.";


// stingt s = "asdf"    
//             0123  
//   s[3]  // r

string Replace(string text, char oldvalue, char newValue)
{
  string result = String.Empty; 

  int length = text.Length;
  for (int i = 0; i < length; i++)
  {
    if(text[i] == oldvalue) result = result + $"{newValue}";
    else result = result + $"{text[i]}";
  } 

  return result;
}

string newText = Replace(text, ' ', '|');

Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);


int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
   Console.WriteLine(); 
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);