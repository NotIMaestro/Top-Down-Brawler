// GENERATED AUTOMATICALLY FROM 'Assets/Input/PlayerMovement.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerMovement : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerMovement()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerMovement"",
    ""maps"": [
        {
            ""name"": ""Control"",
            ""id"": ""e3b5a66b-9592-4624-9d83-aa3a9eb29f64"",
            ""actions"": [
                {
                    ""name"": ""Control Stick"",
                    ""type"": ""Value"",
                    ""id"": ""400716ff-d6f7-403f-9886-c72f99b19280"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""6a983820-830b-4ca8-afdc-5d917aa357d8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Dropitem"",
                    ""type"": ""Button"",
                    ""id"": ""c149530a-1429-476a-8cef-074e580a8d9d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""244fbed6-abdc-4bae-ac91-30b65423a30b"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Control Stick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""031f0dd9-c443-4502-b826-9c68c419df8c"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ad6258d1-21ec-41a2-ba25-10c9afabd987"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dropitem"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Control
        m_Control = asset.FindActionMap("Control", throwIfNotFound: true);
        m_Control_ControlStick = m_Control.FindAction("Control Stick", throwIfNotFound: true);
        m_Control_Jump = m_Control.FindAction("Jump", throwIfNotFound: true);
        m_Control_Dropitem = m_Control.FindAction("Dropitem", throwIfNotFound: true);
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

    // Control
    private readonly InputActionMap m_Control;
    private IControlActions m_ControlActionsCallbackInterface;
    private readonly InputAction m_Control_ControlStick;
    private readonly InputAction m_Control_Jump;
    private readonly InputAction m_Control_Dropitem;
    public struct ControlActions
    {
        private @PlayerMovement m_Wrapper;
        public ControlActions(@PlayerMovement wrapper) { m_Wrapper = wrapper; }
        public InputAction @ControlStick => m_Wrapper.m_Control_ControlStick;
        public InputAction @Jump => m_Wrapper.m_Control_Jump;
        public InputAction @Dropitem => m_Wrapper.m_Control_Dropitem;
        public InputActionMap Get() { return m_Wrapper.m_Control; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ControlActions set) { return set.Get(); }
        public void SetCallbacks(IControlActions instance)
        {
            if (m_Wrapper.m_ControlActionsCallbackInterface != null)
            {
                @ControlStick.started -= m_Wrapper.m_ControlActionsCallbackInterface.OnControlStick;
                @ControlStick.performed -= m_Wrapper.m_ControlActionsCallbackInterface.OnControlStick;
                @ControlStick.canceled -= m_Wrapper.m_ControlActionsCallbackInterface.OnControlStick;
                @Jump.started -= m_Wrapper.m_ControlActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_ControlActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_ControlActionsCallbackInterface.OnJump;
                @Dropitem.started -= m_Wrapper.m_ControlActionsCallbackInterface.OnDropitem;
                @Dropitem.performed -= m_Wrapper.m_ControlActionsCallbackInterface.OnDropitem;
                @Dropitem.canceled -= m_Wrapper.m_ControlActionsCallbackInterface.OnDropitem;
            }
            m_Wrapper.m_ControlActionsCallbackInterface = instance;
            if (instance != null)
            {
                @ControlStick.started += instance.OnControlStick;
                @ControlStick.performed += instance.OnControlStick;
                @ControlStick.canceled += instance.OnControlStick;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Dropitem.started += instance.OnDropitem;
                @Dropitem.performed += instance.OnDropitem;
                @Dropitem.canceled += instance.OnDropitem;
            }
        }
    }
    public ControlActions @Control => new ControlActions(this);
    public interface IControlActions
    {
        void OnControlStick(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnDropitem(InputAction.CallbackContext context);
    }
}
