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
// // Console.WriteLine($"Попытка № {++attempts}");
// // Console.WriteLine($"Попытка № {++attempts}");
// // Console.WriteLine($"Всего попыток: {++attempts}");

// // Console.WriteLine();
// // Console.WriteLine($"Операторы сравнения");

// // double myGrade = 4.6;
// // double passingGrade = 4.0;
// // int myAge = 20;
// // int votingAge = 18;
// // bool isPassing = myGrade >= passingGrade;
// // bool isExactAge = myAge == votingAge;
// // bool canVote = myAge >= votingAge;
// // bool isNotFailing = myAge != 2.0;

// // Console.WriteLine($"Балл: {myGrade} >= {passingGrade}: {isPassing}");
// // Console.WriteLine($"Возраст: {myAge} == {votingAge}: {isExactAge}");
// // Console.WriteLine($"Возраст: {myAge} >= {votingAge} (может голосовать): {canVote}");
// // Console.WriteLine($"Балл: {myGrade} != 2.0 (не двойка): {isNotFailing}");


// // Console.WriteLine();
// // Console.WriteLine("Логичекие операторы");

// // bool hasPassingGrade = true;
// // bool hasAttendane = false;
// // bool hasDebt = true;

// // bool canGetScholarship = hasPassingGrade && hasAttendane;
// // bool canRetakeExam = hasPassingGrade || hasAttendane;
// // bool isDebtFree = !hasDebt;

// // Console.WriteLine($"Может получить стипендию (оценка и посещаемость): {canGetScholarship}");
// // Console.WriteLine($"Может пересдать (оценка ИЛИ посещаемость): {canGetScholarship}");
// // Console.WriteLine($"Нет долгов: {isDebtFree}");


// // Console.WriteLine();
// // Console.WriteLine("Приоритет операций");

// // int resultNoParens = 2 +( 3 * 4);
// // int resiltWithParens = (2 + 3) * 4;
// // Console.WriteLine($"2 + 3 * 4   = {resultNoParens}");
// // Console.WriteLine($"(2 + 3) * 4   = {resiltWithParens}");

// // bool logicResult = (5 > 3) && (2 < 4);
// // bool logicResultParens = (5 > 3 && 2 < 4);

// // // Console.WriteLine($"5>3 && 2<4 || false   = {logicResult}");
// // // Console.WriteLine($"(5>3 && 2<4) || false   = {logicResultParens}");

// // Console.WriteLine();
// // Console.WriteLine("Приоритет операций");

// // int resultNoParens = 2 +( 3 * 4);
// // int resiltWithParens = (2 + 3) * 4;
// // Console.WriteLine($"2 + 3 * 4   = {resultNoParens}");
// // Console.WriteLine($"(2 + 3) * 4   = {resiltWithParens}");

// // bool logicResult = (5 > 3) && (2 < 4);
// // bool logicResultParens = (5 > 3 && 2 < 4);

// // Console.WriteLine($"5>3 && 2<4 || false   = {logicResult}");
// // Console.WriteLine($"(5>3 && 2<4) || false   = {logicResultParens}");

// Console.WriteLine();
// Console.WriteLine("Приёмная комиссия");

// Console.Write("Введите средний балл аттестата: ");
// double averageGrade = double.Parse(Console.ReadLine());

// Console.Write("Введите баллы за экзамен (0-100): ");
// int examScore = int.Parse(Console.ReadLine());

// Console.Write("Есть льгота? (1 - да, 0 - нет): ");
// int benefitInput = int.Parse(Console.ReadLine());
// bool hasBenefit = (benefitInput == 1);

// // TODO 1
// bool hasGoodCertificate = averageGrade >= 4.0;

// // TODO 2
// bool hasGoodExam = examScore >= 60;

// // TODO 3
// bool isEligibleByRules = (hasGoodCertificate && hasGoodExam) || hasBenefit;

// // TODO 4
// double totalScore = averageGrade * 10;
// totalScore += examScore;

// Console.WriteLine();
// Console.WriteLine("Результат");
// Console.WriteLine($"Хороший аттестат (>= 4.0): {hasGoodCertificate}");
// Console.WriteLine($"Хороший экзамен (>= 60): {hasGoodExam}");
// Console.WriteLine($"Льгота: {hasBenefit}");
// Console.WriteLine($"Проходит по правилам: {isEligibleByRules}");
// // Console.WriteLine($"Итоговый балл: {totalScore}");

// Console.WriteLine();
// Console.WriteLine("Чётное или нечётное");

// // Console.Write("Введите целое число: ");
// // int number = int.Parse(Console.ReadLine());

// // bool isEven = number % 2 == 0;

// // Console.WriteLine($"Чётное: {isEven}");

// Console.WriteLine();
// Console.WriteLine("Инкремент в выражениях");  // x++ сначала возвращает старое значение,
// // а затем увеличивает x на 1.
// int x = 5;
// Console.WriteLine($"x++: {x++}");
// Console.WriteLine($"После x++: {x}");  // ++x сначала увеличивает x,
// // а затем возвращает новое значение.
// x = 5;
// Console.WriteLine($"++x: {++x}");
// Console.WriteLine($"После ++x: {x}"); // разница видна при вычислении выражения.
// x = 5;
// int resultPostfix = x++ + 10;
// Console.WriteLine($"x++ + 10 = {resultPostfix}, x = {x}");

// x = 5;
// int resultPrefix = ++x + 10;
// Console.WriteLine($"++x + 10 = {resultPrefix}, x = {x}");

Console.WriteLine();
Console.WriteLine("Задание 3. Калькулятор скидки");

Console.Write("Введите сумму покупки: ");
double purchaseAmount = double.Parse(Console.ReadLine());

Console.Write("Есть карта постоянного клиента? (1 - да, 0 - нет): ");
int cardInput = int.Parse(Console.ReadLine());
bool hasLoyaltyCard = cardInput == 1;

Console.Write("Введите количество товаров в чеке: ");
int itemCount = int.Parse(Console.ReadLine());

bool amountAndItemsCondition = purchaseAmount >= 3000 && itemCount >= 3;
bool eligibleForDiscount = amountAndItemsCondition || hasLoyaltyCard;

Console.WriteLine();
Console.WriteLine($"Сумма >= 3000: {purchaseAmount >= 3000}");
Console.WriteLine($"Товаров >= 3: {itemCount >= 3}");
Console.WriteLine($"Сумма >= 3000 И товаров >= 3: {amountAndItemsCondition}");
Console.WriteLine($"Есть карта постоянного клиента: {hasLoyaltyCard}");
Console.WriteLine($"Итоговое право на скидку: {eligibleForDiscount}");