using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class EnemySpawn : MonoBehaviour
{
    public int numEnemies = 10; 
    public GameObject prefab; 
    int originalChildren;
    Transform enemy;
    Random rand = new Random();

    void makeAChild()
    {
        float childX = rand.Next(50);
        float childZ = rand.Next(50);

        GameObject newChild = Instantiate(prefab, new Vector3(childX, 10f, childZ), Quaternion.identity) as GameObject;
        newChild.transform.parent = enemy;
    }
    void Start()
    {
        enemy = GameObject.Find("Enemy").transform;

        for (int i = 0; i < numEnemies; i++)
        {
            makeAChild();
        }
        originalChildren = transform.childCount;
    }

    // Update is called once per frame
    void Update()
    {
        int currentChildren = transform.childCount;

        if (currentChildren < originalChildren)
        {
            makeAChild();
        }
    }
}
