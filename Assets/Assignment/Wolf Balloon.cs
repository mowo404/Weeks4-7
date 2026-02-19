using UnityEngine;

public class WolfBalloon : MonoBehaviour
{
    public float rSpeed;
    public bool Spin = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //rotate if spin = true
        if (Spin)
        {
            //set currentRotation of balloon to increasing by rSpeed * deltaTime
            Vector3 currentRotation = transform.eulerAngles;
            currentRotation.z += rSpeed * Time.deltaTime;
            transform.eulerAngles = currentRotation;
        }
    }
}
