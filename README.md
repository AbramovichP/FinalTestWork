
# Итоговая проверочная работа.


## Задача:

> Написать программу, которая из имеющегося массива строк формирует массив из строк,
длинна которых меньше либо равна 3 символа. Первоначальный массив можно ввести с
клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется
пользоваться коллекциями, лучше обойтись исключительно массивами.
_____

* [Блок-схема](blockdiagram.drawio.png)
* [Код](Program.cs)


1. **Создание массива**:
    * Запросить у пользоателя кол-во элементов в массиве.
    * Запрос ввода самих элементов
2. **Вывод созданного массива**
3. **Поиск (составление) нового массива**:
    * Поиск строк длина которых меньше либо равна 3 символа.
    * формирование из найденных элементов нового массива.
4. **Вывод нового массива**


Описание методов кода:

> string[] CreateArrayWords(int elements)

Метод  создает массив из введеных пользователем элементов с клавиатуры</br>
*elements* - кол-во элементов массива(задается пользователем с клавиатуры)

> int ElementCount(string[] words)

Метод принимает на вход массив и считает кол-во искомых элементов меньше или равных 3</br>
*words* - входящий массив

> string[] FormingArrayStrings(string[] words, int count)

Метод формирует новый массив из элементов входящего массива согласно условиям задачи</br>
words - входящий массив</br>
count - длина нового массива

