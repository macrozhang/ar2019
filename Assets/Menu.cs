using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public Button Exit;
    public Button ScanP;
    public Button ScanW;
    public Button Introduction;
    // Start is called before the first frame update
    void Start()
    {
        Exit.onClick.AddListener(EXIT);
        ScanP.onClick.AddListener(SP);
        ScanW.onClick.AddListener(SW);
        Introduction.onClick.AddListener(IT);
    }

    private void IT()
    {
        SceneManager.LoadScene("Introduction");
    }

    private void SW()
    {
        SceneManager.LoadScene("TextRecognition");
    }

    private void SP()
    {
        SceneManager.LoadScene("ImageRecognition");
    }

    private void EXIT()
    {
        Debug.Log("exit");
        Application.Quit();
    }
}
