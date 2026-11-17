using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    public float maxHp = 100f;
    public Slider hpBar;
    float currenthp = 100f;
    // Start is called before the first frame update
    void Start()
    {
        currenthp = maxHp; 
    }

    // Update is called once per frame
    void Update()
    {
        hpBar.value = currenthp;
    }
    public void takedamage(int damage)
    {
        currenthp -= damage; 
        if(currenthp <= 0)
        {
            die();
        }
    }
    public void die()
    {
        Destroy(gameObject);
    }
}
