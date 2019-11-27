using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private BoxCollider2D box;
    public Transform[] SpamList;
    public GameObject[] obj;
    Random rand = new Random();
    public float minSpawn = 0.5f;
    public float maxSpawn = 2.0f;
    float nextSpawn;
    float oldSpawn = 0;

    private void Awake()
    {
        nextSpawn = Random.RandomRange(minSpawn, maxSpawn);
    }
    void Start()
    {
       // SpamList = GetComponentInChildren<Transform>;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > oldSpawn + nextSpawn)
        {
            Spawn(Random.Range(0, obj.Length), Random.Range(0, SpamList.Length));
            nextSpawn = Random.Range(minSpawn, maxSpawn);
            oldSpawn = Time.time;
        }
    }

    void Spawn(int ObjIndex, int spawnPointIndex)
    {
        Instantiate(obj[ObjIndex], SpamList[spawnPointIndex].position, Quaternion.identity);

    }
}
