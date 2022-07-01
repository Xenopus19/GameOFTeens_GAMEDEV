using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    [SerializeField] private GameObject[] OnTileObjects;

    [SerializeField] private Vector3[] ObjectJoints;
    private void Start()
    {
        AddOnTileObjects();
    }

    private void AddOnTileObjects()
    {

    }
}
