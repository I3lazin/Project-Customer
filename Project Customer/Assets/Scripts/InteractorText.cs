using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InteractorText : MonoBehaviour
{
    [SerializeField] private int distance;
    public GameObject player;
    public bool iAmActive = true;

    void Start()
    {
        //player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, player.transform.position) <= distance)
        {
            gameObject.GetComponent<SpriteRenderer>().enabled = true;
            transform.GetChild(0).gameObject.SetActive(true);
            gameObject.GetComponentInChildren<TextMeshPro>().gameObject.SetActive(true);   
        } else {
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
            transform.GetChild(0).gameObject.SetActive(false);
        }
    }
}
