using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Holylib.UI;

public class GlobalManager : MonoBehaviour
{

    public static GlobalManager instance;

    private void Awake()
    {
        instance = this;
    }
    public void CloseGame()
    {
        MessageBoxManager.Instance.ShowYesNoQuestion("Are you sure about quitting ?",()=>Application.Quit());
    }
}
