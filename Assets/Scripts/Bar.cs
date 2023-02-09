using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bar : MonoBehaviour

{
    [SerializeField] private DilationTimer dilationTimer;
    [SerializeField] private Scrollbar scrollbar;

    private void Update()
    {
        scrollbar.size = dilationTimer.GetValue();
    }
}