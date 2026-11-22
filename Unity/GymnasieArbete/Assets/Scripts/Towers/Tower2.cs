using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
public class Tower2 : MonoBehaviour
{
    public CircleCollider2D C;
    public float range = 2f;
    public float damage = 7;
    public float firerate = 0.9f;
    public TextMeshProUGUI Upgradetext2;
    //public TowerPlacement tp;
    public bool ishovering = false;
    public GameObject bulletprefab2;
    public bool targetset = false;
    private Collider2D target;
    public Tower2Buttons t2b;

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
        GameObject projectile = Instantiate(bulletprefab2, transform.position, transform.rotation);
        Vector3 direction = (target.transform.position - transform.position).normalized;
        projectile.GetComponent<Rigidbody2D>().velocity = direction * 1f;
        yield return new WaitForSeconds(firerate); //shooting rate
    }
    public void upgradedamage2()
    {
        float damageup = Mathf.Round(Random.Range(2f, 9f) * 100f) / 100f;
        damage += damageup;
        Upgradetext2.text = "Dmg up " + damageup.ToString();
        t2b.panel.SetActive(false);
    }
    public void upgraderange2()
    {
        float rangeup = Mathf.Round(Random.Range(0.2f, 0.4f) * 100f) / 100f;
        range += rangeup;
        Upgradetext2.text = "Range up " + rangeup.ToString();
        C.radius = range;
        t2b.panel.SetActive(false);
    }
    public void upgradefirerate2()
    {
        float firerateup = Mathf.Round(Random.Range(0.05f, 0.15f) * 100f) / 100f;
        firerate -= firerateup;
        Upgradetext2.text = "Firing rate up " + firerateup.ToString();
        t2b.panel.SetActive(false);
    }
}
