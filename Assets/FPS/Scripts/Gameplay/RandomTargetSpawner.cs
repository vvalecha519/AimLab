using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomTargetSpawner : MonoBehaviour
{
    public GameObject targetPrefab;
    private double nextUpdate=1;
    public Globals.DifficultySettings m_settings;

    void Awake()
    {
    }

    // Update is called once per frame
    void Update(){
        m_settings = Globals.getDifficultySettings();
        // If the next update is reached
        if (Time.time>=nextUpdate){
             // Change the next update (current second+1)
            nextUpdate=Time.time + m_settings.SpawnRate;
             // Call your fonction
            UpdateEverySecond();
        }
     }
     
     // Update is called once per second
     void UpdateEverySecond(){
          Vector3 position = new Vector3(Random.Range(-20.0f, -30.0f), 2, Random.Range(-6.0f, 6.0f));
          GameObject target = Instantiate(targetPrefab, position, Quaternion.identity);
          Destroy(target, m_settings.TargetLife);
     }
}
