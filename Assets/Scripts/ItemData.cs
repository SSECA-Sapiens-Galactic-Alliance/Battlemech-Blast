using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="ItemData", menuName ="Item", order = 0)]
public class ItemData : ScriptableObject
{

    public enum ItemType { 
        None,
        Gun,
        SpecialPower,
        Currency,
        Skin
    }

    public ItemType type;
    public string itemName;
    [TextArea]
    public string description;



}