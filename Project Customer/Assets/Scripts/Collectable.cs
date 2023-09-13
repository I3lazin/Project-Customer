using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    [SerializeField] public string id = "null";
    [SerializeField] private GameObject itemPrefabHUD;
    [SerializeField] private GameObject interactableIcon;
    [SerializeField] private GameObject hint;


    /*    private void Awake()
        {
            FindObjectOfType<DisplayInventory>().itemsInIventory.Add(id, itemPrefabHUD);
        }
    */
    public void Collect()
    {
        hint.SetActive(true);
        interactableIcon.SetActive(true);
        Destroy(gameObject);
        FindObjectOfType<GameManager>().bools[id] = true;
        FindObjectOfType<DisplayInventory>().itemsInIventory.Add(id, itemPrefabHUD);
    }
}
