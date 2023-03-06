using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;


public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private float _timeLeft = 120;
    public float timeLeft => _timeLeft;
    private float timeToAdd = 20;
    public int evenOrOdd = 0;
    public bool statuesAreMoving = false;
    [SerializeField] private KeyCode menuKey;
    [SerializeField] private GameObject pauseCanvas;
    private bool isPaused = false;
    public bool onSight = false;
    public Transform indicatorTargetTransform;
    public event Action onPlayerActivatedLever;
    [SerializeField] private Timer m_timer;
    public bool gameEnded = false;



    private void Update()
    {
        if (Input.GetKeyDown(menuKey) && !gameEnded)
        {
            if (isPaused)
            {
                Resume();
            }
            else
            {
                PauseGame();
            }
        }
    }

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
        Resume();
    }

    public void DecreaseTime()
    {
        _timeLeft -= Time.deltaTime;
    }

    public void IncreaseTime()
    {
        _timeLeft += timeToAdd;
    }

    public void SetTimerToZero()
    {
        _timeLeft = 0;
    }


    public void Activate(GameObject objectToActivate)
    {
        // Debug.Log(objectToActivate.name);
        if (objectToActivate.name.Equals("LeverFinal"))
        {
            objectToActivate.GetComponent<LeverController>().Activate();
        }

        if (objectToActivate.name.Equals("LeverMoveStatues"))
        {
            objectToActivate.GetComponent<MoveStatuesLever>().MoveStatues();            
        }

        if (objectToActivate.name.Equals("LeverInverseMoveStatues"))
        {
            objectToActivate.GetComponent<InverseStatuesMoveLever>().InverseStatuesMove();
        }

        if(objectToActivate.name.Equals("StopCubeLever") || objectToActivate.name.Equals("StopCubeLever1"))
        {
            onPlayerActivatedLever.Invoke();
        }
    }

    public void PauseGame()
    {
        pauseCanvas.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void Resume()
    {
        pauseCanvas.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }
    
}