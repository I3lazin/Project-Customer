using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SneakAchievementController : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private LayerMask playerLayer;

    [SerializeField] private OwlScript owlScript;

    public bool playerInSight = false;
    public float sightRange;



    // Start is called before the first frame update
    void Awake()
    {
        player = GameObject.Find("Player25dTest").transform;

    }

    // Update is called once per frame
    void Update()
    {
        playerInSight = Physics.CheckSphere(transform.position, sightRange, playerLayer);

        if (playerInSight && owlScript.owlHasBeenAwoken == false) 
        {
            AchievementController.achCount[7] = 1;
        } else if(playerInSight && owlScript.owlHasBeenAwoken == true)
        {
            AchievementController.achCount[6] = 1;
        }
    }
}
