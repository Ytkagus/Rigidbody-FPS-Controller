using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DilationTimer : MonoBehaviour
{
    public float startTime = 3;
    public float curretTime;
    public bool timerStart = false;

    private void Start()
    {
        curretTime = startTime;
    }

    private void Update()
    {
        Timer();
    }

    public void Timer()
    {
        if (curretTime > 0 && timerStart)
        {
            curretTime -= Time.deltaTime;
            Debug.Log(curretTime);
        }
        else
        {
            timerStart = false;
            if (curretTime <= startTime)
            {
                curretTime += Time.deltaTime;
            }
        }
    }

    #region Getters

    public bool CanRunTimer()
    {
        if (curretTime >= startTime / 2 || timerStart)
        {

            return true;
        }
        else
        {
            return false;
        }
    }

    public float GetValue()
    {
        return curretTime / startTime;
    }
    #endregion

}
