using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    [SerializeField] public string id = "null";
    [SerializeField] private GameObject itemPrefabHUD;

/*    private void Awake()
    {
        FindObjectOfType<DisplayInventory>().itemsInIventory.Add(id, itemPrefabHUD);
    }
*/
    public void Collect()
    {
        Destroy(gameObject);
        FindObjectOfType<GameManager>().bools[id] = true;
        FindObjectOfType<DisplayInventory>().itemsInIventory.Add(id, itemPrefabHUD);
    }
}
