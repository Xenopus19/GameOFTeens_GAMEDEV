using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieCanvas : MonoBehaviour
{
    private Health health;
    void Start()
    {
        health = GameObject.FindGameObjectWithTag("Player").GetComponent<Health>();
        health.OnDie += ActivateDieCanvas;
    }

    private void ActivateDieCanvas()
    {
        gameObject.SetActive(true);
    }

    private void OnDestroy()
    {
        health.OnDie -= ActivateDieCanvas;
    }
}
