using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Scan_Photo : MonoBehaviour
{
    public Button Back;
    // Start is called before the first frame update
    void Start()
    {
        Back.onClick.AddListener(BACK);
    }

    private void BACK()
    {
        SceneManager.LoadScene("Menu");
    }
}
