1. Массив array1 задается на старте выполнения алгоритма;
2. Создается массив array2 равный длине массива array1;
   Создается переменная g равная 0;


3. С помощью цикла в цикле программа выбирает из массива array1 строки, которые короче или равны 3.
   Порядок работы следующий:
    а) Во внутреннем цикле j = g, что позволяет запускать внутренний цикл не с нулегого элемента; 
    б) Если array1[j] <= 3, то array2[i] = array1[j] внутренний цикл прерывается и g++;
    б) Если array1[j] > 3, то внутренний цикл прерывается и g++;

4. Массив array2 наполняется подходящими под условие элементами массива array1, на те же места, что и в array1;

5. Элемент выводится на экран, если он не равен null.