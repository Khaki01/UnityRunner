using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathAnimate : MonoBehaviour {

    Animator anim;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        anim = GetComponent<Animator>();
        anim.SetInteger("changer", 2);
    }
}
