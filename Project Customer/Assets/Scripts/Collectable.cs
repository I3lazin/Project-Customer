using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    [SerializeField] public string id = "null"; 
    
    public void Collect()
    {
        Destroy(gameObject);
        FindObjectOfType<GameManager>().bools[id] = true;
    }
}
