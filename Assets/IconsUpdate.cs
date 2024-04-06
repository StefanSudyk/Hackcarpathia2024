using System.Collections;
using System.Collections.Generic;
using UnityEditor.Timeline;
using UnityEngine;

public class IconsUpdate : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bioIcon;
    public GameObject glassIcon;
    public GameObject plasticIcon;
    public GameObject paperIcon;
    private Stack<int> trashNums;
    public TrashCollector trashCollector;
    public Transform parent;
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        //trashNums = trashCollector.trashCollection;
        //foreach (int type in trashNums)
        //{
        //    if(type == 0)
        //    {
        //        Instantiate(plasticIcon);
        //    }
        //    else if (type == 1)
        //    {
        //        Instantiate(bioIcon);
        //    }
        //    else if (type == 2)
        //    {
        //        Instantiate(paperIcon);
        //    }
        //    else if (type == 3)
        //    {
        //        Instantiate(glassIcon);
        //    }
        //}
    }

    public void addBio()
    {
        Instantiate(bioIcon, parent);
    }

    public void addGlass()
    {
        Instantiate(glassIcon, parent);
    }

    public void addPaper()
    {
        Instantiate(paperIcon, parent);
    }
    public void addPlastic()
    {
        Instantiate(plasticIcon, parent);
    }

    public void abortChild()
    {
        if(transform.childCount > 0)
        {
            Transform lastChild = transform.GetChild(transform.childCount - 1);

            // Usuñ ostatnie dziecko
            Destroy(lastChild.gameObject);
        }
    }
}
