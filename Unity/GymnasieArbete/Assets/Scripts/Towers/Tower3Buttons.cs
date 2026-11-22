using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Tower3Buttons : MonoBehaviour
{
    public Tower3 t3;
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
        t3.upgradedamage3();
        Debug.Log("Button 1 clicked");
    }
    public void upgraderange()
    {
        t3.upgraderange3();
        Debug.Log("Button 2 clicked");
    }
    public void upgradefirerate()
    {
        t3.upgradefirerate3();
        Debug.Log("Button 3 clicked");
    }
    // Update is called once per frame
    void Update()
    {

    }
}
