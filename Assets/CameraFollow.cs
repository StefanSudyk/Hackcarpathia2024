using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public float minX = -5;
    public float maxX = 5;
    public float minY = -3.5f;
    public float maxY = 6.5f;
    private Vector3 offset = new Vector3(0f, 0f, -10f);
    private float smoothTime = 0.15f;
    private Vector3 velocity = Vector3.zero;

    [SerializeField] private Transform target;

    // Update is called once per frame
    // granica x --> 6, -6
    void Update()
    {
        float x = 0f;

        if (target.position.x > minX && target.position.x < maxX)
        {
            x = target.position.x;
        }
        else if (target.position.x < minX)
            x = minX;
        else
            x = maxX;

        float y = 0f;

        if (target.position.y > minY && target.position.y < maxY)
        {
            y = target.position.y;
        }
        else if (target.position.y < minY)
            y = minY;
        else
            y = maxY;

        Vector3 targetPosition = new Vector3(x, y, target.position.z + offset.z);
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
    }
}
