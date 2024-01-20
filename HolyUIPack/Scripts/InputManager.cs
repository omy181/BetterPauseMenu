using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public static InputManager Instance;
    void Awake()
    {
        Instance= this;
    }


    void FixedUpdate()
    {
        MovementInputs();
        
    }

    private void Update()
    {
        PressShift();
        UnPressShift();
        PressSpace();
        PressE();
        UnPressE();
        UnPressESC();
    }

    public Action<float,float> OnMovement;
    void MovementInputs()
    {
        float hor = Input.GetAxisRaw("Horizontal");
        float ver = Input.GetAxisRaw("Vertical");

        if(OnMovement!= null) OnMovement(hor,ver);
    }

    public Action OnPressShift;
    void PressShift()
    {
        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            if(OnPressShift != null) OnPressShift();
        }
    }

    public Action OnUnPressShift;
    void UnPressShift()
    {
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            if (OnUnPressShift != null) OnUnPressShift();
        }
    }

    public Action OnPressSpace;
    void PressSpace()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (OnPressSpace != null) OnPressSpace();
        }
    }

    public Action OnPressE;
    void PressE()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (OnPressE != null) OnPressE();
        }
    }

    public Action OnUnPressE;
    void UnPressE()
    {
        if (Input.GetKeyUp(KeyCode.E))
        {
            if (OnUnPressE != null) OnUnPressE();
        }
    }

    public Action OnUnPressESC;
    void UnPressESC()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            if (OnUnPressESC != null) OnUnPressESC();
        }
    }
}
