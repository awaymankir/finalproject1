﻿Console.WriteLine("Укажите - из скольки элементов состоит Ваш массив? ");
int size  = int.Parse(Console.ReadLine()); //вводим размер массива

string[] arr1 = new string[size];

for (int i = 0; i < size; i++){
	Console.Write("Введите элемент массива - символы, слова или числовые выражения: ");
    string result = Console.ReadLine(); //вводим элементы из которых состоит массив
	arr1[i] = result;  
}
Console.WriteLine();
Console.Write("Введенный Вами массив: [" + string.Join("  ", arr1) + "]");
//Console.Write(string.Join("  ", arr1));
//Console.Write(" ]");

int count = 0;
int maxElements = 3;

for (int i = 0; i < arr1.Length; i++){
	if(arr1[i].Length <= maxElements){
		count++;
	}   
}
Console.WriteLine();
Console.WriteLine();
Console.Write("Массив, удовлетворяющий условию задачи: [");
string[] arr2 = new string[count];
int j = 0;
for (int i = 0; i < arr1.Length; i++){
    if(arr1[i].Length <= maxElements){
        arr2[j] = arr1[i];
        Console.Write(arr2[j] + " ");
        j++;
    }
}
Console.Write("]");