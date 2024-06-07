using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Normal Item Skin Data", menuName = "Scriptable Objects/Item/Normal Skin", order = 0)]
public class NormalItemSkinData : ScriptableObject
{
    [SerializeField] private NormalItemSkin[] normalSkinDatas = new NormalItemSkin[0];

    public Sprite GetNormalSkin(NormalItem.eNormalType ItemType)
    {
        foreach(var skin in normalSkinDatas)
        {
            if (skin.ItemType == ItemType)
                return skin.ItemSprite;
        }
        return null;
    }
}

[System.Serializable]
public class NormalItemSkin
{
    public NormalItem.eNormalType ItemType;
    public Sprite ItemSprite;
}

