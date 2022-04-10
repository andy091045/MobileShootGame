using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    #region  Singleton
    public static Inventory instance;
    private void Awake()
    {
        instance = this;
    }
    #endregion
    public List<Item> items = new List<Item>();
    public int Space = 500;

    public delegate void OnUIChange();
    public OnUIChange GetOnUIChange;

    public void AddItem(Item item)
    {
        Space -= item.Space;
        if (Space <= 0)
            return;
        items.Add(item);
        if (GetOnUIChange != null)
            GetOnUIChange.Invoke();
    }

    public void RemoveItem(Item item)
    {
        Space += item.Space;
        items.Remove(item);
        if (GetOnUIChange != null)
            GetOnUIChange.Invoke();
    }
}
