using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;

public class CarRightMoveScript : MonoBehaviour
{
    public float carSpeed;
    private GameObject trash;
    private int trashClass;
    public GameObject[] trashPrefabs;
    private float trashLocation;
    private bool isPlaced = false;

    // 0 - plastik
    // 1 - bio
    // 2 - papier
    // 3 - szk³o

    // Start is called before the first frame update
    void Start()
    {
        trashClass = Random.Range(0, 4);
        trashLocation = Random.Range((float)-8.4, (float)8.4);

        trash = trashPrefabs[trashClass];

        float randomMult = Random.Range((float)0.7, (float)1.3);
        carSpeed *= randomMult;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > 11)
        {
            Destroy(gameObject);
        }
        if (transform.position.x > trashLocation && !isPlaced)
        {
            Instantiate(trash, transform.position, transform.rotation);
            isPlaced = true;
        }
        transform.position += Vector3.right * carSpeed * Time.deltaTime;
    }
}