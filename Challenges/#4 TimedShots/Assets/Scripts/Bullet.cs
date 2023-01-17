using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float speed;
    public Vector3 direction;
    public float bulletLifetime;
    [SerializeField] private KeyCode duplicateScale;
    private Vector3 newScale = new Vector3(2.0f, 2.0f, 2.0f);


    void Start()
    {
    }

    void Update()
    {
        Shoot();
        killBullet();
        changeScale();
    }

    public void Shoot()
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }

    public void killBullet()
    {
        bulletLifetime -= Time.deltaTime;
        if (bulletLifetime <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void changeScale() 
    {
        if(Input.GetKeyDown(duplicateScale))
        {
            transform.localScale *= 2;
        }
    }
    
}
