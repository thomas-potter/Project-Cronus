using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] int bulletDamage;
    [SerializeField] float forceForward;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        rb.AddForce(transform.TransformDirection(new Vector3(0f, 0f, forceForward)), ForceMode.Impulse);
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Debug.Log("Hit Enemy");
            other.gameObject.GetComponent<Enemy>().EnemyDamage(bulletDamage);
        }

        Destroy(gameObject);
    }
}
