using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shrinker : MonoBehaviour
{

    [SerializeField] private Vector3 shrinked = new Vector3(0.2f, 0.2f, 0.2f);
    private Vector3 notShrinked = new Vector3(1f, 1f, 1f);
    private bool isShrinked = false;
    private float timer;

    void OnTriggerEnter(Collider other)
    {
        if (Time.time > timer)
        {
            if (!isShrinked)
            {
                other.transform.localScale = shrinked;
            }
            else
            {
                other.transform.localScale = notShrinked;
            }

            isShrinked = !isShrinked;
        }

        timer = Time.time + 2;
    }
}
