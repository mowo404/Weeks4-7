using JetBrains.Annotations;
using System;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public float t;
    public float tMax;
    public GameObject wolfballoon;
    public GameObject currentspawn;
    public bool button = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //spawn wolf when game is run
        SpawnWolf();
    }

    // Update is called once per frame
    void Update()
    {

        if (button)
        {
            //decreasing time in seconds
            t -= Time.deltaTime;
        }

        //if time is less than 0 spawn balloon again and reset timer
        if(t < 0 )
        {
            t = tMax;

            SpawnWolf();
        }
    }
    
    public void TimerReset()
    {
        t = tMax;
        
    }

    public void SpawnWolf()
    {
        button = false;

        //delcare wolf position 
        Vector3 wolfpos = Vector3.zero;
        wolfpos.x = -3.39f;
        wolfpos.y = -0.65f;

        //track which prefab balloon is currently spawned in and spawn game object after time is under 0
        currentspawn = Instantiate(wolfballoon, wolfpos, Quaternion.identity);
    }

    public void PopPressed()
    {
        //destory currentSpawned balloon object and reset timer if button is pressed
        Destroy(currentspawn);
        TimerReset();
        button = true;
    }

    public void SpinPressed()
    {
        //fetch class from wolfballon script
        WolfBalloon balloonscript = currentspawn.GetComponent<WolfBalloon>();
        //fetch bool for spin
        balloonscript.Spin = !balloonscript.Spin; 

    }
}
