using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LightingScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject darkPlane;
    public float energyLevel;
    public float energyDecreaseRate; // Pr�dko�� spadku energii na jednostk� czasu
    [SerializeField] private TMP_Text energyDisplay;

    void Start()
    {
        energyLevel = 100;
        energyDecreaseRate = 1.5f;
    }

    private void OnGUI()
    {
        energyDisplay.text = energyLevel.ToString();
    }

    void Update()
    {
        // Zmniejszaj poziom energii z czasem
        energyLevel -= energyDecreaseRate * Time.deltaTime;

        // Ogranicz energi� do zakresu [0, 100]
        energyLevel = Mathf.Clamp(energyLevel, 0, 100);
        Debug.Log(energyLevel);

        // Ustaw przezroczysto�� na podstawie poziomu energii
        if(energyLevel > 30)
        {
            SetTransparency(0);
        }
        if (energyLevel < 30 && energyLevel > 1)
        {
            float transparency = Mathf.Lerp(0, 1, (30 - energyLevel) / 30f); // Interpoluj przezroczysto�� od 0 do 1 w zale�no�ci od poziomu energii
            SetTransparency(transparency);
        }
    }

    public void SetTransparency(float transparency)
    {
        Color color = darkPlane.GetComponent<SpriteRenderer>().color;
        color.a = transparency;
        darkPlane.GetComponent<SpriteRenderer>().color = color;
    }

    public void AddEnergy(float energy)
    {
        energyLevel += energy;
    }
}
