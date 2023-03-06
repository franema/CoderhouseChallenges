using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private AudioMixer audioMixer;
    public void PlayGame ()
    {
        SceneManager.LoadScene("FirstScene");
    }

    public void QuitGame ()
    {
        Application.Quit();
        Debug.Log("Quit");
    }

    public void SetVolume (float volume)
    {
        audioMixer.SetFloat("MasterVolume", volume);
        Debug.Log(volume);
    }

    public void BackToMenu ()
    {
        SceneManager.LoadScene("MainMenu");
    }


    
}
