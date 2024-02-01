using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class EnemySpawnController : MonoBehaviour
{
    public GameObject enemyPrefab;

    public int rows;

    public int columns;
    
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = -rows / 2; i < rows / 2; i++)
        {
            for (int j = -columns / 2; j < columns/2; j++)
            {
                var enemy = Instantiate(enemyPrefab, this.transform);

                enemy.transform.Translate(Vector3.right * j + Vector3.up * i);
            }
        }

        StartCoroutine(MoveEnemies());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator MoveEnemies()
    {
        while (true)
        {
            this.transform.Translate(Vector3.down* speed);

            yield return new WaitForSeconds(1);
            
            this.transform.Translate(Vector3.left * speed);

            yield return new WaitForSeconds(0.5f);

            this.transform.Translate(Vector3.right * speed);

            yield return new WaitForSeconds(0.5f);
        }
    }
}
