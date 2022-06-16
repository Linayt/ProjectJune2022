using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFx : MonoBehaviour
{
    PlayerControler pControler;

    public void Initialize()
    {
        pControler = GetComponent<PlayerControler>();
    }
}
