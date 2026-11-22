using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TowerPlacement : MonoBehaviour
{
    public GameObject tower1; 
    public GameObject tower2;
    public GameObject tower3;
    public GameObject panel;
    public Currencymanager cm;
    // Start is called before the first frame update
    void Start()
    {
        cm = GameObject.Find("CurrencyManager").GetComponent<Currencymanager>();
        panel.SetActive(false);
    }
    private void OnMouseOver()
    {
        if(Input.GetMouseButtonDown(0))
        {
            panel.SetActive(true);
        }
    }
    public void spawn1()
    {
        if(cm.Currency >= 300)
        {
            Instantiate(tower1, gameObject.transform.position, transform.rotation);
            Destroy(gameObject);
            panel.SetActive(false);
            cm.Currency -= 300;
        }
        if(cm.Currency < 300)
        {
            panel.SetActive(false);
        }
      
    }
    public void spawn2()
    {
        if (cm.Currency >= 750)
        {
            Instantiate(tower2, gameObject.transform.position, transform.rotation);
            Destroy(gameObject);
            panel.SetActive(false);
            cm.Currency -= 750;
        }
        if(cm.Currency < 750)
        {
            panel.SetActive(false);
        }  
    }
    public void spawn3()
    {
        if(cm.Currency >= 1500)
        {
            Instantiate(tower3, gameObject.transform.position, transform.rotation);
            Destroy(gameObject);
            panel.SetActive(false);
            cm.Currency -= 1500;
        }
        if(cm.Currency < 1500)
        {
            panel.SetActive(false);
        }
   
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
