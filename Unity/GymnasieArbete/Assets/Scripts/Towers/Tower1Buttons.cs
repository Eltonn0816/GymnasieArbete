using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower1Buttons : MonoBehaviour
{
    public Tower1 t1; 
    // Start is called before the first frame update
    void Start()
    {
  
    }
    public void upgradedmg()
    {
        t1.upgradedamage();
        Debug.Log("Button 1 clicked");
    }
    public void upgraderange()
    {
        t1.upgraderange();
        Debug.Log("Button 2 clicked");
    }
    public void upgradefirerate()
    {
        t1.upgradefirerate();
        Debug.Log("Button 3 clicked");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
