using System;
using static System.Console;
// README.md를 읽고 아래에 코드를 작성하세요.


WriteLine("=== 단순 카운터 ===");
Func<int> simple = CounterFactory.CreateSimpleCounter();
Write($"{simple()} ");
Write($"{simple()} ");
Write($"{simple()} ");
Write($"{simple()} ");
WriteLine($"{simple()} ");
WriteLine();
WriteLine("=== 스텝 카운터 (step=3) ===");
Func<int> step = CounterFactory.CreateStepCounter(3);
Write($"{step()} ");
Write($"{step()} ");
Write($"{step()} ");
WriteLine($"{step()} ");
WriteLine();
WriteLine($"=== 범위 카운터 (1~3) ===");
Func<int> range = CounterFactory.CreateBoundedCounter(1, 3);
Write($"{range()} ");
Write($"{range()} ");
Write($"{range()} ");
Write($"{range()} ");
Write($"{range()} ");
Write($"{range()} ");
WriteLine($"{range()} ");
WriteLine();
WriteLine("=== 리셋 가능 카운터 ===");
Action again;
Func<int> getCount;
CounterFactory.CreateResettableCounter(out again, out getCount);
WriteLine($"호출: {getCount()} {getCount()} {getCount()}");
again();
WriteLine($"리셋 후: {getCount()} {getCount()}");
