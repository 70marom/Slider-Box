using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{
    public GameObject[] tilePrefab;
    public Transform playerTransform;
    public float spawnZ = 40.0f;
    public float tileLength = 40.0f;
    public int onScreen = 10;
    public List<GameObject> activeTiles;
    public float SafeZone = 50f;
    public int LastPrefabIndex = 0;

    void Start()
    {
        activeTiles = new List<GameObject>();
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        for (int i = 0; i < onScreen; i++)
        {
            if (i < 2)
            {
                SpawnTile(0);
            }
            else
            {
                SpawnTile();
            }
        }
    }

    void Update()
    {
        if(playerTransform.position.z - SafeZone> (spawnZ - onScreen * tileLength))
        {
            SpawnTile();
            DeleteTile();
        }
    }
    public void SpawnTile(int prefabIndex = -1)
    {
        GameObject go;
        if(prefabIndex == -1)
        {
            go = Instantiate(tilePrefab[RandomPreIndex()]) as GameObject;
        }
        else
        {
            go = Instantiate(tilePrefab[prefabIndex]) as GameObject;
        }
        go.transform.SetParent(transform);
        go.transform.position = Vector3.forward * spawnZ;
        spawnZ = spawnZ + tileLength;
        activeTiles.Add(go);
    }
    public void DeleteTile()
    {
        Destroy(activeTiles[0]);
        activeTiles.RemoveAt(0);
    }
    public int RandomPreIndex()
    {
        if(tilePrefab.Length <= 1)
        {
            return 0;
        }
        int randomIndex = LastPrefabIndex;
        while(randomIndex == LastPrefabIndex)
        {
            randomIndex = Random.Range(0, tilePrefab.Length);
        }
        LastPrefabIndex = randomIndex;
        return randomIndex;
    }
}
