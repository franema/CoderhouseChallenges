using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class ManageTimeOver : MonoBehaviour
{
    [SerializeField] private Timer m_timer;
    [SerializeField] private MainMenu pauseMenu;
    [SerializeField] private MainMenu restartMenu;
    [SerializeField] private GameObject pauseCanvas;
    [SerializeField] private VolumeProfile m_profile;

    private void Start()
    {
        m_timer.onTimeOver += OnTimeOverHandler;
    }
    private void OnTimeOverHandler ()
    {
        GameManager.instance.gameEnded = true;
        GameManager.instance.PauseGame();
        pauseMenu.gameObject.SetActive(false);
        restartMenu.gameObject.SetActive(true);
    }

    

}
