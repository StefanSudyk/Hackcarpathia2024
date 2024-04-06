using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class DeadPlayer : MonoBehaviour
{
    public Sprite replacementSprite;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.CompareTag("Car"))
        {
            
            if (gameObject.CompareTag("Player"))
            {
               
                Die();
            }
        }
    }
    void Die()
    {
        GameObject newObject = new GameObject("ReplacementSprite");
        newObject.transform.position = transform.position;
        newObject.transform.rotation = transform.rotation;
        SpriteRenderer spriteRenderer = newObject.AddComponent<SpriteRenderer>();
        spriteRenderer.sprite = replacementSprite;
        gameObject.SetActive(false);
    }
}
