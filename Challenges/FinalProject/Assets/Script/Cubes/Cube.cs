using UnityEngine;
using UnityEngine.Events;


public class Cube : MonoBehaviour
{
    public UnityEvent onPlayerCollided;

    public void Move(float speed, float directionInverter, Vector3 direction)
    {
        gameObject.transform.position += direction * speed * directionInverter * Time.deltaTime;
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name.Equals("Erika Archer"))
        {
            onPlayerCollided?.Invoke();
        }
    }
    
}
