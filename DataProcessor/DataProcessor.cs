using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks.Dataflow;

class DataProcessor
{
    int[] datas;

    public void ForEach(Action<int> action)
    {
        
        for (int i = 1; i <= 10; i++)
        {
              
        }
    }

    public int[] TransformBlock (Func<int, int> transformer)
    {
        List<int> transformed = delegate ()
        {
            foreach (int data in datas)
            {
                data *= 2;
                datas += data ;
                return (List<int>)datas;
            }
           
        };
        return transformed;
        
    }

    public List<int> Filter (Func<int, bool> predicate)
    {
        return null;
    }

    public int Reduce (Func<int, int, int> reducer, int intialvalue)
    {
        return 0;
    }
}