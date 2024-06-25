using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot2 : MonoBehaviour
{
    [SerializeField] Transform shootPoint;
    [SerializeField] GameObject Bullet;
    [SerializeField] float shootSpeed = 0.2f;

    float tempCounter = 0f;
    // Start is called before the first frame update
    void Start()
    {
    }

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
        Instantiate(Bullet, shootPoint.position, shootPoint.rotation);
    }
}
