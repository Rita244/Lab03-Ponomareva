// // Console.WriteLine("Hello, World!");

// Console.WriteLine("Банковский счёт");

// double balance = 1000;
// Console.WriteLine($"Начальный баланс: {balance}");

// balance += 500;
// Console.WriteLine($"После пополения на 500: {balance}");

// balance -= 200;
// Console.WriteLine($"После покупки на 200: {balance}");

// balance *= 1.05;
// Console.WriteLine($"После начисления на 5%: {balance}");

// // balance /= 2;
// // Console.WriteLine($"После деления пополам: {balance}");

// Console.WriteLine();
// Console.WriteLine("Постфикс vs префикс");

// int lessonNumber = 1;
// Console.WriteLine($"lessonNumber++ выводит: {lessonNumber++}");
// Console.WriteLine($"После этого lessonNumber = {lessonNumber}");

// int weekNumber = 1;
// Console.WriteLine($"++weekNumber выводит: {++weekNumber}");
// Console.WriteLine($"После этого weekNumber = {weekNumber}");

// Console.WriteLine();
// Console.WriteLine("Практическая ловушка");

// int attempts = 0;
// Console.WriteLine($"Попытка № {++attempts}");
// Console.WriteLine($"Попытка № {++attempts}");
// Console.WriteLine($"Всего попыток: {++attempts}");

// Console.WriteLine();
// Console.WriteLine($"Операторы сравнения");

// double myGrade = 4.6;
// double passingGrade = 4.0;
// int myAge = 20;
// int votingAge = 18;
// bool isPassing = myGrade >= passingGrade;
// bool isExactAge = myAge == votingAge;
// bool canVote = myAge >= votingAge;
// bool isNotFailing = myAge != 2.0;

// Console.WriteLine($"Балл: {myGrade} >= {passingGrade}: {isPassing}");
// Console.WriteLine($"Возраст: {myAge} == {votingAge}: {isExactAge}");
// Console.WriteLine($"Возраст: {myAge} >= {votingAge} (может голосовать): {canVote}");
// Console.WriteLine($"Балл: {myGrade} != 2.0 (не двойка): {isNotFailing}");


// Console.WriteLine();
// Console.WriteLine("Логичекие операторы");

// bool hasPassingGrade = true;
// bool hasAttendane = false;
// bool hasDebt = true;

// bool canGetScholarship = hasPassingGrade && hasAttendane;
// bool canRetakeExam = hasPassingGrade || hasAttendane;
// bool isDebtFree = !hasDebt;

// Console.WriteLine($"Может получить стипендию (оценка и посещаемость): {canGetScholarship}");
// Console.WriteLine($"Может пересдать (оценка ИЛИ посещаемость): {canGetScholarship}");
// Console.WriteLine($"Нет долгов: {isDebtFree}");


// Console.WriteLine();
// Console.WriteLine("Приоритет операций");

// int resultNoParens = 2 +( 3 * 4);
// int resiltWithParens = (2 + 3) * 4;
// Console.WriteLine($"2 + 3 * 4   = {resultNoParens}");
// Console.WriteLine($"(2 + 3) * 4   = {resiltWithParens}");

// bool logicResult = (5 > 3) && (2 < 4);
// bool logicResultParens = (5 > 3 && 2 < 4);

// Console.WriteLine($"5>3 && 2<4 || false   = {logicResult}");
// Console.WriteLine($"(5>3 && 2<4) || false   = {logicResultParens}");

Console.WriteLine();
Console.WriteLine("Приоритет операций");

int resultNoParens = 2 +( 3 * 4);
int resiltWithParens = (2 + 3) * 4;
Console.WriteLine($"2 + 3 * 4   = {resultNoParens}");
Console.WriteLine($"(2 + 3) * 4   = {resiltWithParens}");

bool logicResult = (5 > 3) && (2 < 4);
bool logicResultParens = (5 > 3 && 2 < 4);

Console.WriteLine($"5>3 && 2<4 || false   = {logicResult}");
Console.WriteLine($"(5>3 && 2<4) || false   = {logicResultParens}");