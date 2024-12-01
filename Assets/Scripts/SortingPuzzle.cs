using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SortingPuzzle : MonoBehaviour
{
    public bool smallestBoxCorrect;
    public bool secondSmallestBoxCorrect;
    public bool secondBiggestBoxCorrect;
    public bool biggestBoxCorrect;

    public UnityEvent correct;
    public void SmallestBoxState(bool value) {  smallestBoxCorrect = value; }
    public void SecondSmallestBoxState(bool value) { secondSmallestBoxCorrect = value; }
    public void SecondBiggestBoxState(bool value) { secondBiggestBoxCorrect = value; }
    public void BiggestBoxState(bool value) { biggestBoxCorrect = value; }

    public void CheckPuzzle()
    {
        if (smallestBoxCorrect && secondSmallestBoxCorrect && secondBiggestBoxCorrect && biggestBoxCorrect)
        {
            correct?.Invoke();
        }
    }
}
