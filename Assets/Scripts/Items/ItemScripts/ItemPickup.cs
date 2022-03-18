using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public Item ThisItem;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Inventory.inventory.items.Add(ThisItem);
            Destroy(gameObject);
        }
    }
}
