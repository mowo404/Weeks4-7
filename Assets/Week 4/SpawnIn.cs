using UnityEngine;

public class SpawnIn : MonoBehaviour
{
    private bool spawnBird = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (spawnBird == true)
        {
            Vector3 birdposition = transform.position;
            transform.position = new Vector3(0f, 0f, 0f);
        } 


    }

    public void SpawnButton()
    {
        spawnBird = true;
    }
}
