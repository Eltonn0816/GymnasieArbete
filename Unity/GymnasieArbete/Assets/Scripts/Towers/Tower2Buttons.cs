using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Tower2Buttons : MonoBehaviour
{
    public Tower2 t2;
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
        t2.upgradedamage2();
        Debug.Log("Button 1 clicked");
    }
    public void upgraderange()
    {
        t2.upgraderange2();
        Debug.Log("Button 2 clicked");
    }
    public void upgradefirerate()
    {
        t2.upgradefirerate2();
        Debug.Log("Button 3 clicked");
    }
    // Update is called once per frame
    void Update()
    {

    }
}
