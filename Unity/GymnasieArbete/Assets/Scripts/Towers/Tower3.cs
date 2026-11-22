using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
public class Tower3 : MonoBehaviour
{
    public CircleCollider2D C;
    public float range = 2f;
    public float damage = 7;
    public float firerate = 0.9f;
    public TextMeshProUGUI Upgradetext3;
    //public TowerPlacement tp;
    public bool ishovering = false;
    public GameObject bulletprefab3;
    public bool targetset = false;
    private Collider2D target;
    public Tower3Buttons t3b;

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
        GameObject projectile = Instantiate(bulletprefab3, transform.position, transform.rotation);
        Vector3 direction = (target.transform.position - transform.position).normalized;
        projectile.GetComponent<Rigidbody2D>().velocity = direction * 1f;
        yield return new WaitForSeconds(firerate); //shooting rate
    }
    public void upgradedamage3()
    {
        float damageup = Mathf.Round(Random.Range(4f, 11f) * 100f) / 100f;
        damage += damageup;
        Upgradetext3.text = "Dmg up " + damageup.ToString();
        t3b.panel.SetActive(false);
    }
    public void upgraderange3()
    {
        float rangeup = Mathf.Round(Random.Range(0.3f, 0.7f) * 100f) / 100f;
        range += rangeup;
        Upgradetext3.text = "Range up " + rangeup.ToString();
        C.radius = range;
        t3b.panel.SetActive(false);
    }
    public void upgradefirerate3()
    {
        float firerateup = Mathf.Round(Random.Range(0.15f, 0.3f) * 100f) / 100f;
        firerate -= firerateup;
        Upgradetext3.text = "Firing rate up " + firerateup.ToString();
        t3b.panel.SetActive(false);
    }
}
