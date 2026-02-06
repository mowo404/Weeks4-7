using UnityEngine;

public class BirdShow : MonoBehaviour
{
    private bool On = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (On == true)
        {
            gameObject.SetActive(true);
        }

        if (On == false)
        {
            gameObject.SetActive(false);
        }
    }

    public void BirdButton()
    {
       On = true;
    }

    public void BirdButtonOff()
    {
        On = false;
    }
}
