using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractorTest : MonoBehaviour, IInteractable
{
    [SerializeField] private string requiredObjectID;
    public void Interact()
    {
        if (requiredObjectID == null)
        {
            Debug.Log(Random.Range(0, 100));
            GetComponent<Renderer>().material.color = Color.green;
        } else {
            if (FindObjectOfType<GameManager>().bools[requiredObjectID] == true)
            {
                Debug.Log(Random.Range(0, 100));
                GetComponent<Renderer>().material.color = Color.green;
            }
            else
            {
                Debug.Log("You haven't acquired the required object yet.");
                GetComponent<Renderer>().material.color = Color.red;
            }
        }
        
    }
}
