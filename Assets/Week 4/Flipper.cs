using UnityEngine;

public class Flipper : MonoBehaviour
{
    public float speed;
    //stored boolean that checks if button is pressed.
    private bool isMoving = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if()
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
        

      

    }
    public void OnMoveClick()
    {
        isMoving = true;
    }

    public void OnStopClick()
    {
        isMoving = false;
    }
}
