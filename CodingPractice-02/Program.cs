using System;
using static System.Console;


// README.md를 읽고 아래에 코드를 작성하세요.


// 1
Calculator calc = delegate (int i) { return i * i; };
WriteLine(calc(5));

WriteLine();

// 2
int factor = 3;
Func<int, int> multiplier = delegate (int n) { return n * factor; };
WriteLine(multiplier(10));

WriteLine();


// 3
int factor1 = 2;
Func<int, int> multiplier1 = delegate (int n) { return n * factor1; };
WriteLine($"factor = 2일 때: {multiplier1(5)}");
factor1 = 10;
WriteLine($"factor = 10일 때: {multiplier1(5)}");

WriteLine();

// 4
int counter = 0;
Action increment = delegate { counter++; WriteLine($"현재 카운터: {counter}"); };

increment();
increment();
increment();

WriteLine($"최종 카운터: {counter}");

WriteLine();

// 출력값이 1233이 되는 이유 =
// 익명 메서드는 캡처한 지역변수를 수정할 수 있음
// 캡처를 해서 counter의 값이 올라가고, 마지막 최종 카운터를 출려했기에
// 1233이 출력됨

// 5

Func<int> counter1 = CreateCounter();
Func<int> counter2 = CreateCounter();

WriteLine($"counter1: {counter1()}");
WriteLine($"counter1: {counter1()}");
WriteLine($"counter1: {counter1()}");
WriteLine($"counter2: {counter2()}");
WriteLine($"counter2: {counter2()}");


// count++ 를 해서 int 를 반환하는 익명 메서드를 반환하는 CreateCounter함수
static Func<int> CreateCounter()
{
    int count = 0;
    return delegate
    {
        count++;
        return count;
    };
}










delegate int Calculator(int i);
