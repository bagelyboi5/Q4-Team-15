using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sliderDelete : MonoBehaviour
{

    public int sliderVAL;
    public int slid;
    public int max;
    private GameObject player;
    public int sol;
    public int tank;
    public bool Tanktype;

    void Start()
    {
        player = GameObject.Find("Player");
    }

    void Update()
    {
        slid = sliderVAL;
        sol = player.GetComponent<progresiveUniits>().SolKilled;
        tank = player.GetComponent<progresiveUniits>().TankKilled;
        gameObject.GetComponent<Slider>().value = slid;


        if (Tanktype == true)
        {
            sliderVAL = tank;
        }
        else
        {
            sliderVAL = sol;
        }

        if (sliderVAL >= max)
        {
            Destroy(gameObject);
        }
    }
}
