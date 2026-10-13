using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangeIndicator : MonoBehaviour
{
    public Tower1 tower;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
    }
    private void OnMouseOver()
    {
        gameObject.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        gameObject.transform.localScale = new Vector3(tower.range, tower.range, 1f);
    }
}
