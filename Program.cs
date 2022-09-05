void Zadacha(){
    string[] array = new string[]{"wasd", "qwerty", "boi", "12","╚╦╩"};
    Console.WriteLine("Изначальный массив");
    PrintArray(array);
    string sort = string.Empty;
    for( int i = 0; i < array.Length; i++){
        if(array[i].Length <= 3){
            sort += array[i] + ", ";
        }
    }
    
    sort = sort.Remove(sort.Length - 2);
    string[] array2 = new string[]{sort};
    Console.WriteLine("Отсортированный массив");
    PrintArray(array2);
}

void PrintArray(string[] array){
    for( int i = 0; i < array.Length; i++){
        Console.Write(array[i] + ", ");
    }
    Console.Write("\b\b.");
    Console.WriteLine();
}

Zadacha();