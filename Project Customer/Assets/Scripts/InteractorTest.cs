using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class InteractorTest : MonoBehaviour, IInteractable
{
    [SerializeField] private GameObject removeObject;
    [SerializeField] private GameObject removeHint;
    [SerializeField] private string requiredObjectID;
    [SerializeField] private GameObject nextTarget;
    SoundManager sfx;
    private DisplayInventory inv;

    private void Start()
    {
        inv = FindObjectOfType<DisplayInventory>();
        sfx = FindObjectOfType<SoundManager>();
    }

    public void Interact()
    {
        if (requiredObjectID == null)
        {
            //Debug.Log(Random.Range(0, 100));
            GetComponent<Renderer>().material.color = Color.green;
        } else {
            if (FindObjectOfType<GameManager>().bools[requiredObjectID] == true)
            {
                if (nextTarget == null)
                {
                    if (removeHint != null)
                    {
                        removeHint.SetActive(false);
                    }
                    Destroy(removeObject);
                    Debug.Log("You don't have the next target set yet!");
                } else {
                    if (removeObject.name == "Window")
                    {
                        sfx.PlaySfx("Window");
                    }
                    /*AchievementController.achCount[5] = 1;*/
                    nextTarget.SetActive(true);
                    gameObject.SetActive(false);
                    removeHint.transform.DOMoveX(-750.0f, 2.0f);
/*                    inv.RemoveObject(requiredObjectID);*/
                    Destroy(removeObject);
                }
            }
            else
            {
                Debug.Log("You haven't acquired the required object yet.");
            }   
        }
        
    }
}
