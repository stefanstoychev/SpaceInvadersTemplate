using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnDestroy()
    {
        var gos = GameObject.FindGameObjectsWithTag("Enemy");

        if (gos.Length == 0)
        {
            SceneManager.LoadScene("YouWinScene");
        }
    }
}
