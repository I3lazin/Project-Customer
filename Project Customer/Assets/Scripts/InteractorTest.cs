using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractorTest : MonoBehaviour, IInteractable
{
    [SerializeField] private GameObject removeObject;
    [SerializeField] private string requiredObjectID;
    [SerializeField] private GameObject nextTarget;
    SoundManager sound;
    private DisplayInventory inv;

    private void Start()
    {
        inv = FindObjectOfType<DisplayInventory>();
    }

    public void Interact()
    {
        if (requiredObjectID == null)
        {
            Debug.Log(Random.Range(0, 100));
            GetComponent<Renderer>().material.color = Color.green;
        } else {
            if (FindObjectOfType<GameManager>().bools[requiredObjectID] == true)
            {
                if (nextTarget == null)
                {
                    Destroy(removeObject);
                    Debug.Log("You don't have the next target set yet!");
                } else {
                    nextTarget.SetActive(true);
                    gameObject.SetActive(false);
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
