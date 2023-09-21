using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckIfAchievementCollected : MonoBehaviour
{
    [SerializeField] GameObject nextTarget;

    private void Update()
    {
        if (AchievementController.achCount[2] == 1)
        {
            nextTarget.SetActive(true);
            Destroy(gameObject);
        }
    }
}
