using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class ManageCameras : MonoBehaviour
{
    [SerializeField] private CinemachineVirtualCamera camera1; 
    [SerializeField] private CinemachineVirtualCamera camera2;
    [SerializeField] private CinemachineVirtualCamera camera3;
    private CinemachineVirtualCamera[] cameraArray; 
    private int counter = 0;
    void Start()
    {
        cameraArray = new CinemachineVirtualCamera[] {camera1, camera2, camera3};
    }

    void Update()
    {
        ChangeCamera();
    }

    private void ChangeCamera()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            cameraArray[counter].gameObject.SetActive(false);
            counter += 1;
            if(counter > 2)
            {
                counter = 0;
            }
            cameraArray[counter].gameObject.SetActive(true);
        }
    }
}
