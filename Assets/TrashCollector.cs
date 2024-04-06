using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TrashCollector : MonoBehaviour
{
    // Start is called before the first frame update
    public static TrashCollector instance;
    [SerializeField] private TMP_Text trashDisplay;
    public int trash;
    private void Awake()
    {
        if (!instance)
        {
            instance = this;
        }
    }
    private void OnGUI()
    {
        trashDisplay.text = trash.ToString();
    }

    public void IncreaseTrash(int t)
    {
        trash +=t;
        
    }
    // Update is called once per frame
    
}
