using System;
using System.Collections.Generic;
using System.Text;

class CounterFactory
{
    public static Func<int> CreateSimpleCounter()
    {
        int count = 0; // 캡처할 변수
        // 리턴해줄 익명 메서드 
        Func<int> counter = delegate () // delegate() 가 익명 메서드의 시작 
        {
            count++;
            return count;
        };
        return counter;
    }

    public static Func<int> CreateStepCounter(int step)
    {
        int count = 0;
        Func<int> counter = delegate ()
        {
            count += step;
            return count;
        };
        return counter;
    }

    public static Func<int> CreateBoundedCounter(int min, int max)
    {
        int count = min - 1;
        Func<int> counter = delegate ()
        {
            count++;
            if (count > max)
            {
                count = min;
            }
            return count;
        };
        return counter;
    }

    public static void CreateResettableCounter(out Action reset, out Func<int> getCount)
    {
        int count = 0;
        getCount = delegate ()
        {
            count++;
            return count;
        };
        reset = delegate ()
        {
            count = 0;
        };
    }
}









