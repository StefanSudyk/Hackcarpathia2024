using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class UIKitScript : MonoBehaviour
{
    public TrashCollector trashScript;
    public Sprite bioSprite;
    public Sprite plasticSprite;
    public Sprite glassSprite;
    public Sprite paperSprite;

    private Stack<int> stack;
    private ListView listView;
    // Start is called before the first frame update
    void Start()
    {
        listView = GetComponent<ListView>();
    }

    // Update is called once per frame
    void Update()
    {
        stack = trashScript.trashCollection;
        //RefreshListView();
    }
}
