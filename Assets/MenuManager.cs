////using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{

    public GameObject mainMenu;
    public GameObject optionsMenu;

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void LoadLevel()
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

    public void Options()
    {
        mainMenu.SetActive(false);
        optionsMenu.SetActive(true);
    }

    public void BackToMainMenu()
    {
        mainMenu.SetActive(true);
        optionsMenu.SetActive(false);
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
