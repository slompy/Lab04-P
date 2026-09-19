// int score = int.Parse(Console.ReadLine()!);

// if (score >= 1000) {
//     System.Console.WriteLine("Бонусный уровень открыт");
// }
// else {
//     System.Console.WriteLine("Бонусный уровень закрыт");
// }

// System.Console.WriteLine("Игра продолжается");

// int score = int.Parse(Console.ReadLine()!);

// if (score < 500) {
//     Console.WriteLine("Новичок")
// } else if (score < 2000) {
//     System.Console.WriteLine("Боец");
// } else {
//     System.Console.WriteLine("Мастер");
// }

// int score = int.Parse(Console.ReadLine()!);
// int lives = 2;
// bool cheatCode = true;
// if (score >= 1000 && lives >= 1) {
//     System.Console.WriteLine("Секретный уровень открыт");
// } else if (cheatCode == true) {
//     System.Console.WriteLine("Секретный уровень открыт");
// } else {
//     System.Console.WriteLine("Пока нельзя");
// }

// int movieNumber = int.Parse(Console.ReadLine()!);

// string movieGenre;

// switch (movieNumber)
// {
//     case 1: movieGenre = "Боевик"; break;
//     case 2: movieGenre = "Комедия"; break;
//     case 3: movieGenre = "Драма"; break;
    
//     default: movieGenre = "Другой жанр"; break;
// }

// Console.WriteLine(movieGenre);

// int score = 3200;
// int recordScore = 3000;

// string result = (score > recordScore) ? "Новый рекорд" : "Обычный результат";


// if(score > recordScore) {
//     result = "Новый рекорд";
// } else {
//     result = "Обычный результат!";
// }
// Console.WriteLine(result);


// int age = 15;
// if (age >= 18) {
//     Console.WriteLine("Доступ разрешён");
// } else {
//     Console.WriteLine("Доступ запрещён");
// }
// Console.WriteLine("Программа продолжает работу");

// int age = 67;
// if (age < 13) {
//     Console.WriteLine("Ребёнок");
// } else if (age < 18) {
//     Console.WriteLine("Подросток");
// } else {
//     Console.WriteLine("Взрослый");
// }
   

// int age = 16;
// double height = 1.4;
// if (age >= 14 && height >= 1.5) {
//     Console.WriteLine("Можно кататься");
// } else {
//     Console.WriteLine("Нельзя кататься");
// }






// Задача А
System.Console.Write("Введите целое число:");
int yourNumber = int.Parse(Console.ReadLine());

if (yourNumber % 2 == 0) {
    Console.WriteLine("Число чётное");
}
else {
    Console.WriteLine("Число нечётное");
}


// Задача Б
System.Console.Write("Введите оценку (от 2 до 5):");
int yourScore = int.Parse(Console.ReadLine());

if (yourScore == 5) {
    Console.WriteLine($"{yourScore} — 'Отлично'");
} else if (yourScore == 4) {
    Console.WriteLine($"{yourScore} — 'Хорошо'");
} else if (yourScore == 3) {
    Console.WriteLine($"{yourScore} — 'Удовлетворительно'");
} else if (yourScore == 2) {
    Console.WriteLine($"{yourScore} — 'Неудовлетворительно'");
} else {
    Console.WriteLine("Неверная оценка");
}
