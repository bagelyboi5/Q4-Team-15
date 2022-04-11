using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRespawnScript : MonoBehaviour
{
    public GameObject UnitThatDied;
    public GameObject EnemyUnitToSpawn;
    public GameObject EnemyBase;
    public Vector3 UnitThatDiedPosition;
    public List<Vector3> DeadUnitPositon;
   public void UnitDied()
    {
        if (UnitThatDied.GetComponent<Soldiers>().IsEnemey == true)
        {
            DeadUnitPositon.Add(UnitThatDiedPosition);
            StartCoroutine(SpawnUnit());
            UnitThatDiedPosition = UnitThatDied.transform.position;
        }
        Destroy(UnitThatDied);
    }

    public IEnumerator SpawnUnit()
    {
        yield return new WaitForSeconds(10);
        Instantiate(EnemyUnitToSpawn, DeadUnitPositon[1], Quaternion.identity, null);
        DeadUnitPositon.RemoveAt(1);
        
    }




}
