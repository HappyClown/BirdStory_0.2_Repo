using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;

public class LoadSpread : MonoBehaviour
{
    // Establish an order of importance and need for which game object should be loaded first. If a single game object takes too long, split it up.
    public bool oneByOne, allAtOnce;
    public GameObject[] sceneObjects;
    // The basic is everything that is required to be used in the scene right away.
    // The rest can be created / fully loaded in after the basics have gone through their 'Start' functions.
    void Update() {
        if (oneByOne) {
            oneByOne = false;
            StartCoroutine(SceneStartOneByOne());
        }
        if (allAtOnce) {
            allAtOnce = false;
            StartCoroutine(SceneStartAllAtOnce());
        }
    }
    IEnumerator SceneStartOneByOne() {
        int counter = sceneObjects.Length;
        for (int i = 0; i < counter; i++) {
            sceneObjects[i].SetActive(true);
            yield return null;
        }
    }
    IEnumerator SceneStartAllAtOnce() {
        int counter = sceneObjects.Length;
        for (int i = 0; i < counter; i++) {
            sceneObjects[i].SetActive(true);
        }
        yield return null;
    }
}
