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
                    ""expectedControlType"": ""Vector2"",
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
                },
                {
                    ""name"": ""CloseThumb"",
                    ""type"": ""Button"",
                    ""id"": ""d7fe20cd-98f0-4674-9f14-fb06d74b5c6a"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""CloseIndex"",
                    ""type"": ""Button"",
                    ""id"": ""f370354b-793e-4e4f-a141-6c966f105bc8"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""CloseMiddle"",
                    ""type"": ""Button"",
                    ""id"": ""6c7fe508-bcf0-4d99-8c03-f2fa8f808a2c"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""CloseRing"",
                    ""type"": ""Button"",
                    ""id"": ""6c0b83d6-b528-46c9-b1f9-211659e18210"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ClosePinky"",
                    ""type"": ""Button"",
                    ""id"": ""3449ddd0-607f-46b8-8c6e-6b3b27447bb3"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""KeyboardMovement"",
                    ""type"": ""Value"",
                    ""id"": ""1012ff37-8618-45f1-ab88-bc3dfa1c226a"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Rotate"",
                    ""type"": ""Button"",
                    ""id"": ""782d83d6-ec06-471b-9c79-e88a787c0557"",
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
                    ""groups"": ""Gamepad;Keyboard"",
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
                    ""groups"": ""Gamepad;Keyboard"",
                    ""action"": ""LiftHand"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e9429093-ad28-4a71-b624-d215d636d705"",
                    ""path"": ""<Keyboard>/l"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard;Gamepad"",
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
                    ""groups"": ""Gamepad;Keyboard"",
                    ""action"": ""LowerHand"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7981a4c0-bb22-4a1f-85b0-1b42a40daf40"",
                    ""path"": ""<Keyboard>/k"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard;Gamepad"",
                    ""action"": ""LowerHand"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""38207938-0715-4c7b-aaea-47aa7feada36"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad;Keyboard"",
                    ""action"": ""CloseThumb"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""07d14ce0-0ab6-46d4-ae71-0ed45bef99f5"",
                    ""path"": ""<Keyboard>/h"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard;Gamepad"",
                    ""action"": ""CloseThumb"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""afa3148e-9384-4ebb-bf30-9a7fa25951ce"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad;Keyboard"",
                    ""action"": ""CloseIndex"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5b7c24bf-3bfc-4b8f-9686-312233c3ea68"",
                    ""path"": ""<Keyboard>/u"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad;Keyboard"",
                    ""action"": ""CloseIndex"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""868342b4-7c1a-43f3-8d23-744de39f48e9"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad;Keyboard"",
                    ""action"": ""CloseMiddle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6732682e-1803-43d3-8a06-6580c8e25fd5"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad;Keyboard"",
                    ""action"": ""CloseMiddle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fcb802ce-ce13-4505-ac22-e55cb78268b5"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad;Keyboard"",
                    ""action"": ""CloseRing"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fd762a31-c5a5-4235-9601-903cd1f89153"",
                    ""path"": ""<Keyboard>/o"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad;Keyboard"",
                    ""action"": ""CloseRing"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""482c0739-8037-4b52-b2f7-55d0aecfe00c"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard;Gamepad"",
                    ""action"": ""ClosePinky"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0b7f0068-4e85-4a47-b2d8-2096467a9f58"",
                    ""path"": ""<Keyboard>/p"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad;Keyboard"",
                    ""action"": ""ClosePinky"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""4b136f2e-eb8f-498b-9c65-1cb5ac1b3052"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""KeyboardMovement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""84bcb8bc-9168-43fb-8106-f87bb295906e"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard;Gamepad"",
                    ""action"": ""KeyboardMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""3b801691-7d47-4b11-9f0b-209a9f31d339"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard;Gamepad"",
                    ""action"": ""KeyboardMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""aac70541-94ca-40c9-9562-ad681e0fbee0"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard;Gamepad"",
                    ""action"": ""KeyboardMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""33a1172a-32e9-415b-840d-3d32d3416ff6"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard;Gamepad"",
                    ""action"": ""KeyboardMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""cefa6013-3150-48f2-804d-c75986d538c3"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad;Keyboard"",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""965967e4-aefd-4888-b57a-8245000cfdad"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard;Gamepad"",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Arm
        m_Arm = asset.FindActionMap("Arm", throwIfNotFound: true);
        m_Arm_Move = m_Arm.FindAction("Move", throwIfNotFound: true);
        m_Arm_LiftHand = m_Arm.FindAction("LiftHand", throwIfNotFound: true);
        m_Arm_LowerHand = m_Arm.FindAction("LowerHand", throwIfNotFound: true);
        m_Arm_CloseThumb = m_Arm.FindAction("CloseThumb", throwIfNotFound: true);
        m_Arm_CloseIndex = m_Arm.FindAction("CloseIndex", throwIfNotFound: true);
        m_Arm_CloseMiddle = m_Arm.FindAction("CloseMiddle", throwIfNotFound: true);
        m_Arm_CloseRing = m_Arm.FindAction("CloseRing", throwIfNotFound: true);
        m_Arm_ClosePinky = m_Arm.FindAction("ClosePinky", throwIfNotFound: true);
        m_Arm_KeyboardMovement = m_Arm.FindAction("KeyboardMovement", throwIfNotFound: true);
        m_Arm_Rotate = m_Arm.FindAction("Rotate", throwIfNotFound: true);
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
    private readonly InputAction m_Arm_CloseThumb;
    private readonly InputAction m_Arm_CloseIndex;
    private readonly InputAction m_Arm_CloseMiddle;
    private readonly InputAction m_Arm_CloseRing;
    private readonly InputAction m_Arm_ClosePinky;
    private readonly InputAction m_Arm_KeyboardMovement;
    private readonly InputAction m_Arm_Rotate;
    public struct ArmActions
    {
        private @PlayerControls m_Wrapper;
        public ArmActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Arm_Move;
        public InputAction @LiftHand => m_Wrapper.m_Arm_LiftHand;
        public InputAction @LowerHand => m_Wrapper.m_Arm_LowerHand;
        public InputAction @CloseThumb => m_Wrapper.m_Arm_CloseThumb;
        public InputAction @CloseIndex => m_Wrapper.m_Arm_CloseIndex;
        public InputAction @CloseMiddle => m_Wrapper.m_Arm_CloseMiddle;
        public InputAction @CloseRing => m_Wrapper.m_Arm_CloseRing;
        public InputAction @ClosePinky => m_Wrapper.m_Arm_ClosePinky;
        public InputAction @KeyboardMovement => m_Wrapper.m_Arm_KeyboardMovement;
        public InputAction @Rotate => m_Wrapper.m_Arm_Rotate;
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
                @CloseThumb.started -= m_Wrapper.m_ArmActionsCallbackInterface.OnCloseThumb;
                @CloseThumb.performed -= m_Wrapper.m_ArmActionsCallbackInterface.OnCloseThumb;
                @CloseThumb.canceled -= m_Wrapper.m_ArmActionsCallbackInterface.OnCloseThumb;
                @CloseIndex.started -= m_Wrapper.m_ArmActionsCallbackInterface.OnCloseIndex;
                @CloseIndex.performed -= m_Wrapper.m_ArmActionsCallbackInterface.OnCloseIndex;
                @CloseIndex.canceled -= m_Wrapper.m_ArmActionsCallbackInterface.OnCloseIndex;
                @CloseMiddle.started -= m_Wrapper.m_ArmActionsCallbackInterface.OnCloseMiddle;
                @CloseMiddle.performed -= m_Wrapper.m_ArmActionsCallbackInterface.OnCloseMiddle;
                @CloseMiddle.canceled -= m_Wrapper.m_ArmActionsCallbackInterface.OnCloseMiddle;
                @CloseRing.started -= m_Wrapper.m_ArmActionsCallbackInterface.OnCloseRing;
                @CloseRing.performed -= m_Wrapper.m_ArmActionsCallbackInterface.OnCloseRing;
                @CloseRing.canceled -= m_Wrapper.m_ArmActionsCallbackInterface.OnCloseRing;
                @ClosePinky.started -= m_Wrapper.m_ArmActionsCallbackInterface.OnClosePinky;
                @ClosePinky.performed -= m_Wrapper.m_ArmActionsCallbackInterface.OnClosePinky;
                @ClosePinky.canceled -= m_Wrapper.m_ArmActionsCallbackInterface.OnClosePinky;
                @KeyboardMovement.started -= m_Wrapper.m_ArmActionsCallbackInterface.OnKeyboardMovement;
                @KeyboardMovement.performed -= m_Wrapper.m_ArmActionsCallbackInterface.OnKeyboardMovement;
                @KeyboardMovement.canceled -= m_Wrapper.m_ArmActionsCallbackInterface.OnKeyboardMovement;
                @Rotate.started -= m_Wrapper.m_ArmActionsCallbackInterface.OnRotate;
                @Rotate.performed -= m_Wrapper.m_ArmActionsCallbackInterface.OnRotate;
                @Rotate.canceled -= m_Wrapper.m_ArmActionsCallbackInterface.OnRotate;
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
                @CloseThumb.started += instance.OnCloseThumb;
                @CloseThumb.performed += instance.OnCloseThumb;
                @CloseThumb.canceled += instance.OnCloseThumb;
                @CloseIndex.started += instance.OnCloseIndex;
                @CloseIndex.performed += instance.OnCloseIndex;
                @CloseIndex.canceled += instance.OnCloseIndex;
                @CloseMiddle.started += instance.OnCloseMiddle;
                @CloseMiddle.performed += instance.OnCloseMiddle;
                @CloseMiddle.canceled += instance.OnCloseMiddle;
                @CloseRing.started += instance.OnCloseRing;
                @CloseRing.performed += instance.OnCloseRing;
                @CloseRing.canceled += instance.OnCloseRing;
                @ClosePinky.started += instance.OnClosePinky;
                @ClosePinky.performed += instance.OnClosePinky;
                @ClosePinky.canceled += instance.OnClosePinky;
                @KeyboardMovement.started += instance.OnKeyboardMovement;
                @KeyboardMovement.performed += instance.OnKeyboardMovement;
                @KeyboardMovement.canceled += instance.OnKeyboardMovement;
                @Rotate.started += instance.OnRotate;
                @Rotate.performed += instance.OnRotate;
                @Rotate.canceled += instance.OnRotate;
            }
        }
    }
    public ArmActions @Arm => new ArmActions(this);
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    public interface IArmActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnLiftHand(InputAction.CallbackContext context);
        void OnLowerHand(InputAction.CallbackContext context);
        void OnCloseThumb(InputAction.CallbackContext context);
        void OnCloseIndex(InputAction.CallbackContext context);
        void OnCloseMiddle(InputAction.CallbackContext context);
        void OnCloseRing(InputAction.CallbackContext context);
        void OnClosePinky(InputAction.CallbackContext context);
        void OnKeyboardMovement(InputAction.CallbackContext context);
        void OnRotate(InputAction.CallbackContext context);
    }
}
