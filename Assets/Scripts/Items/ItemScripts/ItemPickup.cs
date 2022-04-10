using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ItemPickup : MonoBehaviour
{
    public Item ThisItem;
    public GameObject InventoryBtn;
    public GameObject InventoryHeader;
    public GameObject Inventorytext;
    public GameObject InventoryImage;

    bool isEnter = false;

    private void Update()
    {
        if (isEnter)
        {
            //Pick up Item
            if (Input.GetKeyDown(KeyCode.F))
            {
                //UI close
                InventoryBtn.SetActive(false);
                isEnter = false;

                Inventory.instance.AddItem(ThisItem);
                Destroy(gameObject);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            InventoryHeader.GetComponent<Text>().text = ThisItem.name;
            Inventorytext.GetComponent<Text>().text = ThisItem.ItemText;
            InventoryImage.GetComponent<Image>().sprite = ThisItem.Icon;
            InventoryBtn.SetActive(true);
            isEnter = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        InventoryBtn.SetActive(false);
    }
}
