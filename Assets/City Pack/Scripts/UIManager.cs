using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject LosePanel;
    public static UIManager Instance;

    private void Awake()
    {
        Instance = this;
    }

    public void ShowLosePanel()
    {
        LosePanel.SetActive(true);

        Time.timeScale = 0.001f;

    }
}
