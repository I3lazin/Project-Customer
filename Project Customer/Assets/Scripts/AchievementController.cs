using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class AchievementController : MonoBehaviour
{
    public bool achActive;
    public GameObject achCanvas;
    public GameObject achCanvas2;

    //achievement position
    public float startX;
    public float endX;

    //audio
    public AudioSource achievementSound;

    //achievment arrays
    public static int[] achCount;
    public int[] achTrigger;
    public int[] hasAchieved;
    public GameObject[] ach;
    public GameObject[] achPatch;

    private void Awake()
    {
        achCount = new int[8];
        hasAchieved = new int[8];
    }

    void Update()
    {
        hasAchieved[0] = PlayerPrefs.GetInt("Achievement1");
        hasAchieved[1] = PlayerPrefs.GetInt("Achievement2");
        hasAchieved[2] = PlayerPrefs.GetInt("Achievement3");
        hasAchieved[3] = PlayerPrefs.GetInt("Achievement4");
        hasAchieved[4] = PlayerPrefs.GetInt("Achievement5");
        hasAchieved[5] = PlayerPrefs.GetInt("Achievement6");
        hasAchieved[6] = PlayerPrefs.GetInt("Achievement7");
        hasAchieved[7] = PlayerPrefs.GetInt("Achievement8");

        if (achCount[0] == achTrigger[0] && hasAchieved[0] != 1) { StartCoroutine(TriggerAch1()); }
        if (achCount[1] == achTrigger[1] && hasAchieved[1] != 1) { StartCoroutine(TriggerAch2()); }
        if (achCount[2] == achTrigger[2] && hasAchieved[2] != 1) { StartCoroutine(TriggerAch3()); }
        if (achCount[3] == achTrigger[3] && hasAchieved[3] != 1) { StartCoroutine(TriggerAch4()); }
        if (achCount[4] == achTrigger[4] && hasAchieved[4] != 1) { StartCoroutine(TriggerAch5()); }
        if (achCount[5] == achTrigger[5] && hasAchieved[5] != 1) { StartCoroutine(TriggerAch6()); }
        if (achCount[6] == achTrigger[6] && hasAchieved[6] != 1) { StartCoroutine(TriggerAch7()); }
        if (achCount[7] == achTrigger[7] && hasAchieved[7] != 1) { StartCoroutine(TriggerAch8()); }

        if (hasAchieved[0] == 1 && achCanvas.activeInHierarchy) { achPatch[0].SetActive(true); }
        else achPatch[0].SetActive(false);

        if (hasAchieved[1] == 1 && achCanvas.activeInHierarchy) { achPatch[1].SetActive(true); }
        else achPatch[1].SetActive(false);

        if (hasAchieved[2] == 1 && achCanvas.activeInHierarchy) { achPatch[2].SetActive(true); }
        else achPatch[2].SetActive(false);

        if (hasAchieved[3] == 1 && achCanvas.activeInHierarchy) { achPatch[3].SetActive(true); }
        else achPatch[3].SetActive(false);

        if (hasAchieved[4] == 1 && achCanvas2.activeInHierarchy) { achPatch[4].SetActive(true); }
        else achPatch[4].SetActive(false);

        if (hasAchieved[5] == 1 && achCanvas2.activeInHierarchy) { achPatch[5].SetActive(true); }
        else achPatch[5].SetActive(false);

        if (hasAchieved[6] == 1 && achCanvas2.activeInHierarchy) { achPatch[6].SetActive(true); }
        else achPatch[6].SetActive(false);

        if (hasAchieved[7] == 1 && achCanvas2.activeInHierarchy) { achPatch[7].SetActive(true); }
        else achPatch[7].SetActive(false);
    }

    IEnumerator TriggerAch1()
    {
        //displaying achievemnt with the right description
        ach[0].transform.DOMoveX(endX, 1.0f);
        achActive = true;
        hasAchieved[0] = 1;
        PlayerPrefs.SetInt("Achievement1", hasAchieved[0]);
        if (!achievementSound.isPlaying)
        {
            achievementSound.PlayOneShot(achievementSound.clip);
        }

        yield return new WaitForSeconds(7);

        //resseting achievement
        ach[0].transform.DOMoveX(startX, 1.0f);
        achActive = false;
    }

    IEnumerator TriggerAch2()
    {
        achActive = true;
        hasAchieved[1] = 1;
        ach[1].transform.DOMoveX(endX, 1.0f);
        PlayerPrefs.SetInt("Achievement2", hasAchieved[1]);
        if (!achievementSound.isPlaying)
        {
            achievementSound.PlayOneShot(achievementSound.clip);
        }

        yield return new WaitForSeconds(7);

        ach[1].transform.DOMoveX(startX, 1.0f);
        achActive = false;
    }

    IEnumerator TriggerAch3()
    {
        achActive = true;
        hasAchieved[2] = 1;
        ach[2].transform.DOMoveX(endX, 1.0f);
        PlayerPrefs.SetInt("Achievement3", hasAchieved[2]);
        if (!achievementSound.isPlaying)
        {
            achievementSound.PlayOneShot(achievementSound.clip);
        }

        yield return new WaitForSeconds(7);

        ach[2].transform.DOMoveX(startX, 1.0f);
        achActive = false;
    }

    IEnumerator TriggerAch4()
    {
        achActive = true;
        hasAchieved[3] = 1;
        ach[3].transform.DOMoveX(endX, 1.0f);
        PlayerPrefs.SetInt("Achievement4", hasAchieved[3]);
        if (!achievementSound.isPlaying)
        {
            achievementSound.PlayOneShot(achievementSound.clip);
        }

        yield return new WaitForSeconds(7);

        ach[3].transform.DOMoveX(startX, 1.0f);
        achActive = false;
    }

    IEnumerator TriggerAch5()
    {
        achActive = true;
        hasAchieved[4] = 1;
        ach[4].transform.DOMoveX(endX, 1.0f);
        PlayerPrefs.SetInt("Achievement5", hasAchieved[4]);
        if (!achievementSound.isPlaying)
        {
            achievementSound.PlayOneShot(achievementSound.clip);
        }

        yield return new WaitForSeconds(7);

        ach[4].transform.DOMoveX(startX, 1.0f);
        achActive = false;
    }

    IEnumerator TriggerAch6()
    {
        achActive = true;
        hasAchieved[5] = 1;
        ach[5].transform.DOMoveX(endX, 1.0f);
        PlayerPrefs.SetInt("Achievement6", hasAchieved[5]);
        if (!achievementSound.isPlaying)
        {
            achievementSound.PlayOneShot(achievementSound.clip);
        }

        yield return new WaitForSeconds(7);

        ach[5].transform.DOMoveX(startX, 1.0f);
        achActive = false;
    }

    IEnumerator TriggerAch7()
    {
        achActive = true;
        hasAchieved[6] = 1;
        ach[6].transform.DOMoveX(endX, 1.0f);
        PlayerPrefs.SetInt("Achievement7", hasAchieved[6]);
        if (!achievementSound.isPlaying)
        {
            achievementSound.PlayOneShot(achievementSound.clip);
        }

        yield return new WaitForSeconds(7);

        ach[6].transform.DOMoveX(startX, 1.0f);
        achActive = false;
    }

    IEnumerator TriggerAch8()
    {
        achActive = true;
        hasAchieved[7] = 1;
        ach[7].transform.DOMoveX(endX, 1.0f);
        PlayerPrefs.SetInt("Achievement8", hasAchieved[7]);
        if (!achievementSound.isPlaying)
        {
            achievementSound.PlayOneShot(achievementSound.clip);
        }

        yield return new WaitForSeconds(7);

        ach[7].transform.DOMoveX(startX, 1.0f);
        achActive = false;
    }
}
