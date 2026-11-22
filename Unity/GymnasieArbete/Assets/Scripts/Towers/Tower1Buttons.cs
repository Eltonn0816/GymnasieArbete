using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Tower1Buttons : MonoBehaviour
{
    public Tower1 t1;
    public GameObject panel;
    // Start is called before the first frame update
    void Start()
    {
       panel.SetActive(false);
    }
    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            panel.SetActive(true);
        }
    }
    public void upgradedmg()
    {
        t1.upgradedamage1();
        Debug.Log("Button 1 clicked");
    }
    public void upgraderange()
    {
        t1.upgraderange1();
        Debug.Log("Button 2 clicked");
    }
    public void upgradefirerate()
    {
        t1.upgradefirerate1();
        Debug.Log("Button 3 clicked");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
