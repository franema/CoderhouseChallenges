using UnityEngine;

public class MovingCube : RoundTripCube
{
    [SerializeField] protected MovingCubeData movingCubeData;
    [SerializeField] protected CubeAxisData directionAxis;
    private float timer;
    private float directionInverter = 1;

    private void Start() 
    {
       onReachedWall +=  OnReachedWallHandler;
    }
    private void Update()
    {
        Move(movingCubeData.speed, directionInverter, directionAxis.axis);
        changeDirection(gameObject.transform.position.z);
    }

    public void OnReachedWallHandler(float inverter)
    {
        if (Time.time > timer + 0.3)
        {   
            timer = Time.time;
            directionInverter *= inverter;
        }
    }
}
