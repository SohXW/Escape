﻿using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using DG.Tweening;

public class SpringJumpLeft : MonoBehaviour
{
    public Movement move;
    public float springForce;
    private Animator anim;
    public AudioSource springsound;

    // Start is called before the first frame update
    void Start()
    {
        move = FindObjectOfType<Movement>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Dummy_Player")
        {
            anim.SetTrigger("hitSpringLeft"); 
            move.spring(1, springForce);
        }
    }
    void Springsound()
    {
        springsound.Play();
    }
}
