using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InteractorText : MonoBehaviour
{
    [SerializeField] private int distance;
    GameObject player;
    public bool iAmActive = true;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(transform.position);
        if (Vector3.Distance(transform.position, player.transform.position) <= distance)
        {
            Debug.Log("Test");
            gameObject.GetComponent<SpriteRenderer>().enabled = true;
            transform.GetChild(0).gameObject.SetActive(true);
            gameObject.GetComponentInChildren<TextMeshPro>().gameObject.SetActive(true);   
        } else {
            Debug.Log("Test2");
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
            transform.GetChild(0).gameObject.SetActive(false);
        }
    }
}
