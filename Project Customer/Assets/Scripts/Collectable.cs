using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    [SerializeField] public string id = "null";
    [SerializeField] private GameObject itemPrefabHUD;
    SoundManager sound;
    private void Start()
    {
        sound = FindObjectOfType<SoundManager>();
    }

    public void Collect()
    {
        sound.PlaySfx(id);
        Destroy(gameObject);
        FindObjectOfType<GameManager>().bools[id] = true;
        FindObjectOfType<DisplayInventory>().itemsInIventory.Add(id, itemPrefabHUD);
    }
}
