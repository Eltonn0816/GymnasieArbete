using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    public SpriteRenderer sr;
    public float maxHp = 100f;
    public Slider hpBar;
    public float currenthp = 100f;
    public Sprite sprite1;
    public Sprite sprite2;
    public Sprite sprite3;
    public Sprite sprite4;
    // Start is called before the first frame update
    private void Awake()
    {
        SpriteRenderer sr = GetComponent<SpriteRenderer>();
        currenthp = maxHp; 
    }

    // Update is called once per frame
    private void Update()
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
public class LVL1 : EnemyHealth
{
    private void Awake()
    {
        sr.sprite = sprite1;
        currenthp = maxHp;
    }
}
public class LVL2 : EnemyHealth
{
    private void Awake()
    {
        sr.sprite = sprite2;
        currenthp = maxHp + 50;
        
    }
}
public class LVL3 : EnemyHealth
{
    private void Awake()
    {
        sr.sprite = sprite3;
        currenthp = maxHp + 100;
    }
}
public class LVL4 : EnemyHealth
{
    private void Awake()
    {
        sr.sprite = sprite4;
        currenthp = maxHp + 150;
    }
}
