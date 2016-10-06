using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


public class Calculator
{
    public ArrayList GetSumByGroup<T>(IEnumerable<T> elements, string column, int group)
    {
        ArrayList result_sum = new ArrayList(); //儲存各組數值加總結果

        for (int i = 0; i < elements.Count(); i += group)
        {
            result_sum.Add(elements.Skip(i).Take(group).Sum(x => Convert.ToInt32(x.GetType().GetProperty(column).GetValue(x))));
        }

        return result_sum;
    }
}

