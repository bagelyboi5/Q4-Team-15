using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRespawnScript : MonoBehaviour
{
    public GameObject UnitThatDied;
    public GameObject EnemyUnitToSpawn;
    public GameObject EnemyBase;
    public Vector3 UnitThatDiedPosition;
   public void UnitDied()
    {
        if (UnitThatDied.GetComponent<Soldiers>().IsEnemey == true)
        {
            StartCoroutine(SpawnUnit());
            UnitThatDiedPosition = UnitThatDied.transform.position;
        }
        Destroy(UnitThatDied);
    }



    IEnumerator SpawnUnit()
    {
       yield return new WaitForSeconds(10);
        Instantiate(EnemyUnitToSpawn, UnitThatDiedPosition, Quaternion.identity, null);
        
    }
}
