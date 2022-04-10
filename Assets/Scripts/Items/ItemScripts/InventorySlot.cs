using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class InventorySlot : MonoBehaviour
{
    Item OnthisSlot;
    public Image Icon;

    public Text ItemName;

    public void AddItem(Item item)
    {
        OnthisSlot = item;
        Icon.sprite = item.Icon;
        ItemName.text = item.name;
    }

    public void RemoveItem()
    {
        OnthisSlot = null;
        Icon.sprite = null;
        ItemName.text = "<Item Name>";
    }
}
