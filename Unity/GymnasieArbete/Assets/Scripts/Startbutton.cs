using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Startbutton : MonoBehaviour
{
    public Spawner s;
    // Start is called before the first frame update
    void Start()
    {
        
    }  
    public void round()
    {
        s.startround();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
