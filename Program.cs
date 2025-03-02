//1-
Console.Write("Rakamları toplanacak sayıyı giriniz:");
string num = Console.ReadLine();
int sum = 0;

for (int i = 0; i < num.Length; i++)
{
    sum += num[i];
}

Console.WriteLine(sum);



//2
Console.WriteLine("10 ile 100 arasında bir sayı giriniz:");
double num = Convert.ToDouble(Console.ReadLine());
while (!(num < 100 && num > 10))
{
    Console.WriteLine("Lütfen tekrar girin");
    num = Convert.ToDouble(Console.ReadLine());
}

Console.WriteLine("Doğru. Sayı 10 ile 100 arasındadır.");


//3
List<int> ages = new List<int>();

foreach (var age in ages)
{
    if ( age <= 12 && age >= 0 )
    {
        Console.WriteLine($"{age} yaşındaki kişi çocuktur.");
    }

    else if ( age <= 19 && age >= 13 )
    {
        Console.WriteLine($"{age} yaşındaki kişi gençtir.");
    }
    else if ( age >= 20 && age <= 64 )
    {
        Console.WriteLine($"{age} yaşındaki kişi yetişkindir.");
    }
    else if ( age >= 65 )
    {
        Console.WriteLine($"{age} yaşındaki kişi yaşlıdır.");
    }
}




//4
char[] chars = new char[] { 'a', 'b', 'c', 'a', 'c', 'e', 'f', 'g', 'l' };

Array.Sort(chars);
List<char> charList = new List<char>();

for (int i = 0; i < chars.Length - 1; i++)
{
    if (chars[i + 1] == chars[i])
    {
        char multivar = chars[i];
        charList.Add(multivar);
    }
    
}

foreach (var selectedChar in charList)
{
    Console.Write(selectedChar + ", ");
}



//5
String[] wordsarr = new String[] { "car", "glass", "flower", "cat", "array", "comfortable" };

List<String> FindMinLengthWord() 
{
    List<String> minLengthWords = new List<String>();
    string minLengthWord = wordsarr[0];

    for (int i = 0; i < wordsarr.Length - 1; i++)
    {
        if (wordsarr[i].Length > wordsarr[i + 1].Length)
        {
            minLengthWord = wordsarr[i + 1];
            minLengthWords.Add(minLengthWord);
        }
        else if (wordsarr[i].Length == wordsarr[i + 1].Length)
        {
            minLengthWords.Add(wordsarr[i]);
            minLengthWords.Add(wordsarr[i + 1]);
        }
    }

    return minLengthWords;
}

List<String> FindMaxLengthWord()
{
    List<String> maxLengthWords = new List<String>();
    string maxLengthWord = wordsarr[0];

    for (int i = 0; i < wordsarr.Length - 1; i++)
    {
        if (wordsarr[i].Length < wordsarr[i + 1].Length)
        {
            maxLengthWord = wordsarr[i + 1];
            maxLengthWords.Add(maxLengthWord);
        }
        else if (wordsarr[i].Length == wordsarr[i + 1].Length)
        {
            maxLengthWords.Add(wordsarr[i]);
            maxLengthWords.Add(wordsarr[i + 1]);
        }
    }

    return maxLengthWords;
}




//6
string input = Console.ReadLine();
string[] words = input.Split(' ');

Array.Sort(words);
foreach (var word in words)
{
    Console.WriteLine(word);
}


//7
int size = 0;
string[] arr = new string[size];

Console.WriteLine("Kelime girin (bitirmek için boş bir satır girin):");

while (true)
{
    string input = Console.ReadLine();

    if (string.IsNullOrEmpty(input))
    {
        break;
    }

    Array.Resize(ref arr, size + 1);

    arr[size] = input;
    size++;
}
Console.WriteLine("\nGirilen Kelimeler:");
foreach (var word in arr)
{
    Console.WriteLine(word);
}


//8
Console.Write("Lütfen kelime giriniz:");
List<String> words = new List<String>();

while (true)
{
    string input = Console.ReadLine();

    if (string.IsNullOrEmpty(input))
    {
        break;
    }

    words.Add(input);
}

words.Reverse();

foreach (var word in words)
{
    Console.Write(word + " ");
}


//9
Console.Write("Lütfen sayıları girin:");

List<Double> numbers = new List<Double>();

while (true)
{
    double number = Convert.ToDouble(Console.ReadLine());
    if (number != null)
    {
        numbers.Add(number);
    }
    else
    {
        break;
    }

}

numbers.Sort();

double average = 0;
if (numbers.Count > 0)
{
    average = numbers.Average();
}

foreach (var number in numbers)
{
    Console.WriteLine(number);
}

Console.WriteLine($"\nSayilerin Ortalaması: {average}");


//10
List<int> numbers = new List<int>  { 1, 20, 5, 9, 10, 7, 13, 24, 15, 2, 0, 3, 70, 30 };

numbers.RemoveAll(number => number < 10);
Console.WriteLine("Güncellenmiş liste:");
Console.WriteLine(string.Join(", ", numbers));


//11
List<int> grades = new List<int> { 1, 20, 5, 9, 10, 7, 13, 24, 15, 2, 0, 3, 70, 30, 80, 90, 99, 6, 49};

foreach (var grade in grades)
{
    Console.Write(grade + " ");
}

Console.WriteLine("Güncellenmiş liste:");
List<int> updatedGrades = grades.Select(g => g < 50 ? 50 : g).ToList();
Console.WriteLine(string.Join(", ", updatedGrades));

