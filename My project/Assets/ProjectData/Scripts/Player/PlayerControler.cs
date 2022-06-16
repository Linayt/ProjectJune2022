using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(CharacterController))]

[RequireComponent(typeof(PlayerAnimation))]
[RequireComponent(typeof(PlayerInput))]
[RequireComponent(typeof(PlayerFx))]
[RequireComponent(typeof(PlayerMovement))]

public class PlayerControler : MonoBehaviour
{
    PlayerAnimation pAnimation;
    PlayerMovement pMovement;
    PlayerFx pFx;
    PlayerInput pInput;


    private void Awake()
    {
        pAnimation = GetComponent<PlayerAnimation>();
        pAnimation.Initialize();

        pMovement = GetComponent<PlayerMovement>();
        pMovement.Initialize();

        pFx = GetComponent<PlayerFx>();
        pFx.Initialize();

        pInput = GetComponent<PlayerInput>();
        pInput.Initialize();
    }

}
