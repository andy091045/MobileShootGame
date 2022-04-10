using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    public GameObject ObjInventory;
    Inventory inventory;
    public Transform SlotParent;
    InventorySlot[] slots;

    int NumofItems;

    private void Awake()
    {
        slots = GetComponentsInChildren<InventorySlot>();
        ObjInventory.SetActive(false);
    }
    private void Start()
    {
        inventory = Inventory.instance;
        inventory.GetOnUIChange += UpdateUI;
        NumofItems = inventory.items.Count;
    }

    private void Update()
    {
        if (Input.GetButtonDown("Inventory"))
        {
            ObjInventory.SetActive(!ObjInventory.activeSelf);
        }
    }

    void UpdateUI()
    {
        for (int i = 0; i < slots.Length; i++)
        {
            if (i < inventory.items.Count)
            {
                slots[i].AddItem(inventory.items[i]);
            }
            else
            {
                slots[i].RemoveItem();
            }
        }
    }
    // bool InventoryEnableState = false;

    // private void Update()
    // {
    //     if (Input.GetButtonDown("Inventory"))
    //     {
    //         if (InventoryEnableState == true)
    //         {
    //             Cursor.lockState = CursorLockMode.Locked;
    //             Cursor.visible = false;
    //             Inventory.SetActive(false);
    //         }

    //         if (InventoryEnableState == false)
    //         {
    //             Cursor.lockState = CursorLockMode.None;
    //             Cursor.visible = true;
    //             Inventory.SetActive(true);
    //         }


    //     }

    // }
}
