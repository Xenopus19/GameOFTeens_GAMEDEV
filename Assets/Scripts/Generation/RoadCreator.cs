using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadCreator : MonoBehaviour
{
    [SerializeField] private Transform SpawnPos;

    [SerializeField] private GameObject Tile;

    [SerializeField] private Transform tilesParent;

    private int StandartTilesAmount;

    private void Start()
    {
        StandartTilesAmount = tilesParent.childCount;
    }

    private void Update()
    {
        CheckSpawn();
    }

    private void CheckSpawn()
    {
        if (tilesParent.childCount<StandartTilesAmount)
        {
            SpawnTile();
        }
    }

    private void SpawnTile()
    {
        Instantiate(Tile, SpawnPos.position, Quaternion.identity).transform.SetParent(tilesParent);
    }
}
