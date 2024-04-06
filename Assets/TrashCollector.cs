using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TrashCollector : MonoBehaviour
{
    // Start is called before the first frame update
    public static TrashCollector instance;
    private Stack<int> trashCollection = new Stack<int>();
    public LightingScript lightScript;

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

    public void ThrowBlueTrash()
    {
        if(trashCollection.Count != 0)
        {
            if (trashCollection.Peek() == 2)
            {
                Debug.Log("Throwing away blue trash");
                lightScript.AddEnergy(2);
                trashCollection.Pop();
                trash--;
            }
        }
    }

    public void ThrowYellowTrash()
    {
        if (trashCollection.Count != 0)
        {
            if (trashCollection.Peek() == 0)
            {
                Debug.Log("Throwing away yellow trash");
                lightScript.AddEnergy(2);
                trashCollection.Pop();
                trash--;
            }
        }
            
    }

    public void ThrowGreenTrash()
    {
        if (trashCollection.Count != 0)
        {
            if (trashCollection.Peek() == 3)
            {
                Debug.Log("Throwing away green trash");
                lightScript.AddEnergy(2);
                trashCollection.Pop();
                trash--;
            }
        }
            
    }

    public void ThrowBrownTrash()
    {
        if (trashCollection.Count != 0)
        {
            if (trashCollection.Peek() == 1)
            {
                Debug.Log("Throwing away brown trash");
                lightScript.AddEnergy(2);
                trashCollection.Pop();
                trash--;
            }
        }
            
    }

    public void IncreaseTrash(int t, int tClass)
    {
        trash +=t;
        trashCollection.Push(tClass);
    }
}
