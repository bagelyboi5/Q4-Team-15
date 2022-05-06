using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shakecontroll : MonoBehaviour
{

    private Animator shake;

    void Start()
    {
        shake = gameObject.GetComponent<Animator>();
    }

    void Update()
    {
        if (shake.GetBool("shakey"))
        {
            StartCoroutine(WaitTurnOffAnim());
        }
    }
    public IEnumerator WaitTurnOffAnim()
    {
        yield return new WaitForSeconds(0.08f);
        shake.SetBool("shakey", false);
    }
}
