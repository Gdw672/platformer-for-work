using System.Collections;
using UnityEngine;

public class ClimbButton : MonoBehaviour
{
    public delegate void onButtonOff();
    public static ClimbButton climbButtonSingltone;
    public event onButtonOff? velocityZero;
    protected ClimbButton() { }

    private void Awake()
    {
        climbButtonSingltone = this;
    }

    private IEnumerator Start()
    {
        yield return new WaitForEndOfFrame();
        gameObject.SetActive(false);
    }

    public static ClimbButton getSingltone()
    {
        return climbButtonSingltone;
    }


    private void OnDisable()
    {
        velocityZero.Invoke();
    }
}
