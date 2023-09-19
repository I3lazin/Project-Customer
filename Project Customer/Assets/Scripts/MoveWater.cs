using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MoveWater : MonoBehaviour
{

    public float endPosition;
    // Start is called before the first frame update
    void Start()
    {
        transform.DOMoveX(endPosition, 2.0f).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.InOutSine);
    }
}
