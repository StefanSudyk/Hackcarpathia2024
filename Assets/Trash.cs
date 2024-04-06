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
        // 0 - plastik
        // 1 - bio
        // 2 - papier
        // 3 - szk³o
        int trashClass=0;

        hasTrigerred = true;
        if (gameObject.name.Contains("0"))
        {
            trashClass = 0;
        }
        else if (gameObject.name.Contains("1"))
        {
            trashClass = 1;
        }
        else if (gameObject.name.Contains("2"))
        {
            trashClass = 2;
        }
        else if (gameObject.name.Contains("3"))
        {
            trashClass = 3;
        }
            collector.IncreaseTrash(value, trashClass);
            Destroy(gameObject);
            //manager.Playy(manager.pickUp);
       // }
    }
}
