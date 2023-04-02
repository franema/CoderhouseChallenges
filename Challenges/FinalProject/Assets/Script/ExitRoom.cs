using UnityEngine;

public class ExitRoom : MonoBehaviour
{
    private bool alreadyTriggered = false;

    void OnTriggerEnter(Collider other)
    {
        if (!alreadyTriggered)
        {
            GameManager.instance.IncreaseTime();
        }
        alreadyTriggered = true;
    }
}
