using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class Hand : MonoBehaviour
{
    private float speed;
    Animator animator;
    private float gripTarget;
    private float triggerTarget;
    private float gripCurren;
    private float triggerCurren;
    private string animatorGripParm = "Grip";
    private string animatorTriggerParm = "Trigger";
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        AnimateHand();
    }

    internal void setGrip(float v)
    {
        gripTarget = v;
    }

    internal void SetTrigger(float v)
    {
        triggerTarget = v;
    }
    void AnimateHand()
    {
        if (gripCurren != gripTarget)
        {
            gripCurren = Mathf.MoveTowards(gripCurren, gripTarget, Time.deltaTime * speed);
            animator.SetFloat(animatorGripParm, gripCurren);
        }
        if (triggerCurren != gripTarget)
        {
            triggerCurren = Mathf.MoveTowards(gripCurren, gripTarget, Time.deltaTime * speed);
            animator.SetFloat(animatorTriggerParm, gripCurren);
        }
    }
}
