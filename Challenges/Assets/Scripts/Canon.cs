using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canon : MonoBehaviour
{


    [SerializeField] private KeyCode shootKeyCode;
    [SerializeField] private KeyCode doubleShootKeyCode;
    [SerializeField] private KeyCode tripleShootKeyCode;
    [SerializeField] private KeyCode quadrupleShootKeyCode;
    public GameObject ball;
    public Transform pointOfShoot;
    private bool canShoot = true;

    private void Update()
    {
        if (canShoot && Input.GetKeyDown(shootKeyCode))
        {
            StartCoroutine(Counter(1));
            Shoot();
        }
        if (canShoot && Input.GetKeyDown(doubleShootKeyCode))
        {
            StartCoroutine(Counter(2));
            Invoke("Shoot", 0.5f);
            Invoke("Shoot", 1.5f);
        }
        if (canShoot && Input.GetKeyDown(tripleShootKeyCode))
        {
            StartCoroutine(Counter(3));
            Invoke("Shoot", 0.5f);
            Invoke("Shoot", 1.5f);
            Invoke("Shoot", 2.5f);
        }
        if (canShoot && Input.GetKeyDown(quadrupleShootKeyCode))
        {
            StartCoroutine(Counter(4));
            Invoke("Shoot", 0.5f);
            Invoke("Shoot", 1.5f);
            Invoke("Shoot", 2.5f);
            Invoke("Shoot", 3.5f);
        }
    }

    private void Shoot()
    {
        Instantiate(ball, pointOfShoot);
        Debug.Log("Shoot");
    }

    IEnumerator Counter(int time)
    {
        canShoot = false;
        yield return new WaitForSeconds(time);
        canShoot = true;
    }


}
