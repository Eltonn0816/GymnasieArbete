using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WaveCounter : MonoBehaviour
{
    public Spawner s;
    public int wavecount = 0;
    public TextMeshProUGUI wavetext;
    public int maxwave;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       wavecount = s.wave; 
       wavetext.text = "Wave: " + wavecount.ToString() + "/" + maxwave.ToString();
    }
}
