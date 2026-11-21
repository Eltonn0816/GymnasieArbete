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
    public TextMeshProUGUI Upgradetext;
    //public TowerPlacement tp;
    public GameObject panel;
    public bool ishovering = false;
    public GameObject bulletprefab;
    public bool targetset = false;
    private GameObject currentTarget;
    private Vector3 target;


    // Start is called before the first frame update'

    public void Awake()
    {
        panel.SetActive(false);
        C = GetComponent<CircleCollider2D>();
        StartCoroutine(ShootAtTarget());
        C.radius = range;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentTarget != null)
        {
            target = currentTarget.transform.position;
        }
    }
    private IEnumerator ShootAtTarget()
    {
        while (true)
        {
            if(targetset && currentTarget != null)
            {
                shoot();
                yield return new WaitForSeconds(firerate);
            }
            else
            {
                yield return null;
            }
        }
    }
    private void OnMouseEnter()
    {
        ishovering = true;
        if (Input.GetMouseButtonDown(0) && ishovering)
        {
            panel.SetActive(true);
        }
    }
    private void OnMouseExit()
    {
        ishovering = false;
        panel.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy") && !targetset)
        {
            currentTarget = other.gameObject;
            targetset = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject == currentTarget)
        {
            Destroy(currentTarget);
            currentTarget = null;
            targetset = false;
        }
    }
    private void shoot()
    {
        GameObject bullet = Instantiate(bulletprefab, transform.position, Quaternion.identity);
        Bullet bulletScript = bullet.GetComponent<Bullet>();
        bulletScript.Initialize(target, damage);

    }
    public void upgradedamage()
    {
        float damageup = Mathf.Round(Random.Range(1f, 6f) * 100f) / 100f;
        damage += damageup;
        Upgradetext.text = "Dmg up " + damageup.ToString();
        panel.SetActive(false);
    }
    public void upgraderange()
    {
        float rangeup = Mathf.Round(Random.Range(0.1f, 0.3f) * 100f) / 100f;
        range += rangeup;
        Upgradetext.text = "Range up " + rangeup.ToString();
        C.radius = range;
        panel.SetActive(false);
    }
    public void upgradefirerate()
    {
        float firerateup = Mathf.Round(Random.Range(0.03f, 0.1f) * 100f) / 100f;
        firerate -= firerateup;
        Upgradetext.text = "Firing rate up " + firerateup.ToString();
        panel.SetActive(false);
    }
    public class Bullet : MonoBehaviour
    {
        private Vector3 target;
        private float damage;

        public void Initialize(Vector3 targetPosition, float bulletDamage)
        {
            target = targetPosition;
            damage = bulletDamage;
            StartCoroutine(MoveTowardsTarget());
        }

        private IEnumerator MoveTowardsTarget()
        {
            while (Vector3.Distance(transform.position, target) > 0.1f)
            {
                transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * 5f);
                yield return null;
            }
            HitTarget();
        }

        private void HitTarget()
        {
            // Assuming the enemy has a method called TakeDamage
           // EnemyHealth.takedamage(damage);
            Destroy(gameObject);
        }
    } 
}
