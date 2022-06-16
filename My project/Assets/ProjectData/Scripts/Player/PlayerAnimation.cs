using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    PlayerControler pControler;

    public void Initialize()
    {
        pControler = GetComponent<PlayerControler>();
    }
}
