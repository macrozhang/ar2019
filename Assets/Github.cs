using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Github : MonoBehaviour
{
    // Start is called before the first frame update
    public Button btn;
    void Start()
    {
        btn.onClick.AddListener(GotoGitHub);
    }

    private void GotoGitHub()
    {
        Application.OpenURL("https://github.com/macrozhang/ar2019");
    }
}

