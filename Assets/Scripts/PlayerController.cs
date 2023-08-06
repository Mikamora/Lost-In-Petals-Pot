using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Animator anim;

    public float speed;

    public GameObject particleEffect;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerInput = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0);
        transform.position += playerInput.normalized * (speed * Time.deltaTime);

        if (playerInput == Vector3.zero)
        {
            anim.SetBool("isRunning", false);
        }
        else
        {
            anim.SetBool("isRunning", true);
        }
    }

    // private void OnTriggerEnter2D(Collider2D other)
    //{
      //  if (other.tag == "enemy")
        //{
          //  DestroyThing.DestroyIt(other.gameObject);
        //}
    //}
}
