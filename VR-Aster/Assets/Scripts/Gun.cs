using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Gun : MonoBehaviour
{
    public GameObject projectile;
    public float power;
    public Transform firepoint;

    public Valve.VR.EVRButtonId shootButton;

    public bool automatic;
    public float cooldownTime;
    float time;
    public ParticleSystem Shoottrail;

   GameObject heldObject;

    void Start()
    {
        heldObject = GameObject.FindGameObjectWithTag("Weapon");
    }

    void Update()
    {
        if (time > 0f)
        {
            time -= Time.deltaTime;
        }
        else
        {
            if (heldObject != null && ((TriggerRightDown && !automatic) || (TriggerRightDown && automatic)))
            {
                time = cooldownTime;
                Shoottrail.Play();
                GameObject proj = (GameObject)Instantiate(projectile, firepoint.position, firepoint.rotation);
                proj.GetComponent<Rigidbody>().velocity = firepoint.forward * power;
            }
        }
    }

    public bool TriggerRightDown
    {
        get
        {
            if (Input.GetKeyDown(KeyCode.JoystickButton15))
            {
                return true;
            }
            else
                return false;
        }
    }

    public bool TriggerRight
    {
        get
        {
            if (Input.GetKey(KeyCode.JoystickButton15))
            {
                return true;
            }
            else
                return false;
        }
    }
}
