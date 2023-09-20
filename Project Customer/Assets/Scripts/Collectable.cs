using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    [SerializeField] public string id = "null";
    [SerializeField] private GameObject itemPrefabHUD;
/*    [SerializeField] private GameObject interactableIcon;
    [SerializeField] private GameObject hint;*/
    SoundManager sound;
    private void Start()
    {
        sound = FindObjectOfType<SoundManager>();
    }

    public void Collect()
    {
        /*        if (hint != null)
                {
                    hint.SetActive(true);
                }
                if (interactableIcon != null)
                {
                    interactableIcon.SetActive(true);
                }*/
        Debug.Log("collect!");
        sound.PlaySfx(id);
        Destroy(gameObject);
        FindObjectOfType<GameManager>().bools[id] = true;
        FindObjectOfType<DisplayInventory>().itemsInIventory.Add(id, itemPrefabHUD);
    }
}
