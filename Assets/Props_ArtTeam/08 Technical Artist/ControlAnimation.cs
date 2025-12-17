using NUnit.Framework;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditorInternal;
using UnityEngine;

public class ControlAnimation : MonoBehaviour
{
    public Animator animator;
    public Animations animations;

    public enum Animations
    {
        Run, 
        Headbust,
        BrokenGlass,
        PunchesWindow,
        EnterWindow,
        HandAttack,
        Die01,
        Die02
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SetAnimation(animations);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SetAnimation(Animations anim)
    {
        animator.SetInteger("AnimationSelected",(int)anim);
    }

}
