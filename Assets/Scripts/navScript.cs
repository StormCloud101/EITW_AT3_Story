using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class navScript : MonoBehaviour
{
    // load a specific scene with a delay
    public void LoadMyScene(string sceneName)
    {
        StartCoroutine(LoadSceneWithDelay(sceneName, 0.5f));
    }

    // This delay is used to load a scene after playing the sound
    private IEnumerator LoadSceneWithDelay(string sceneName, float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(sceneName);
    }
}