using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxScript : MonoBehaviour
{
    public int scoreAddAmount;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player") Score.Instance.AddScore(scoreAddAmount);
    }
}
