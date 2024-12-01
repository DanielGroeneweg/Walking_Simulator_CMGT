using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlAnimatorParameters : MonoBehaviour
{
    public Animator animator;
    public void EnableBool(string parameterName)
    {
        animator.SetBool(parameterName, true);
    }

    public void DisableBool(string parameterName)
    {
        animator.SetBool(parameterName, false);
    }
}