# Задача

Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массива
## Что необходимо для решения
1. Создать репозиторий на GitHub
2. Нарисовать блок-схему алгоритма
3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
4. Написать программу, решающую поставленную задачу
5. Использовать контроль версий
## Решение
1. Создан репозиторий  - *(FinalVerificationWork)*
2. В папке Блок-схема создан файл с изображением блок-схемы (первый вариант в программе drawio, второй - png).
3. Алгоритм решения задачи
* Создается массив 1, в котором указываются необходимые строки
* Создается массив 2, в котором будут записаны новые значения
* В функциии создаётся счётчик новых элементов, которые будут последовательно добавлены в новый массив 2. Далее циклом проверяется в  массиве 1, соответствует ли элемент условию "длина символов <= 3". Если да, то этот элемент добавляется в массив 2. После того как цикл будет закончен программа выдаст результат в массиве 2, который и выведется пользователю.
4. В папке Программа решение задачи на C#.