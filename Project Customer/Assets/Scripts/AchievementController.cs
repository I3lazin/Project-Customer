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

    public GameObject achCanvas;
    public GameObject achCanvas2;

    private InteractorTest interactorTest;

    //achievemnt 1 var
    public static int ach1Count;
    public int ach1Trigger = 1;
    public int hasAchieved1;
    public GameObject ach1;
    public GameObject achPatch1;

    //achievemnt 2 var
    public static int ach2Count;
    public int ach2Trigger = 3;
    public int hasAchieved2;
    public GameObject ach2;
    public GameObject achPatch2;


    //achievemnt 3 var
    public static int ach3Count;
    public int ach3Trigger = 1;
    public int hasAchieved3;
    public GameObject ach3;
    public GameObject achPatch3;


    //achievemnt 4 var
    public static int ach4Count;
    public int ach4Trigger = 1;
    public int hasAchieved4;
    public GameObject ach4;
    public GameObject achPatch4;


    //achievemnt 5 var
    public static int ach5Count;
    public int ach5Trigger = 1;
    public int hasAchieved5;
    public GameObject ach5;
    public GameObject achPatch5;


    //achievemnt 6 var
    public static int ach6Count;
    public int ach6Trigger = 1;
    public int hasAchieved6;
    public GameObject ach6;
    public GameObject achPatch6;


    //achievemnt 7 var
    public static int ach7Count;
    public int ach7Trigger = 1;
    public int hasAchieved7;
    public GameObject ach7;
    public GameObject achPatch7;


    //achievemnt 8 var
    public static int ach8Count;
    public int ach8Trigger = 1;
    public int hasAchieved8;
    public GameObject ach8;
    public GameObject achPatch8;



    void Update()
    {
        hasAchieved1 = PlayerPrefs.GetInt("Achievement1");
        hasAchieved2 = PlayerPrefs.GetInt("Achievement2");
        hasAchieved3 = PlayerPrefs.GetInt("Achievement3");
        //hasAchieved4 = PlayerPrefs.GetInt("Achievement4");
        //hasAchieved5 = PlayerPrefs.GetInt("Achievement5");
        //hasAchieved6 = PlayerPrefs.GetInt("Achievement6");
        //hasAchieved7 = PlayerPrefs.GetInt("Achievement7");
        //hasAchieved8 = PlayerPrefs.GetInt("Achievement8");

        if (ach1Count == ach1Trigger && hasAchieved1 != 1)
        { StartCoroutine(TriggerAch1()); }

        if (ach2Count == ach2Trigger && hasAchieved2 != 1)
        { StartCoroutine(TriggerAch2()); }

        if (ach3Count == ach3Trigger && hasAchieved3 != 1)
        { StartCoroutine(TriggerAch3()); }

        //if (ach4Count == ach4Trigger && hasAchieved4 != 1)
        //{ StartCoroutine(TriggerAch4()); }

        //if (ach5Count == ach5Trigger && hasAchieved5 != 1)
        //{ StartCoroutine(TriggerAch5()); }

        //if (ach6Count == ach6Trigger && hasAchieved6 != 1)
        //{ StartCoroutine(TriggerAch6()); }

        //if (ach7Count == ach7Trigger && hasAchieved7 != 1)
        //{ StartCoroutine(TriggerAch7()); }

        //if (ach8Count == ach8Trigger && hasAchieved8 != 1)
        //{ StartCoroutine(TriggerAch8()); }


        if (hasAchieved1 == 1 && achCanvas.activeInHierarchy)
        {
            achPatch1.SetActive(true);
        }
        else achPatch1.SetActive(false);

        if (hasAchieved2 == 1 && achCanvas.activeInHierarchy)
        {
            achPatch2.SetActive(true);
        }
        else achPatch2.SetActive(false);

        if (hasAchieved3 == 1 && achCanvas.activeInHierarchy)
        {
            achPatch3.SetActive(true);
        }
        else achPatch3.SetActive(false);

        //if (hasAchieved4 == 1 && achCanvas.activeInHierarchy)
        //{
        //    achPatch4.SetActive(true);
        //}
        //else achPatch4.SetActive(false);

        //if (hasAchieved5 == 1 && achCanvas.activeInHierarchy)
        //{
        //    achPatch5.SetActive(true);
        //}
        //else achPatch5.SetActive(false);

        //if (hasAchieved6 == 1 && achCanvas.activeInHierarchy)
        //{
        //    achPatch6.SetActive(true);
        //}
        //else achPatch6.SetActive(false);

        //if (hasAchieved7 == 1 && achCanvas.activeInHierarchy)
        //{
        //    achPatch7.SetActive(true);
        //}
        //else achPatch7.SetActive(false);

        //if (hasAchieved8 == 1 && achCanvas.activeInHierarchy)
        //{
        //    achPatch8.SetActive(true);
        //}
        //else achPatch8.SetActive(false);
    }

    IEnumerator TriggerAch1()
    {
        //displaying achievemnt with the right description
        achActive = true;
        hasAchieved1 = 1;
        PlayerPrefs.SetInt("Achievement1", hasAchieved1);
        ach1.SetActive(true);

        yield return new WaitForSeconds(7);

        //resseting achievement
        ach1.SetActive(false);
        achActive = false;
    }

    IEnumerator TriggerAch2()
    {
        achActive = true;
        hasAchieved2 = 1;
        ach2.SetActive(true);
        PlayerPrefs.SetInt("Achievement2", hasAchieved2);

        yield return new WaitForSeconds(7);

        ach2.SetActive(false);
        achActive = false;
    }

    IEnumerator TriggerAch3()
    {
        achActive = true;
        hasAchieved3 = 1;
        ach3.SetActive(true);
        PlayerPrefs.SetInt("Achievement3", hasAchieved3);

        yield return new WaitForSeconds(7);

        ach3.SetActive(false);
        achActive = false;
    }

    //IEnumerator TriggerAch4()
    //{
    //    achActive = true;
    //    hasAchieved4 = 1;
    //    ach4.SetActive(true);
    //    PlayerPrefs.SetInt("Achievement3", hasAchieved3);

    //    yield return new WaitForSeconds(7);

    //    ach4.SetActive(false);
    //    achActive = false;
    //}

    //IEnumerator TriggerAch5()
    //{
    //    achActive = true;
    //    hasAchieved5 = 1;
    //    ach5.SetActive(true);
    //    PlayerPrefs.SetInt("Achievement3", hasAchieved3);

    //    yield return new WaitForSeconds(7);

    //    ach5.SetActive(false);
    //    achActive = false;
    //}

    //IEnumerator TriggerAch6()
    //{
    //    achActive = true;
    //    hasAchieved6 = 1;
    //    ach6.SetActive(true);
    //    PlayerPrefs.SetInt("Achievement3", hasAchieved3);

    //    yield return new WaitForSeconds(7);

    //    ach6.SetActive(false);
    //    achActive = false;
    //}

    //IEnumerator TriggerAch7()
    //{
    //    achActive = true;
    //    hasAchieved7 = 1;
    //    ach7.SetActive(true);
    //    PlayerPrefs.SetInt("Achievement3", hasAchieved3);

    //    yield return new WaitForSeconds(7);

    //    ach7.SetActive(false);
    //    achActive = false;
    //}

    //IEnumerator TriggerAch8()
    //{
    //    achActive = true;
    //    hasAchieved8 = 1;
    //    ach8.SetActive(true);
    //    PlayerPrefs.SetInt("Achievement3", hasAchieved3);

    //    yield return new WaitForSeconds(7);

    //    ach8.SetActive(false);
    //    achActive = false;
    //}
}
