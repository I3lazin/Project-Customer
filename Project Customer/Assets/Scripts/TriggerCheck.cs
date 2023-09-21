using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Cinemachine;
using Unity.VisualScripting;

public class TriggerCheck : MonoBehaviour
{
    private bool hasReceivedCageAchievement = false;
    GameManager manager;

    private void Start()
    {
        manager = FindObjectOfType<GameManager>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "collectable")
        {
            other.GetComponent<Collectable>().Collect();
        } 
        if (other.tag == "End")
        {
            SceneManager.LoadScene("Dasha");
        }
        if (other.tag == "FirstPerson")
        {
            ChangeCamera(2);

        }
        if (other.tag == "ThirdPerson")
        {
            ChangeCamera(0);
        }
        if (other.tag == "AchNoCage" && !hasReceivedCageAchievement)
        {
            AchievementController.achCount[3] = 1;
        }
        if (other.tag == "Ach5thRoom")
        {
            AchievementController.achCount[0] = 1;
            if (manager.timesCaught < 4)
            {
                Invoke("WaitForAchievement", 10);
            }
        }
    }

    void WaitForAchievement()
    {
        AchievementController.achCount[4] = 1;
    }

    void ChangeCamera(int value)
    {
        foreach (var obj in GetComponentsInChildren<CinemachineVirtualCamera>())
        {
            if (obj.name == "CM vcam2")
            {
                obj.GetComponent<CinemachineVirtualCamera>().Priority = value;
            }
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        Debug.Log(other.gameObject.tag);
        if (other.gameObject.tag == "AchCage")
        {
            AchievementController.achCount[2] = 1;
            hasReceivedCageAchievement = true;
        }
    }



}
