using UnityEngine;

public class Tile : MonoBehaviour
{
    [SerializeField] private float Speed;
    [SerializeField] private float MaxZPos;
    [SerializeField] private float ChanceToSpawnObject;

    [SerializeField] private GameObject[] OnTileObjects;
    [SerializeField] private GameObject[] BorderDecorations;

    [SerializeField] private Transform[] ObjectJoints;
    [SerializeField] private Transform[] DecorationsPoints;

    [SerializeField] private bool spawnLoot;

    private void Start()
    {
        AddOnTileObjects();
        AddBorderDecorations();
        Level.OnLevelFinished += StopTiles;
    }
    private void StopTiles()
    {
        Speed = 0;
    }

    private void Update()
    {
        transform.position += new Vector3(0, 0, Speed * Time.deltaTime );

        if(transform.position.z >= MaxZPos)
            Destroy(gameObject);
    }

    private void AddBorderDecorations()
    {
        foreach(Transform point in DecorationsPoints)
        {
            Instantiate(BorderDecorations[Random.Range(0, BorderDecorations.Length-1)], point.position, point.rotation).transform.SetParent(point);
        }
    }

    private void AddOnTileObjects()
    { 
        if (!spawnLoot) return;

        if (OnTileObjects.Length == 0) return;

        foreach (Transform joint in ObjectJoints)
        {
            if(NeedSpawnObject())
            {
                GameObject objectToSpawn = OnTileObjects[Random.Range(0, OnTileObjects.Length)];
                Level.IncreaseAllBoxAmount(objectToSpawn);
                Instantiate(objectToSpawn, joint);
            }
        }
    }

    private bool NeedSpawnObject()
    {
        return Random.Range(0, 100) <= ChanceToSpawnObject;
    }

    private void OnDestroy()
    {
        Level.OnLevelFinished -= StopTiles;
    }
}
