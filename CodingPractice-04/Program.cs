using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Cryptography;
using static System.Console;

// README.md를 읽고 아래에 코드를 작성하세요.


// 1
// 익명 메서드 방식
Calculator anonymous = delegate (int i) { return i * i; };
// 람다식 = 변수 선언 화살표 연산자 => 식;
Calculator lambda = i => i * i;

WriteLine($"익명 메서드: {anonymous(4)}");
WriteLine($"람다식: {lambda(4)}");

WriteLine();

// 2
int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

List<int> evens = Filter(numbers, delegate (int n) { return n % 2 == 0; });
List<int> odds = Filter(numbers, delegate (int n) { return n > 5; }); // delegate 할때 {} 안 return 기억할것 !

WriteLine($"짝수: {string.Join(", ", evens)}");
WriteLine($"5보다 큰수: {string.Join(", ", odds)}");

// 필터링 함수부터 구축
List<int> Filter(int[] sources, Func<int, bool> predicate)
{
    // 필터링된 배열 요소들을 담아줄 List<int>형 변수 선언
    List<int> result = new List<int>(); 
    // foreach문 으로 predicate 조건 검사
    foreach (int num in sources)
    {
        if (predicate(num))
        {
            // 조건에 참인 요소들 List<in> 형 result에 Add.
            result.Add(num);
        }
    }
    return result; // result 반환 (List<int>형)
}


WriteLine();

// 3
int factor = 10;

Func<int, int> normalMethod = delegate (int n) { return n * factor; };
Func<int, int> staticMethod = static delegate (int n) { return n * 2; };

WriteLine($"{normalMethod(5)}");
WriteLine($"{staticMethod(5)}");

WriteLine();









delegate int Calculator(int i);

