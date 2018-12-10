using UnityEngine;

public class PillarSpawning : MonoBehaviour
{
    public GameObject pillar;    
    public float spawnTime = 3f;            
    public Transform[] spawnPoints;
    //public Transform[] pillarColors;



    void Start()
    {
        InvokeRepeating("Spawn", spawnTime, spawnTime);
    }


    void Spawn()
    {
        int spawnPointIndex = Random.Range(0, spawnPoints.Length);
        //int pillarColorsIndex = Random.Range(0, pillarColors.Length);

        Instantiate(pillar, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
    }

   
}