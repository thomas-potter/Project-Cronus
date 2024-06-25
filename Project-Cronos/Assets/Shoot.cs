using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField] LayerMask ShootMask;
    [SerializeField] float range = 10f;
    [SerializeField] int gunDamage = 2;
    [SerializeField] float shootSpeed = 0.2f;
    [SerializeField] float tempCounter = 0f;

    [SerializeField] GameObject muzzleFlashObject;
    [SerializeField] ParticleSystem MuzzleFlashPS;


    // Start is called before the first frame update
    void Start()
    {
        MuzzleFlashPS = gameObject.GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            if (tempCounter <= 0f)  //check if the counter equals 0
            {
                ShootGun();  //spawn the object
                tempCounter = shootSpeed;  //reset the timer or cd
            }
            else
            {
                tempCounter -= Time.deltaTime;  //take down time 
            }
        }
        else
        { 
        tempCounter = 0f;
        }
    }

    void ShootGun()
    {
        Debug.Log("Run");
        MuzzleFlashPS.Play();
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, range))
        {
            Enemy enemy = hit.transform.GetComponent<Enemy>();
            if (enemy != null)
            {
                enemy.EnemyDamage(gunDamage);
            }
        }
        
    }
}
