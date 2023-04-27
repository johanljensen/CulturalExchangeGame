using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class DialogueChoice : MonoBehaviour
{
    [SerializeField]
    TextAsset ChoiceText;

    [SerializeField]
    InventoryItem.ItemType requiredItem;

    public string GetText()
    {
        return ChoiceText.text;
    }

    public InventoryItem.ItemType GetRequiredItem()
    {
        return requiredItem;
    }
}
