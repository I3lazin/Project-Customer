using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class AchievementController : MonoBehaviour
{
    public GameObject achievement;
    //public GameObject achTitle;
    //public GameObject achDescription;
    public bool achActive;

    private InteractorTest interactorTest;

    //achievemnt 1 var
    //public GameObject ach1Icon;
    public static int ach1Count;
    public int ach1Trigger = 1;
    public int hasAchieved1;
    

    void Update()
    {
        //ach1Count = interactorTest.getsAchievement;
        Debug.Log("ach1count = " + ach1Count);
        hasAchieved1 = PlayerPrefs.GetInt("Achievement1");
        if(ach1Count == ach1Trigger && hasAchieved1 != 1)
        {
            StartCoroutine(TriggerAch1());
        }
    }

    IEnumerator TriggerAch1()
    {
        //displaying achievemnt with the right description
        achActive = true;
        hasAchieved1 = 1;
        PlayerPrefs.SetInt("Achievement1", hasAchieved1);
        //ach1Icon.SetActive(true);
        //achTitle.GetComponent<Text>().text = "ROOM COMPLETED";
        //achDescription.GetComponent<Text>().text = "you have completed the first room";
        achievement.SetActive(true);
        yield return new WaitForSeconds(7);

        //resseting achievement
        achievement.SetActive(false);
        //achTitle.GetComponent<Text>().text = "";
        //achDescription.GetComponent<Text>().text = "";
        achActive = false;


    }
}
