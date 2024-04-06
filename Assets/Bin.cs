using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bin : MonoBehaviour
{
    public Sprite[] binVariants; 
    private int currentVariantIndex = 0; 
    private TrashCollector collector; 

    void Start()
    {
        collector = FindObjectOfType<TrashCollector>(); 
    }

    void Update()
    {
        if (collector.trash == 0)
        {
            currentVariantIndex = 0;
            gameObject.GetComponent<SpriteRenderer>().sprite = binVariants[currentVariantIndex];
        }
        else if (collector != null)
        {
            
            if (collector.trash >= (currentVariantIndex + 1) * 5 && collector.trash <= 40)
            {
                
                ChangeBinVariant();
            }
        }
    }

    
    private void ChangeBinVariant()
    {
        
        if (currentVariantIndex + 1 < binVariants.Length)
        {
            
            currentVariantIndex++;
            
            gameObject.GetComponent<SpriteRenderer>().sprite = binVariants[currentVariantIndex];
        }
    }
}
