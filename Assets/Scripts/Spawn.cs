using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    List<GameObject> spawnables;
    public GameObject bread;
    public GameObject burger;
    public GameObject chicken;
    public GameObject croissant;
    public GameObject donut;
    public GameObject eclair;
    public GameObject icecream;
    public GameObject mochi;
    public GameObject pizza;
    public GameObject tacos;

    // Start is called before the first frame update
    void Start()
    {
        spawnables = new List<GameObject>();
        spawnables.Add(bread);
        spawnables.Add(burger);
        spawnables.Add(chicken);
        spawnables.Add(croissant);
        spawnables.Add(donut);
        spawnables.Add(eclair);
        spawnables.Add(icecream);
        spawnables.Add(mochi);
        spawnables.Add(pizza);
        spawnables.Add(tacos);
        

        InvokeRepeating("spawn_random", 1f, 1f);
    }

    void spawn_random()
    {
        Vector3 v3Pos = transform.position + new Vector3(
            Random.value * 10f,
            5,
            -3);
        Quaternion qRotation = Quaternion.Euler(0, Random.value * 360f, Random.value * 30f);
        GameObject createObject = Instantiate(spawnables[Random.Range(0,9)], v3Pos, qRotation);
       

    }
}
