using UnityEngine;

public class PlayerShipMovement : MonoBehaviour
{

    int speed = 4;
    KeyCode left = KeyCode.A;
    KeyCode right = KeyCode.D;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
  

        if (Input.GetKey(left))
        {
            transform.position += new Vector3(-1, 0, 0) * speed * Time.deltaTime;
        }
        if (Input.GetKey(right))
        {
            transform.position += new Vector3(1, 0, 0) * speed * Time.deltaTime;
        }

        Transform firepoint = transform.Find("FirePoint");
        firepoint.localPosition = new Vector3(-firepoint.localPosition.x, firepoint.localPosition.y,
        firepoint.localPosition.z);


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Border1"))
        {
            transform.position = new Vector3(10, -4, 0);


        }
        if (collision.CompareTag("Border2"))
        {
            transform.position = new Vector3(-10, -4, 0);


        }
    }

}


