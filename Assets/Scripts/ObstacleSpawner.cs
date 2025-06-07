using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject Obsticle;
    public float maxX;
    public float minX;
    public float maxY;
    public float minY;
    public float TimeBetweenSpawn;
    private float SpawnTime;

    void Start()
    {
        // Initialize the first spawn time
        SpawnTime = Time.time + TimeBetweenSpawn;
    }

    void Update()
    {
        if (Time.time > SpawnTime)
        {
            Spawn();
            SpawnTime = Time.time + TimeBetweenSpawn;
        }
    }

    void Spawn()
    {
        float X = Random.Range(minX, maxX);  // Fixed: was using maxY instead of maxX
        float Y = Random.Range(minY, maxY);

        Instantiate(Obsticle, transform.position + new Vector3(X, Y, 0), transform.rotation);
    }
}