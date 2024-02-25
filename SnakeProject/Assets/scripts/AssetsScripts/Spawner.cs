using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject toSpawn;
    [SerializeField] float secontsBetwhenSpawns;
    [SerializeField] int Count;
    float secondsSinceLastSpawn;
    int appleRemainig;
    // Start is called before the first frame update
    void Start()
    {
        secondsSinceLastSpawn = secontsBetwhenSpawns;
        if (GameData.applesRemaning == 0)
        {
            GameData.applesRemaning = Count;
        }
        else
        {
            GameData.applesRemaning += Count;
        }
        appleRemainig = Count;
    }

    // Update is called once per frame
    void Update()
    {
        secondsSinceLastSpawn -= Time.deltaTime;
        if (secondsSinceLastSpawn <= 0 && appleRemainig > 0)
        {
            float randomX = Random.Range(Refences.points[0].position.x, Refences.points[1].position.x);
            float randomY = Random.Range(Refences.points[0].position.y, Refences.points[1].position.y);
            Vector2 randomPosition = new Vector2(randomX, randomY);
            Instantiate(toSpawn, randomPosition, transform.rotation);
            appleRemainig--;
            secondsSinceLastSpawn = secontsBetwhenSpawns;
            Debug.Log("Apples: " + (Count - appleRemainig));
        }
    }
}
