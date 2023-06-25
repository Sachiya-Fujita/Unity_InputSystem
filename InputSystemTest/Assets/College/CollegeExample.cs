using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CollegeExample : MonoBehaviour, CollegeExampleAction.IPlayerActions
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTest(InputAction.CallbackContext context)
    {
        throw new System.NotImplementedException();
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        throw new System.NotImplementedException();
    }

    public void OnWeakSkill(InputAction.CallbackContext context)
    {
        throw new System.NotImplementedException();
    }

    public void OnStrongSkill(InputAction.CallbackContext context)
    {
        throw new System.NotImplementedException();
    }
}
