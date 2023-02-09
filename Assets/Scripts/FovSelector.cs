using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FovSelector : MonoBehaviour
{
    [SerializeField] private Camera playerCamera;
    [SerializeField] private float fov = 90;
    [SerializeField] private float timeStopFov = 110;
    [SerializeField] private float sprintFov = 100;
    [SerializeField] private float timeBtwFow = 1;
    [HideInInspector] public bool onWall;
    [HideInInspector] public bool onTimeStop;
    [HideInInspector] public bool onSprint;

    private void Update()
    {

        if (onWall|| onTimeStop)
        {
            ChangeFov(timeStopFov);
        }
        else if (onSprint)
        {
            ChangeFov(sprintFov);
        }     
        else
        {
            ChangeFov(fov);
        }
    }
    private void ChangeFov(float fov)
    {
        playerCamera.fieldOfView = Mathf.Lerp(playerCamera.fieldOfView, fov, timeBtwFow * Time.deltaTime);

    }

}
