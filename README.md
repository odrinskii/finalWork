# Итоговая работа

**Задача:**
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами. 

**Примеры**

["hello", "2", world", ":-)"]->["2", ":-)"]

["1234", "1567", "-2", "computer sciens"]->["-2"]

["Russia", "Denmark", "Kazan"]->[]


## Первый этап. Создание методов. 

1. **Метод создания нового массива путём пользовательского ввода элементов массива(CreateStringArray).** 
    * На вход берем пустой массив известной длины;
    * С помощью цикла *for* при каждой итерации запрашиваем пользовательский ввод с клавиатуры до того момента пока не переберем все индексы массива;
    * Записываем каждый пользовательский ввод как значение массива, соответствующее индексу текущей итерации;
    * Возвращаем заполненный массив;

**Блок-схема метода 1.**
![Блок-схема](/images/1.png)

2. **Метод вывода на экран одномерного массива(PrintArray).** 
    * На вход берем известный массив;
    * С помощью цикла *for* при каждой итерации выводим на экран значение массива, соответсвующего индекса, до того момента пока индекс массива меньше его длины;
    
**Блок-схема метода 2.** ![Блок-схема2](/images/2.png)


3. **Метод поиска элементов с количеством символов меньше или равно 3 и создание нового массива с этими элементами(NewStringArray).** 
    * На вход берем известный массив;
    * Задаем новую переменную в виде счетчика для цикла *for*,  с помощью которой будем считать количество элементов, соответствующих массиву;
    * Создаем цикл *for*, с помощью которого проверяем выполнение условия "*количество символов элемента массива меньше или равно 3*", при выполнении условия считаем количество подошедших условию элементов;
    * После того как получаем количество таких элементов создаем новый массив, длина которого равна этому количеству, задаём переменную для использования в качестве индекса нового массива;
    * Снова создаем цикл *for*, с помощью которого проверяем выполнение условия "*количество символов элемента массива меньше или равно 3*", при выполнении условия записываем в новый массив значение элемента, с соответсвтующим итерации индексом, в случае выполнения условия увеличиваем индекс обоих массивов на 1, при невыполнении увеличиваем только индекс изначально созданного массива;
    * На выходе возвращаем новый массив, созданный из элементов, удовлетворящих условию;


**Блок-схема метода 3.** ![Блок-схема3](/images/3.png)


## Второй этап. Пользовательский ввод, вывод нужного результата на экран с помощью созданных методов.

1. **Запрашиваем пользовательский ввод для обозначения длины первоначального массива;**
2. **При выполнении условия, что *длина массива больше 0*, выполняем необходимые операции, а именно:** 
    * Создаем новый массив с размером, введенным пользователем ранее;
    * Выводим массив на экран при помощи ранее описанного метода *"PrintArray";*
    * Создаем новый массив, в который записываем все элементы, удовлетворяющие условию задачи, делаем это с помощью метода *"NewStringArray";*
    * Выводим полученный результат на экран;
3. **Если условие *длина массива больше 0* не выполняется, выводим на экран сообщение об ошибке.**

**Блок-схема второго этапа.** ![Блок-схема4](/images/4.png)
