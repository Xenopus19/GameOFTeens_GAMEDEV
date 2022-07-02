using System;
using UnityEngine;

public class PlayerDeath : MonoBehaviour, IDieable
{
    [SerializeField] private GameObject Effects;
    public Action OnDie;

    public void Die()
    {
        Instantiate(Effects, transform.position, Quaternion.identity, transform.parent);
        Destroy(gameObject);
        OnDie?.Invoke();
    }
}
