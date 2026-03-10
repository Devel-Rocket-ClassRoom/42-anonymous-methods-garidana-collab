using System;
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
EventHandler handler1 = delegate { WriteLine("이벤트 처리됨."); };
EventHandler handler2 = delegate (object obj, EventArgs events) { WriteLine("이벤트 처리됨"); };

handler1(null, EventArgs.Empty);
handler2(null, EventArgs.Empty);












delegate void EventHandler(object obj, EventArgs events);
delegate int Calculator(int i);

