using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarRightMoveScript : MonoBehaviour
{
    public float carSpeed;
    // Start is called before the first frame update
    void Start()
    {
        float randomMult = Random.Range((float)0.7, (float)1.3);
        carSpeed *= randomMult;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x > 19)
        {
            Destroy(gameObject);
        }
        transform.position += Vector3.right * carSpeed * Time.deltaTime;
    }
}
