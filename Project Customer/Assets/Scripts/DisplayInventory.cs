using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEditor.Build;
using UnityEngine;

public class DisplayInventory : MonoBehaviour
{
    public int X_SPACE_BETWEEN_ITEM;
    public int X_START;
    public int NUMBER_OF_COLUMN;
    public int Y_SPACE_BETWEEN_ITEMS;
    public int Y_START;
    public Dictionary<string, GameObject> itemsInIventory = new Dictionary<string, GameObject>();
    public List<string> DisplayedItems = new List<string>();

    [SerializeField] private AudioSource pickUp;

    void Start()
    {
        CreateDisplay();
    }

    void Update()
    {
        UpdateDisplay();
    }

    public void CreateDisplay()
    {
        int i = 0;
        foreach (var id in itemsInIventory.Keys)
        {
            var obj = Instantiate(itemsInIventory[id], Vector3.zero, Quaternion.identity, transform);
            obj.GetComponent<RectTransform>().localPosition = GetPosition(i);
            ++i;
        }
    }

    public void UpdateDisplay()
    {
        int i = 0;
        foreach (var id in itemsInIventory.Keys)
        {
            if(!DisplayedItems.Contains(id))
            {
                var obj = Instantiate(itemsInIventory[id], Vector3.zero, Quaternion.identity, transform);
                obj.GetComponent<RectTransform>().localPosition = GetPosition(i);
                DisplayedItems.Add(id);
            }
            ++i;
            //Debug.Log(i);
        }
    }

    public void RemoveObject(string id)
    {
        GameObject target;
        foreach (var obj in GameObject.FindGameObjectsWithTag("InventoryItem"))
        {
            target = obj;
            DestroyImmediate(target, true);
        }
        itemsInIventory.Remove(id);
        DisplayedItems.Remove(id);
    }

    public Vector3 GetPosition(int i)
    {
        return new Vector3(X_START + (X_SPACE_BETWEEN_ITEM * (i % NUMBER_OF_COLUMN)), Y_START + (-Y_SPACE_BETWEEN_ITEMS * (i/NUMBER_OF_COLUMN)), 0f);
    }
}
