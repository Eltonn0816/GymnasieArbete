using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lives : MonoBehaviour
{
    public TextMeshProUGUI LivesText;
    public int lives; 
    // Start is called before the first frame update
    void Start()
    {
        lives = 100; 
    }
    public void loselives(int liveslost)
    {
        lives -= liveslost;
    }
    // Update is called once per frame
    void Update()
    {
        LivesText.text = lives.ToString();
        if(lives <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
