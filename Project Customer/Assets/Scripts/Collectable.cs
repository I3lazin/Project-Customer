using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    [SerializeField] public string id = "null";
    [SerializeField] private GameObject itemPrefabHUD;
    [SerializeField] private GameObject interactableIcon;
    [SerializeField] private GameObject hint;
    SoundManager sound;
    //private void Start()
    //{
    //    sound = FindObjectOfType<SoundManager>();
    //}

    public void Update()
    {
        if(sound == null)
        {
            sound = FindObjectOfType<SoundManager>();
        }
    }

    public void Collect()
    {
        if (hint != null)
        {
            hint.transform.DOMoveX(50.0f, 2.0f);
        }
        if (interactableIcon != null)
        {
            interactableIcon.transform.DOMoveX(-750.0f, 2.0f);
        }
        Debug.Log("collect!");
        Debug.Log(sound);
        sound.PlaySfx(id);
        Destroy(gameObject);
        FindObjectOfType<GameManager>().bools[id] = true;
        FindObjectOfType<DisplayInventory>().itemsInIventory.Add(id, itemPrefabHUD);

    }
}
