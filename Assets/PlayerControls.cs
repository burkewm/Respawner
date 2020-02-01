// GENERATED AUTOMATICALLY FROM 'Assets/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""Arm"",
            ""id"": ""cd9afb9a-b9ca-4ad4-b845-a05ae5e9755a"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""52fe0ff3-d43e-4825-b6a9-60e0241d66db"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LiftHand"",
                    ""type"": ""Button"",
                    ""id"": ""f776770b-a369-4678-b3b8-1b55dff3d65d"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LowerHand"",
                    ""type"": ""Button"",
                    ""id"": ""45172158-6a21-44d4-a9be-3bc29a6fb89d"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""3c65c7f2-89cd-4b34-9300-857054a1a409"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": ""Normalize(min=1,max=1)"",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5dbd05f2-7a9b-4e5a-bbe5-3f23387b0754"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LiftHand"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""39cbf514-aeff-4393-bc5f-553dceb6ae49"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LowerHand"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Arm
        m_Arm = asset.FindActionMap("Arm", throwIfNotFound: true);
        m_Arm_Move = m_Arm.FindAction("Move", throwIfNotFound: true);
        m_Arm_LiftHand = m_Arm.FindAction("LiftHand", throwIfNotFound: true);
        m_Arm_LowerHand = m_Arm.FindAction("LowerHand", throwIfNotFound: true);
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

    // Arm
    private readonly InputActionMap m_Arm;
    private IArmActions m_ArmActionsCallbackInterface;
    private readonly InputAction m_Arm_Move;
    private readonly InputAction m_Arm_LiftHand;
    private readonly InputAction m_Arm_LowerHand;
    public struct ArmActions
    {
        private @PlayerControls m_Wrapper;
        public ArmActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Arm_Move;
        public InputAction @LiftHand => m_Wrapper.m_Arm_LiftHand;
        public InputAction @LowerHand => m_Wrapper.m_Arm_LowerHand;
        public InputActionMap Get() { return m_Wrapper.m_Arm; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ArmActions set) { return set.Get(); }
        public void SetCallbacks(IArmActions instance)
        {
            if (m_Wrapper.m_ArmActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_ArmActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_ArmActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_ArmActionsCallbackInterface.OnMove;
                @LiftHand.started -= m_Wrapper.m_ArmActionsCallbackInterface.OnLiftHand;
                @LiftHand.performed -= m_Wrapper.m_ArmActionsCallbackInterface.OnLiftHand;
                @LiftHand.canceled -= m_Wrapper.m_ArmActionsCallbackInterface.OnLiftHand;
                @LowerHand.started -= m_Wrapper.m_ArmActionsCallbackInterface.OnLowerHand;
                @LowerHand.performed -= m_Wrapper.m_ArmActionsCallbackInterface.OnLowerHand;
                @LowerHand.canceled -= m_Wrapper.m_ArmActionsCallbackInterface.OnLowerHand;
            }
            m_Wrapper.m_ArmActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @LiftHand.started += instance.OnLiftHand;
                @LiftHand.performed += instance.OnLiftHand;
                @LiftHand.canceled += instance.OnLiftHand;
                @LowerHand.started += instance.OnLowerHand;
                @LowerHand.performed += instance.OnLowerHand;
                @LowerHand.canceled += instance.OnLowerHand;
            }
        }
    }
    public ArmActions @Arm => new ArmActions(this);
    public interface IArmActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnLiftHand(InputAction.CallbackContext context);
        void OnLowerHand(InputAction.CallbackContext context);
    }
}
