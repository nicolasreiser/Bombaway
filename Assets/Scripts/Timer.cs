using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : Singleton<Timer>
{
    private float time;

    protected override void Awake()
    {
        base.Awake();
        time = 60;
    }
    void Update()
    {
        time -= Time.deltaTime;
    }

    public int getTimeScore()
    {
        float finalTime = time / 10;
        finalTime = Mathf.FloorToInt(finalTime);
        finalTime = finalTime * 10;
        Debug.Log("Time Score : " + finalTime);
        return (int)finalTime;
    }
}
