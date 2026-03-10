using System;
using System.IO.Pipes;
using System.Security.Cryptography.X509Certificates;
using static System.Console;



// 1

//익명 메서드
Calculator anonymous = delegate (int i) 
{
    return i * i; 
};

// 람다 문장식 (문장 블럭)
Calculator lambda1 = (int i) =>
{
    return i * i;
};

// 람다 식 (표현식)
Calculator lambda2 = i => i * i;

WriteLine($"익명 메서드: {anonymous(5)}");
WriteLine($"람다식 (블록): {lambda1(5)}");
WriteLine($"람다식 (표현식): {lambda2(5)}");

WriteLine();

// 2
// 익명 메서드는 매개변수를 생략 가능하다
EventHandler handler1 = delegate { WriteLine("이벤트 처리됨."); };
// 람다식의 경우에는 사용하지 않더라도 매개변수 명시가 필수임
EventHandler handler2 = delegate (object obj, EventArgs events) { WriteLine("이벤트 처리됨."); };

handler1(null, EventArgs.Empty);
handler2(null, EventArgs.Empty);

WriteLine();

// 3
// 빈 핸들러로 초기화
GameEvent onScoreChange = delegate { }; // null 체크 불필요
GameEvent onGameOver = delegate { }; // ''
onScoreChange("점수 변경", 100);
onGameOver("게임 종료", 0);

// += 연산자로 delegate 핸들러를 추가 (delegate를 할당할 때와 똑같은 방식)
onScoreChange += delegate (string eventname, int value)
{
    WriteLine($"[이벤트] {eventname}: {value}");
};
onScoreChange("점수 변경", 500);

WriteLine();

// 4

int[] numbers = { 1, 2, 3, 4, 5 };
int sum = 0;

// ProcessData 라는 함수를 정의
// int 배열 data와 int형 매개변수를 받는 callback Action 델리게이트를 매개변수로 받는 함수임
static void ProcessData(int[] data, Action<int> callback)
{
    foreach (int item in data)
    {
        callback(item);
    }
}

// ProcessData 함수 호출
// numbers 와 delegate (int n) 을 매개변수로 받음
ProcessData(numbers, delegate (int n)
{
    sum += n;
    WriteLine($"처리 중: {n}, 누적: {sum}");
}); // 여기까지가 함수 호출한거임 











delegate void GameEvent(string eventName, int value);
delegate void EventHandler(object obj, EventArgs events);
delegate int Calculator(int i);

