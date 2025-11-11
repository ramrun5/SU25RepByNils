using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;
public class PlayerBullet : MonoBehaviour
{

    public float speed = 10f;
    public int damage = 10;
    public Rigidbody2D rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb.linearVelocity = transform.up * speed;

    }
    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Enemy enemy = hitInfo.GetComponent<Enemy>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }
        else
        {
            StartCoroutine(Deletee());
        }
    }

    private IEnumerator Deletee()
         {
        yield return new WaitForSeconds(0.5f);
        Destroy(gameObject);
         }

    // Update is called once per frame
    void Update()
    {

    }
}



