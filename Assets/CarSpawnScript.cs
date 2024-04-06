using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawnScript : MonoBehaviour
{
    public GameObject[] cars;
    private int carsCount;
    public float spawnRate = 2;
    private float timer = 0;
    // Start is called before the first frame update

    void spawnCar()
    {
        Instantiate(cars[Random.Range(0,carsCount)], transform.position, transform.rotation);
    }

    void Start()
    {
        carsCount = cars.Length;
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
