using UnityEngine;

public class ChangingCube : RoundTripCube
{
    [SerializeField] protected MovingCubeData changedCubeData;
    [SerializeField] protected MovingCubeData movingCubeData;
    [SerializeField] protected CubeAxisData directionAxis;
    private float directionInverter = 1;

    private float ownSpeed;
    private bool changed = false;
    private float timer;


    private void Start()
    {
        onReachedWall += OnReachedWallHandler;
        GameManager.instance.onPlayerActivatedLever += OnPlayerActivatedLeverHandler;
        ownSpeed = movingCubeData.speed;
    }
    private void Update()
    {
        Move(ownSpeed, directionInverter, directionAxis.axis);
        changeDirection(gameObject.transform.position.z);
    }

    private void OnPlayerActivatedLeverHandler()
    {
        if (changed)
        {
            changed = false;
            ownSpeed = movingCubeData.speed;
        }
        else
        {
            changed = true;
            ownSpeed = changedCubeData.speed;
        }
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
