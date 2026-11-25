using System;

string subject = "Программирование";
foreach (char letter in subject)
{
    Console.WriteLine(letter);
}
Console.WriteLine($"Общее количество букв: {subject.Length}");

Console.WriteLine();

int[] grades = { 4, 5, 3, 5, 4 };
int gradesSum = 0;
foreach (int grade in grades)
{
    Console.WriteLine(grade);
    gradesSum += grade;
}
Console.WriteLine($"Средний балл: {(double)gradesSum / grades.Length}");

Console.WriteLine();

string[] students = { "Аня", "Ярослав", "Вика" };
int studentCount = 0;
foreach (string student in students)
{
    Console.WriteLine(student);
    studentCount++;
}
Console.WriteLine($"Всего учеников в массиве: {studentCount}");

Console.WriteLine();

int[] points = { 10, 20, 15 };
for (int i = 0; i < points.Length; i++)
{
    points[i] = points[i] + 5;
    Console.WriteLine(points[i]);
}

Console.WriteLine();

string[] numStudents = { "Аня", "Борис", "Вика" };
int number = 1;
foreach (string student in numStudents)
{
    Console.WriteLine($"{number}. {student}");
    number++;
}

Console.WriteLine();

// Задача А
int[] arrayA = { 12, 7, 5, 23, 8 };
int sumA = 0;
foreach (int val in arrayA)
{
    Console.WriteLine(val);
    sumA += val;
}
Console.WriteLine($"Сумма элементов: {sumA}");

Console.WriteLine();

// Задача Б
string[] days = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
foreach (string day in days)
{
    Console.WriteLine($"{day}!");
}

Console.WriteLine();

// Вариант 1
int[] weekTemps = { 3, -1, 0, 4, 2, -2, 5 };
int tempSum = 0;
foreach (int t in weekTemps)
{
    tempSum += t;
}
Console.WriteLine($"Средняя температура за неделю: {(double)tempSum / weekTemps.Length}");

Console.WriteLine();

// Вариант 3
string word = "конвейер";
int consonantCount = 0;
string vowels = "аеёиоуыэюя";
foreach (char ch in word.ToLower())
{
    if (!vowels.Contains(ch))
    {
        consonantCount++;
    }
}
Console.WriteLine($"В слове '{word}' количество согласных букв: {consonantCount}");
