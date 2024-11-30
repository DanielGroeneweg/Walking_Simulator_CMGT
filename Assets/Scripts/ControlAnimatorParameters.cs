using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlAnimatorParameters : MonoBehaviour
{
    public Animator animator;
    public string parameterName;

    public void EnableBool()
    {
        animator.SetBool(parameterName, true);
    }

    public void DisableBool()
    {
        animator.SetBool(parameterName, false);
    }
}