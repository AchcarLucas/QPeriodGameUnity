using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class ButtonChangeScene : MonoBehaviour
{
    public void OnChangeSceneButtonClick(string scene_name)
    {
        Debug.Log("Loading Scene: " + scene_name);
        SceneManager.LoadScene(scene_name);
    }
}
