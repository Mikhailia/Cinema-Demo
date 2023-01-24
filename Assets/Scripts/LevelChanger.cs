using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour
{
    public int LevelToLoad;

    public void SceneChange()
    {
        SceneManager.LoadScene(LevelToLoad);
    }

}
