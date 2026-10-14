using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    private void OnMouseOver()
    {
        circle.SetActive(true);
    }
    private void OnMouseExit()
    {
        circle.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        float targetDiameter = circleCollider.radius * 2f;
        circle.transform.localScale = new Vector3(targetDiameter, targetDiameter, 1f);
    }
}
