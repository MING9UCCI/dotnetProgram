// // 기본예제 3-3 홀수 입력 구분(3)
// Console.Write("숫자 입력: ");
// int input = int.Parse(Console.ReadLine());

// if (input % 2 == 0) 
// {
//     Console.WriteLine("짝수입니다!");
// }

// else
// {
//     Console.WriteLine("홀수입니다!");
// }

// // 기본예제 3-4 오전과 오후 구분(2)
// if (DateTime.Now.Hour < 12)
// {
//     Console.WriteLine("오전입니다.");
// }
// else
// {
//     Console.WriteLine("오후입니다.");
// }

// // 기본예제 3-5 중첩 조건문 활용
// if (DateTime.Now.Hour < 11)
// {
//     Console.WriteLine("아침 먹을 시간입니다.");
// }
// else
// {
//     if (DateTime.Now.Hour < 15)
//     {
//         Console.WriteLine("점심 먹을 시간입니다.");
//     }
//     else
//     {
//         Console.WriteLine("저녁 먹을 시간입니다.");
//     }
// }

// // 기본예제 3-6 if else if 조건문 활용
// if (DateTime.Now.Hour < 11)
// {
//     Console.WriteLine("아침 먹을 시간입니다.");
// }
// else if (DateTime.Now.Hour < 15)
// {
//     Console.WriteLine("점심 먹을 시간입니다.");
// }
// else
// {
//     Console.WriteLine("저녁 먹을 시간입니다.");
// }

// // 기본예제 3-7 switch 조건문 활용
// Console.Write("숫자 입력: ");
// int input = int.Parse(Console.ReadLine());

// switch (input % 2)
// {
//     case 0:
//         Console.WriteLine("짝수입니다.");
//         break;
//     case 1:
//         Console.WriteLine("홀수입니다.");
//         break;
// }

// Console.Write("이번 달은 몇 월인가요?: ");
// int input = int.Parse(Console.ReadLine());

// switch (input)
// {
//     case 12:
//     case 1:
//     case 2:
//         Console.WriteLine("겨울입니다.");
//         break;
//     case 3:
//     case 4:
//     case 5:
//         Console.WriteLine("봄입니다.");
//         break;
//     case 6:
//     case 7:
//     case 8:
//         Console.WriteLine("여름입니다.");
//         break;
//     case 9:
//     case 10:
//     case 11:
//         Console.WriteLine("가을입니다.");
//         break;
//     default:
//         Console.WriteLine("대체 어느 행성에 살고 계신가요?");
//         break;
// }

// // 기본예제 3-9 삼항 연산자
// string input = Console.ReadLine();
// int number = int.Parse(input);

// Console.WriteLine(number > 0 ? "자연수입니다." : "자연수가 아닙니다.");

// ---------------------------------------------------------------------------------------------------------------------------------

// 1. 중첩 조건문을 사용하여 사용자에게 입력받은 숫자가 양수인지, 음수인지, 0인지 판단하여 출력하는 프로그램을 작성하라.
Console.Write("숫자 입력: ");
int input = int.Parse(Console.ReadLine());

if (input > 0)
{
    Console.WriteLine("양수입니다.");
}
else if (input < 0)
{
    Console.WriteLine("음수입니다.");
}
else
{
    Console.WriteLine("0입니다.");
}

// 2. 삼항연산자을 사용하여 사용자에게 입력받은 숫자를 이진수로 변환하여 출력하는 프로그램을 작성하라.
Console.Write("숫자 입력: ");
int input = int.Parse(Console.ReadLine());
Console.WriteLine($"{input}의 이진수 표현: {Convert.ToString(input, 2)}");

// 3. if문을 사용하여 사용자에게 숫자 3개를 입력받아 오름차순으로 정렬하여 출력하는 프로그램을 작성하라.
Console.Write("첫 번째 숫자 입력: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("두 번째 숫자 입력: ");
int num2 = int.Parse(Console.ReadLine());
Console.Write("세 번째 숫자 입력: ");
int num3 = int.Parse(Console.ReadLine());

if (num1 <= num2 && num1 <= num3)
{
    if (num2 <= num3)
    {
        Console.WriteLine($"오름차순 정렬: {num1}, {num2}, {num3}");
    }
    else
    {
        Console.WriteLine($"오름차순 정렬: {num1}, {num3}, {num2}");
    }
}
else if (num2 <= num1 && num2 <= num3)
{
    if (num1 <= num3)
    {
        Console.WriteLine($"오름차순 정렬: {num2}, {num1}, {num3}");
    }
    else
    {
        Console.WriteLine($"오름차순 정렬: {num2}, {num3}, {num1}");
    }
}
else
{
    if (num1 <= num2)
    {
        Console.WriteLine($"오름차순 정렬: {num3}, {num1}, {num2}");
    }
    else
    {
        Console.WriteLine($"오름차순 정렬: {num3}, {num2}, {num1}");
    }
}


// 4. switch문을 사용하여, 사용자에게 입력받은 문자열에서 모음(a, e, i, o, u)의 개수를 세어 출력하는 프로그램을 작성하라.
Console.Write("문자열 입력: ");
string input = Console.ReadLine();
int Cnt = 0;
foreach (char c in input)
{
    switch (char.ToLower(c))
    {
        case 'a':
        case 'e':
        case 'i':
        case 'o':
        case 'u':
            Cnt++;
            break;
    }
}
Console.WriteLine($"모음의 개수: {Cnt}");