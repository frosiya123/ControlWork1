//  Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длинна которых меньше тлт равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. Про решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// **Например**
// [Hello, 2, world, :-)] -> [2, :-)]
// [1234, 1567, -2, computer science]->[-2 ]
// [Russia, Denmark, Kazzan] ->[]

string[] arr = new string[4];
string[] arr2 = new string[4];

int j = 0;
for(int i = 0; i < arr.Length; i++){
     Console.Write("Введите значение:");
     arr[i] = Console.ReadLine();

    if( arr[i].Length < 4 ){
	arr2[j] = arr[i];
	j++;
    }
}
Console.WriteLine();
Console.WriteLine("Сформированный массив: [" + string.Join(", ", arr) + "]");
Console.WriteLine();
Array.Resize(ref arr2,j);

for(int i = 0; i < arr2.Length; i++){
 }
Console.WriteLine("Полученный массив: [" + string.Join(", ", arr2) + "]");