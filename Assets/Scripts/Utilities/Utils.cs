using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using URandom = UnityEngine.Random;
using System.Collections.ObjectModel;

public class Utils
{
    public static NormalItem.eNormalType GetRandomNormalType()
    {
        Array values = Enum.GetValues(typeof(NormalItem.eNormalType));
        NormalItem.eNormalType result = (NormalItem.eNormalType)values.GetValue(URandom.Range(0, values.Length));

        return result;
    }

    public static NormalItem.eNormalType GetRandomNormalTypeExcept(NormalItem.eNormalType[] types)
    {
        List<NormalItem.eNormalType> list = Enum.GetValues(typeof(NormalItem.eNormalType)).Cast<NormalItem.eNormalType>().Except(types).ToList();

        int rnd = URandom.Range(0, list.Count);
        NormalItem.eNormalType result = list[rnd];

        return result;
    } 
    
    public static NormalItem.eNormalType GetRandomNormalTypeWithLeastAmountExcept(NormalItem.eNormalType[] types, Dictionary<NormalItem.eNormalType, int> typeKeys)
    {
        List<NormalItem.eNormalType> list = Enum.GetValues(typeof(NormalItem.eNormalType)).Cast<NormalItem.eNormalType>().Except(types).ToList();

        typeKeys = typeKeys.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
        NormalItem.eNormalType type = typeKeys.Where(x => !types.Contains(x.Key)).FirstOrDefault().Key;
        return type;
    }
}
