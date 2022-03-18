using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    #region  Singleton
    public static Inventory inventory;
    private void Awake()
    {
        inventory = this;
    }
    #endregion
    public List<Item> items = new List<Item>();
    public int Space = 500;

    public void AddItem(Item item)
    {
        Space -= item.Space;
        if (Space <= 0)
            return;
        items.Add(item);
    }
}
