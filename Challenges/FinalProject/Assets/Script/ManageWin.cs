using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ManageWin : MonoBehaviour
{   
    public UnityEvent onWin;

   void OnCollisionEnter(Collision other)
   {
        onWin?.Invoke();
        GameManager.instance.gameEnded = true;
   }
}
