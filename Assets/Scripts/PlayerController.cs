using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private AnimHandler AnimHandler;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            AnimHandler.SetWalk(true);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            AnimHandler.SetWalk(false);
        }
    }
}
