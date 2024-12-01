using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ControlAnimatorParameters : MonoBehaviour
{
    public Animator animator;
    public UnityEvent match;
    private bool oldState;
    public void EnableBool(string parameterName)
    {
        oldState = animator.GetBool(parameterName);
        animator.SetBool(parameterName, true);
    }

    public void DisableBool(string parameterName)
    {
        oldState = animator.GetBool(parameterName);
        animator.SetBool(parameterName, false);
    }

    public void CheckBool(string parameterName)
    {
        if (oldState != animator.GetBool(parameterName)) match?.Invoke();
    }
}