using System;
using static System.Console;

// README.md를 읽고 아래에 코드를 작성하세요.



// 1

// Square 메서드를 대리자에 할당
Calculator calc = Square;

WriteLine(calc(5));

// 제곱을 계산하는 Square 정적 메서드
static int Square(int x)
{
    return x * x;
}
WriteLine();

// 2
// 
Transformer square = delegate (int x)
{
    return x * x;
};

Transformer cube = delegate (int j)
{
    return j * j * j;
};

WriteLine($"3의 제곱: {square(3)}");
WriteLine($"3의 세제곱: {cube(3)}");

WriteLine();

// 3
// 익명 메서드 
Printer Hello = delegate (string message) { WriteLine($"[메시지] {message}"); };

Hello("안녕하세요!");
Hello("익명 메서드를 사용 중입니다.");

WriteLine();

// 4
Func<int, int> doubler = delegate (int x) { return x * 2; };
Action <string> logger = delegate (string msg) { WriteLine($"[LOG] {msg}"); };

WriteLine(doubler(10));
logger("작업 시작");

WriteLine();

// 5
SimpleDelegate handler = delegate { WriteLine("매개변수를 사용하지 않습니다."); };
handler(100, "테스트");

WriteLine();

// 6
EventHandler onClick = delegate { WriteLine("클릭 이벤트 발생!"); };
onClick(null, EventArgs.Empty);

WriteLine();








delegate void EventHandler(object obj, EventArgs events);
delegate void SimpleDelegate(int i, string s);
delegate void Printer (string s); // 반환값이 없고 매개변수 string 을 받을 수 있는 익명 메서드
delegate int Calculator(int i);
delegate int Transformer(int i);