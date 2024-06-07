using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Bonus Item Skin Data", menuName = "Scriptable Objects/Item/Bonus Skin", order = 1)]
public class BonusItemSkinData : ScriptableObject
{
    [SerializeField] private BonusItemSkin[] bonusSkinDatas = new BonusItemSkin[0];

    public Sprite GetBonusSkin(BonusItem.eBonusType ItemType)
    {
        foreach(var skin in bonusSkinDatas)
        {
            if (skin.ItemType == ItemType)
                return skin.ItemSprite;
        }
        return null;
    }
}

[System.Serializable]
public class BonusItemSkin
{
    public BonusItem.eBonusType ItemType;
    public Sprite ItemSprite;
}

