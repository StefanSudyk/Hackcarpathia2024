using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TrashCollector : MonoBehaviour
{
    // Start is called before the first frame update
    public static TrashCollector instance;
    private Stack<int> trashCollection = new Stack<int>();

    [SerializeField] private TMP_Text trashDisplay;
    private int trash;
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

    public void IncreaseTrash(int t, int tClass)
    {
        trash +=t;
        trashCollection.Push(tClass);
    }
    // Update is called once per frame
    
}
