using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lantern : MonoBehaviour
{
    public Sprite lanternsOff;
    private TrashCollector collector;

    void Start()
    {
        collector = FindObjectOfType<TrashCollector>();
    }

    void Update()
    {
        if (collector.trash >= 3)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = lanternsOff;
        }
    }
}