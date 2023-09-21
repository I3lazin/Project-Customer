using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using DG.Tweening;

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
        sound.PlaySfx(id);
        hint.transform.DOMoveX(50.0f, 2.0f);
        interactableIcon.SetActive(true);
        Destroy(gameObject);
        FindObjectOfType<GameManager>().bools[id] = true;
        FindObjectOfType<DisplayInventory>().itemsInIventory.Add(id, itemPrefabHUD);
    }
}
