using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawnScript : MonoBehaviour
{
    public GameObject car;
    public float spawnRate = 2;
    private float timer = 0;
    // Start is called before the first frame update

    void spawnCar()
    {
        Instantiate(car, transform.position, transform.rotation);
    }

    void Start()
    {
        timer += Random.Range(0, spawnRate);
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            timer = 0;
            spawnCar();
        }
    }
}
