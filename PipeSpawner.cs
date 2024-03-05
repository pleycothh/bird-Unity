using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 5;
    private float timer = 0;
    public float hight = 10;
    // Start is called before the first frame update
    void Start()
    {
        
            spawPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {        
            spawPipe();
            timer = 0;
        }

    }

    void spawPipe()
    {
        float lowestPoint = transform.position.y - hight;
        float highestPoint = transform.position.y + hight;
        Instantiate(
        pipe, 
        new Vector3( transform.position.x, Random.Range(lowestPoint, highestPoint), transform.position.z), 
        transform.rotation);
    }
}
