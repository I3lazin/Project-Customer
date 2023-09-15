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

    //achievemnt 2 var
    public static int ach2Count;
    public int ach2Trigger = 1;
    public int hasAchieved2;

    //achievemnt 3 var
    public static int ach3Count;
    public int ach3Trigger = 1;
    public int hasAchieved3;


    void Update()
    {
        //ach1Count = interactorTest.getsAchievement;
        //Debug.Log("ach1count = " + ach1Count);

        hasAchieved1 = PlayerPrefs.GetInt("Achievement1");
        hasAchieved2 = PlayerPrefs.GetInt("Achievement2");
        hasAchieved3 = PlayerPrefs.GetInt("Achievement3");

        if (ach1Count == ach1Trigger && hasAchieved1 != 1)
        {
            StartCoroutine(TriggerAch1());
        }

        if (ach2Count == ach2Trigger && hasAchieved2 != 1)
        {
            StartCoroutine(TriggerAch2());
        }

        if (ach3Count == ach3Trigger && hasAchieved3 != 1)
        { StartCoroutine(TriggerAch3()); }
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

    IEnumerator TriggerAch2()
    {
        achActive = true;
        hasAchieved2 = 1;
        achievement.SetActive(true);
        PlayerPrefs.SetInt("Achievement2", hasAchieved2);

        yield return new WaitForSeconds(7);

        achievement.SetActive(false);
        achActive = false;
    }

    IEnumerator TriggerAch3()
    {
        achActive = true;
        hasAchieved3 = 1;
        achievement.SetActive(true);
        PlayerPrefs.SetInt("Achievement3", hasAchieved3);

        yield return new WaitForSeconds(7);

        achievement.SetActive(false);
        achActive = false;
    }
}
