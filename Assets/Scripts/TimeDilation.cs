using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeDilation : MonoBehaviour
{
    [SerializeField] private float timeScale;
    [SerializeField] private FovSelector fovSelector;
    [SerializeField] private DilationTimer dilationTimer;

    private void Update()
    {
        if (Input.GetKey(KeyCode.E)&& dilationTimer.CanRunTimer())
        {
            dilationTimer.timerStart = true;
            Time.timeScale = timeScale;
            fovSelector.onTimeStop = true;
        }
        else
        {
            dilationTimer.timerStart = false;
            Time.timeScale = 1;
            fovSelector.onTimeStop = false;
        }
    }

    
}
