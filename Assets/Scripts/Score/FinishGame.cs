using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishGame : MonoBehaviour
{
    private bool WasInvoked = false;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponentInParent<Shooting>() != null && !WasInvoked)
        {
            WasInvoked = true;
            Level.OnLevelFinished?.Invoke();
        }
    }
}
