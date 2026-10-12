using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    public float maxHp = 100f;
    public Slider hpBar;
    float currenthp = 100f;
    public float dmgTaken;
    // Start is called before the first frame update
    void Start()
    {
        currenthp = maxHp; 
    }

    // Update is called once per frame
    void Update()
    {
        hpBar.value = currenthp;
        Debug.Log("hello damage taken");
    }
}
