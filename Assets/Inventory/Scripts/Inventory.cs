using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    [SerializeField]
    private GameObject inventorySlotUI;

    [SerializeField]
    private GridLayoutGroup inventoryGroup;

    [SerializeField]
    private int maxSlots = 10;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < maxSlots; i++)
        {
            SpawnInventorySlot();
        }
    }

    void SpawnInventorySlot()
    {
        GameObject slot = Instantiate(inventorySlotUI);
        slot.gameObject.transform.SetParent(inventoryGroup.transform, false);
    }


}
