// 1. Заполнить массив нулями, кроме первого и последнего элементов, которые должны быть равны единице.

int beginArray = 1;
int bodyArray = 0;

var arrayZeroBeginAndEndOne = new int[] { beginArray, bodyArray, bodyArray, bodyArray, beginArray };

Console.WriteLine("1) Заполнить массив нулями, кроме первого и последнего элементов, которые должны быть равны единице : ");

foreach (var arrayValue in arrayZeroBeginAndEndOne)
{
    Console.Write(arrayValue);
}

//наверно какое то динамическое заполнение есть типа начало и конец ? в задании не указан размер массива, и что он должен быть динамическим, как поступить ?
//я выполнила как написано ?

Console.WriteLine("\n");


// 2. Заполнить массив нулями и единицами, при этом данные значения чередуются, начиная с нуля.

var alternatingNumbers = new int[11];

Console.WriteLine("2) Заполнить массив нулями и единицами, при этом данные значения чередуются, начиная с нуля : ");

for (int i = 0; i < alternatingNumbers.Length; i++)
{
    Console.Write($"{(alternatingNumbers[i] = 0)} ");
    Console.Write($"{(alternatingNumbers[i] = 1)} ");
}

//тут я задаю фиксированную величину массива, вообще если ТЗ не говорит величину, то как решать до каких пор заполнять этот массив ?


Console.WriteLine("\n");

// 3. Сформировать возрастающий массив из четных чисел.

var arrayevenNumberPlus = new int[22];

Console.WriteLine("3) Сформировать возрастающий массив из четных чисел : ");

for (int i = 0; i < arrayevenNumberPlus.Length; i++)
{
    var arrayVozrastayushiy = arrayevenNumberPlus[0] += 2;
    
    Console.Write($"{(arrayVozrastayushiy++)} > ");
}

//как смогла так и додумалась, зато сама. Готова к критике и улучшению навыков !!!

Console.WriteLine("\n");