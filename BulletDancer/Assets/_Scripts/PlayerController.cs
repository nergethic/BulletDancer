using System;
using System.Collections;
using System.Collections.Generic;
using _Config;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour {
    private Controls controls;

    private void OnEnable() {
        controls = new Controls();
        controls.Player.Fire.performed   += OnFire;
        controls.Player.Aim.performed    += OnAim;
        controls.Player.Move.performed   += OnMove;
        controls.Player.Dash.performed   += OnDash;
        controls.Player.Select.performed += OnSelect;
        controls.Player.Back.performed   += OnBack;
        
        controls.Player.Fire.Enable();
        controls.Player.Aim.Enable();
        controls.Player.Move.Enable();
        controls.Player.Dash.Enable();
        controls.Player.Select.Enable();
        controls.Player.Back.Enable();
    }
    
    private void OnDisable() {
        controls.Player.Fire.performed   -= OnFire;
        controls.Player.Aim.performed    -= OnAim;
        controls.Player.Move.performed   -= OnMove;
        controls.Player.Dash.performed   -= OnDash;
        controls.Player.Select.performed -= OnSelect;
        controls.Player.Back.performed   -= OnBack;
        
        controls.Player.Fire.Disable();
        controls.Player.Aim.Disable();
        controls.Player.Move.Disable();
        controls.Player.Dash.Disable();
        controls.Player.Select.Disable();
        controls.Player.Back.Disable();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnFire(InputAction.CallbackContext context) {
        Debug.Log("Fire");
    }
    
    private void OnAim(InputAction.CallbackContext context) {
        Debug.Log("Aim");
    }
    
    private void OnMove(InputAction.CallbackContext context) {
        Debug.Log("Move");
        Vector2 value = context.ReadValue<Vector2>();
    }
    
    private void OnDash(InputAction.CallbackContext context) {
        Debug.Log("Dash");
    }
    
    private void OnSelect(InputAction.CallbackContext context) {
        Debug.Log("Select");
    }
    
    private void OnBack(InputAction.CallbackContext context) {
        Debug.Log("Back");
    }
}
