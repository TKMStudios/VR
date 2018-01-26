using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IngameMenuManager : MonoBehaviour
{

    public GameObject inGameMenu;

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void MainScene()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void LoadWhiteboardScene()
    {
        SceneManager.LoadScene("Whiteboard");
    }

    public void LoadInteratebleScene()
    {
        SceneManager.LoadScene("VRMovement");
    }

    public void Quit()
    {
    #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
    #else
        Application.Quit ();
    #endif
    }

}
