using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HintManager : MonoBehaviour
{
    public GameObject hint;
    public InteractorText hintIcon;

    // Start is called before the first frame update
    void Awake()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (hintIcon.iAmActive) 
        {
            StartCoroutine(TriggerHint());
        }
    }

    IEnumerator TriggerHint()
    {
        //hint.SetActive(true);
        //Debug.Log("i am started");
        yield return new WaitForSeconds(1);
    }
}
