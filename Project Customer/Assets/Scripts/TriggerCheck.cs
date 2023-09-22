using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Cinemachine;
using Unity.VisualScripting;

public class TriggerCheck : MonoBehaviour
{
    [SerializeField] private GameObject Cutscene2Canvas;
    [SerializeField] private GameObject Cutscene3Canvas;

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
        if (other.tag == "Cutscene2")
        {
            Cutscene2Canvas.SetActive(true);
            GetComponent<Movement3D>().enabled = false;
        }
        if (other.tag == "Cutscene3")
        {
            Cutscene3Canvas.SetActive(true);
            GetComponent<Movement3D>().enabled = false;
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
