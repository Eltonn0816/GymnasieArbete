using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.UIElements;
using UnityEngine;
using TMPro;

public class Currencymanager : MonoBehaviour
{
    public Spawner s; 
    public int Currency;
    public TextMeshProUGUI amount;
    public float targetTime = 1f;
    public int increase;
    // Start is called before the first frame update
    void Start()
    {
        Currency = 0;
    }

    // Update is called once per frame
    void Update()
    {
        targetTime -= Time.deltaTime;
        if(targetTime <= 0f && s.started)
        {
            Currency += increase;
            targetTime = 0.8f; 
        }
        amount.text = Currency.ToString();
    }
}
