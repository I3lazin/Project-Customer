using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.HighDefinition;

public class OwlScript : MonoBehaviour
{

    [SerializeField] private Transform player;
    [SerializeField] private LayerMask playerLayer;

    [SerializeField] private GameObject sleepOwl;
    [SerializeField] private GameObject awakeOwl;
    [SerializeField] private GameObject owlHint;

    public bool owlHasBeenAwoken = false;

    public float sightRange;
    public float hintRange;

    public bool playerInSight = false;
    public bool playerInHintRange = false;
    // Start is called before the first frame update
    void Awake()
    {
        //player = GameObject.Find("Player25dTest").transform;
    }

    // Update is called once per frame
    void Update()
    {
        playerInSight = Physics.CheckSphere(transform.position, sightRange, playerLayer);
        playerInHintRange = Physics.CheckSphere(transform.position, hintRange, playerLayer);

        if (!playerInSight)
        {
            OwlAsleep();
        }

        if (playerInSight && !Input.GetKey(KeyCode.LeftShift))
        {
            OwlAwake();
        }

        OwlHint(playerInHintRange);

    }

    private void OwlAsleep()
    {
        sleepOwl.SetActive(true);
        awakeOwl.SetActive(false);
    }

    private void OwlAwake()
    {
        owlHasBeenAwoken = true;
        sleepOwl.SetActive(false);
        awakeOwl.SetActive(true);
    }

    private void OwlHint(bool setOwlHintActive)
    {
        owlHint.SetActive(setOwlHintActive);
    }
}
