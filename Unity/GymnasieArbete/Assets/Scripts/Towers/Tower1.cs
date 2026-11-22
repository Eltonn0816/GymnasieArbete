using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
public class Tower1 : MonoBehaviour
{
    public CircleCollider2D C;
    public float range = 2f;
    public float damage = 5;
    public float firerate = 1f;
    public TextMeshProUGUI Upgradetext1;
    //public TowerPlacement tp;
    public bool ishovering = false;
    public GameObject bulletprefab1;
    public bool targetset = false;
    private Collider2D target;
    public Tower1Buttons t1b; 

    // Start is called before the first frame update'

    public void Awake()
    {
        C.radius = range;
    }

    // Update is called once per frame
    void Update()
    {
     
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            target = other;
            StartCoroutine(ShootAtTarget());
            Debug.Log("Enemy spotted");
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            target = null;
            StopCoroutine(ShootAtTarget());
        }
    }

    private IEnumerator ShootAtTarget()
    {        
       GameObject projectile = Instantiate(bulletprefab1, transform.position, transform.rotation);
       Vector3 direction = (target.transform.position - transform.position).normalized;
       projectile.GetComponent<Rigidbody2D>().velocity = direction * 1f;
       yield return new WaitForSeconds(firerate); //shooting rate
    }
    public void upgradedamage1()
    {
        float damageup = Mathf.Round(Random.Range(1f, 6f) * 100f) / 100f;
        damage += damageup;
        Upgradetext1.text = "Dmg up " + damageup.ToString();
        t1b.panel.SetActive(false);
    }
    public void upgraderange1()
    {
        float rangeup = Mathf.Round(Random.Range(0.1f, 0.3f) * 100f) / 100f;
        range += rangeup;
        Upgradetext1.text = "Range up " + rangeup.ToString();
        C.radius = range;
        t1b.panel.SetActive(false);
    }
    public void upgradefirerate1()
    {
        float firerateup = Mathf.Round(Random.Range(0.03f, 0.1f) * 100f) / 100f;
        firerate -= firerateup;
        Upgradetext1.text = "Firing rate up " + firerateup.ToString();
        t1b.panel.SetActive(false);
    }
}
