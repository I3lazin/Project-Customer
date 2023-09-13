using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractorTest : MonoBehaviour, IInteractable
{
    [SerializeField] private GameObject removeObject;
    [SerializeField] private GameObject removeHint;
    [SerializeField] private string requiredObjectID;
    [SerializeField] private GameObject nextTarget;
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
                    Debug.Log(Random.Range(0, 100));
                    GetComponent<Renderer>().material.color = Color.green;
                } else {
                    AchievementController.ach1Count = 1;
                    nextTarget.SetActive(true);
                    nextTarget.GetComponent<Renderer>().material.color = Color.green;
                    gameObject.SetActive(false);
                    removeHint.SetActive(false);
/*                    inv.RemoveObject(requiredObjectID);*/
                    Destroy(removeObject);
                }
            }
            else
            {
                Debug.Log("You haven't acquired the required object yet.");
                GetComponent<Renderer>().material.color = Color.red;
            }   
        }
        
    }
}
