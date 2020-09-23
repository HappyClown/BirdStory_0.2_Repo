using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Diagnostics;

public class LoadScene : MonoBehaviour
{
    public bool loadNewScene;

    void Update()
    {
        if (loadNewScene) {
            StartCoroutine(LoadSceneTime());
            loadNewScene = false;
        }
    }

    IEnumerator LoadSceneTime () {
        // Stopwatch sw = new Stopwatch();
        // sw.Start();
        SceneManager.LoadSceneAsync(0, LoadSceneMode.Additive);
        //yield return null;
        // if (SceneManager.GetSceneByBuildIndex(0).isLoaded) {
        //     sw.Stop();
        //     print ("Scene was loaded in:" + sw.ElapsedMilliseconds + "ms");
        // }
        yield return null;
    }
}
