using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;

public class Exit : MonoBehaviour
{
    public void QuitApplication()
    {
        Application.Quit(0);
    }

    public void OnQuitButtonClicked()
    {
        QuitApplication();
    }
}

