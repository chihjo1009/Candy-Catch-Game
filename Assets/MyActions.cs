//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/MyActions.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @MyActions : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @MyActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""MyActions"",
    ""maps"": [
        {
            ""name"": ""PlayerActions"",
            ""id"": ""162c58e7-60d9-4cae-81f0-35b133a02a15"",
            ""actions"": [
                {
                    ""name"": ""MoveLeftRight"",
                    ""type"": ""Value"",
                    ""id"": ""8a1918b1-ee9d-4003-bdee-74e3d4a5fa7c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""342e8fd2-e36c-4d28-bf85-a0be8b0b25e7"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveLeftRight"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""18107114-33f1-470f-8c1e-1eb7505b6c52"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveLeftRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""c7a451a0-2dcb-4554-888a-7e20fc050825"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveLeftRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlayerActions
        m_PlayerActions = asset.FindActionMap("PlayerActions", throwIfNotFound: true);
        m_PlayerActions_MoveLeftRight = m_PlayerActions.FindAction("MoveLeftRight", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // PlayerActions
    private readonly InputActionMap m_PlayerActions;
    private IPlayerActionsActions m_PlayerActionsActionsCallbackInterface;
    private readonly InputAction m_PlayerActions_MoveLeftRight;
    public struct PlayerActionsActions
    {
        private @MyActions m_Wrapper;
        public PlayerActionsActions(@MyActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @MoveLeftRight => m_Wrapper.m_PlayerActions_MoveLeftRight;
        public InputActionMap Get() { return m_Wrapper.m_PlayerActions; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActionsActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActionsActions instance)
        {
            if (m_Wrapper.m_PlayerActionsActionsCallbackInterface != null)
            {
                @MoveLeftRight.started -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnMoveLeftRight;
                @MoveLeftRight.performed -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnMoveLeftRight;
                @MoveLeftRight.canceled -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnMoveLeftRight;
            }
            m_Wrapper.m_PlayerActionsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MoveLeftRight.started += instance.OnMoveLeftRight;
                @MoveLeftRight.performed += instance.OnMoveLeftRight;
                @MoveLeftRight.canceled += instance.OnMoveLeftRight;
            }
        }
    }
    public PlayerActionsActions @PlayerActions => new PlayerActionsActions(this);
    public interface IPlayerActionsActions
    {
        void OnMoveLeftRight(InputAction.CallbackContext context);
    }
}
