using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingSprite : MonoBehaviour
{
    public bool lerp;
    public Vector2 lerpPosOne, lerpPosTwo;
    public float timeForOneLerp;
    public float timer = 0f;

    void Update()
    {
        if (lerp) {
            timer += Time.deltaTime / timeForOneLerp;
            this.transform.position = Vector2.Lerp(lerpPosOne, lerpPosTwo, timer);
            if (timer >= 1) {
                Vector2 tempLerpPos = lerpPosOne;
                lerpPosOne = lerpPosTwo;
                lerpPosTwo = tempLerpPos;
                timer = 0f;
            }
        }
    }
}
