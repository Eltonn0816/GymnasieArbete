using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class RangeIndicator : MonoBehaviour
{
    public Tower1 tower;
    public GameObject circle;
    public CircleCollider2D circleCollider;
    // Start is called before the first frame update
    void Start()
    {
        circle.SetActive(false);
    }
  
    void OnMouseEnter()
    {
        Debug.Log("mouse is over");
        circle.SetActive(true);
    }
    void OnMouseExit()
    {
        Debug.Log("mouse exited");
        circle.SetActive(false);

    }
    // Update is called once per frame
    void Update()
    {
        float targetDiameter = circleCollider.radius * 2f;
        circle.transform.localScale = new Vector3(targetDiameter, targetDiameter, 1f);
    }
}
