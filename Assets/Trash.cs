using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trash : MonoBehaviour
{
    //AudioManager manager;
    [SerializeField] private int value;
    private bool hasTrigerred;

    private TrashCollector collector;
    // Start is called before the first frame update
    void Start()
    {
        collector = TrashCollector.instance;
    }

    // Update is called once per frame

    

    private void OnCollisionEnter2D(Collision2D other)
    {
        //if (other.CompareTag("Player") && !hasTrigerred)
       // {
            hasTrigerred = true;
            collector.IncreaseTrash(value);
            Destroy(gameObject);
            //manager.Playy(manager.pickUp);
       // }
    }
}
