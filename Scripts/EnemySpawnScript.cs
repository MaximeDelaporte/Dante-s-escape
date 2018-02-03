using UnityEngine;
using System.Collections;

public class EnemySpawnScript : MonoBehaviour
{
    public GameObject avare;
    public GameObject avare_inverse;
    public GameObject main;
    public GameObject luxurieux;
    public int avareCount = 5;
    public float avare_inversePercentage;
    public float mainPercentage;
    public float luxurieuxPercentage;
    public Vector3 spawnValues;
    float timer;
    Quaternion spawnRotation = Quaternion.identity;
    Vector3 spawnPosition;


    void Update()
    {
        SpawnWaves();
    }
    IEnumerator SpawnWaves () {
        yield return new WaitForSeconds(1);

        while (true) {
            Debug.Log("yolo");
			
			yield return new WaitForSeconds(1.0f/60.0f); 
				//for (uint i=0; i < hazardCount; ++i)
               
             spawnPosition = new Vector3(-10, Random.Range(-3, 2), 0f);
       
             Instantiate(avare_inverse, spawnPosition, spawnRotation);
        /*if (Random.value <= 24 / 100.0f)
        {
            spawnPosition = new Vector3(-10, Random.Range(-3, 2), 0f);
            Instantiate(avare_inverse, spawnPosition, spawnRotation);
        }
        else
        {
            if (Random.value <= 30 / 100.0f)
            {
                spawnPosition = new Vector3(10, Random.Range(-3, 2), 0f);
                Instantiate(main, spawnPosition, spawnRotation);
            }
            else
            {
                if (Random.value <= 15 / 100.0f)
                {
                    spawnPosition = new Vector3(10, Random.Range(-3, 2), 0f);
                    Instantiate(luxurieux, spawnPosition, spawnRotation);
                }
                else
                {
                    spawnPosition = new Vector3(10, Random.Range(-3, 2), 0f);
                    Instantiate(avare, spawnPosition, spawnRotation);
                }
            }*/
        }
    }
}