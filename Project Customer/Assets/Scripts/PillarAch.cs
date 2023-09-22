using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillarAch : MonoBehaviour
{
    [SerializeField] private bool hasBeenVisited = false;
    [SerializeField] private LayerMask playerLayer;
    [SerializeField] private GameObject pillarText;

    public float sightRange;
    public bool playerInSight = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerInSight = Physics.CheckSphere(transform.position, sightRange, playerLayer);

        if (playerInSight && !hasBeenVisited)
        {
            AchievementController.achCount[1]++;
            hasBeenVisited = true;
            Debug.Log(AchievementController.achCount[1]);
        } else if (playerInSight && hasBeenVisited)
        {
            pillarText.SetActive(true);
        } else
        {
            pillarText.SetActive(false);
        }

        //Debug.Log(AchievementController.ach2Count);
    }
}
