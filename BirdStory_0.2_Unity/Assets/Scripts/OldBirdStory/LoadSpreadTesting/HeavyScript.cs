using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;
using UnityEngine.SceneManagement;

public class HeavyScript : MonoBehaviour
{
    public int iterations = 100000000;
    void Start()
    {
        Stopwatch sw = new Stopwatch();
        sw.Start();
        int counter = 0;
        while (counter < iterations) {
            counter++;
        }
        sw.Stop();
        print ("HeavyScript Start() loop containing: "+ iterations + " iterations was created in: " + sw.ElapsedMilliseconds + "ms");
    }
}
