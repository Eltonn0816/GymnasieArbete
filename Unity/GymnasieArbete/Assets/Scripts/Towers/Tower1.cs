using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements; 
public class Tower1 : MonoBehaviour
{
    public CircleCollider2D C;
    public float range = 3f;
    public float damage = 5;
    public float firerate = 1;
    public TextMeshProUGUI Upgradetext;
    //public TowerPlacement tp;
    public GameObject panel;
    public bool ishovering = false;
    // Start is called before the first frame update'

    void Start()
    {
        panel.SetActive(false);
        C = GetComponent<CircleCollider2D>();
    }
    
    // Update is called once per frame
    void Update()
    {
       
    }
    private void OnMouseEnter()
    {
        ishovering = true;
        if (Input.GetMouseButtonDown(0) && ishovering)
        {
          panel.SetActive(true);
        }
    }
    private void OnMouseExit()
    {
        ishovering = false; 
        panel.SetActive(false);
    }
    public void upgradedamage()
    {
        float damageup = Mathf.Round(Random.Range(0.3f, 3f) * 100f) / 100f;
        damage += damageup; 
        Upgradetext.text = "Dmg up " + damageup.ToString();
        panel.SetActive(false);
    }
    public void upgraderange()
    {
        float rangeup = Mathf.Round(Random.Range(0.2f, 0.6f) * 100f) / 100f;
        range += rangeup;
        Upgradetext.text = "Range up " + rangeup.ToString();
        C.radius = range;
        panel.SetActive(false);
    }
    public void upgradefirerate()
    {
        float firerateup = Mathf.Round(Random.Range(0.1f, 0.3f)* 100f) / 100f;
        firerate -= firerateup;
        Upgradetext.text = "Firing rate up " + firerateup.ToString();
        panel.SetActive(false);
    }   
}
