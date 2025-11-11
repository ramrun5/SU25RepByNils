using System.Collections;
using System.Collections.Generic;
using UnityEditor.EditorTools;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class Enemy : MonoBehaviour
{
    PointManager points;
    public int health = 100;
    public GameObject Player;
    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
            if (health <= 0)
            {
                points.playerPoints += 1;
            }
        }

    }
    void Die()
    {
        StartCoroutine(Death());
    }
    IEnumerator Death()
    {
            yield return new WaitForSeconds(0f);
        Destroy(gameObject);
    }
// Start is called once before the first execution of Update after the MonoBehaviour is created
void Start()
    {
        points = FindAnyObjectByType<PointManager>();
    }


    // Update is called once per frame
    void Update()
    {

    }
}
    