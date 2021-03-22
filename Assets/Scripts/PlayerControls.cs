// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/PlayerControls.inputactions'

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
            ""name"": ""GamePlay"",
            ""id"": ""c2a4b8c1-9d49-4092-b4fd-1250506eb431"",
            ""actions"": [
                {
                    ""name"": ""StickLeft"",
                    ""type"": ""Value"",
                    ""id"": ""2e47bdf2-5292-4061-ae73-eb7537884855"",
                    ""expectedControlType"": ""Stick"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""StickRight"",
                    ""type"": ""Value"",
                    ""id"": ""07876c56-596e-4f52-b522-668e2410b2c1"",
                    ""expectedControlType"": ""Stick"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""KeyMoveForward"",
                    ""type"": ""Button"",
                    ""id"": ""59d322cb-76da-40c7-8abc-3882243efb0f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RestartLevel"",
                    ""type"": ""Button"",
                    ""id"": ""122f42b2-dbaf-4c43-a8f5-ac1fdc5d03a7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""KeyMoveBackward"",
                    ""type"": ""Button"",
                    ""id"": ""85fa5c62-4db4-448c-9377-a9984325550a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""KeyTurnLeft"",
                    ""type"": ""Button"",
                    ""id"": ""c2fdf0f7-66b7-4a67-bddd-5871b2ba2338"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""KeyTurnRight"",
                    ""type"": ""Button"",
                    ""id"": ""3ce0556a-6e55-412f-9f2f-50f51fb9e04b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LeftHandbrake"",
                    ""type"": ""Button"",
                    ""id"": ""161ec02e-30c7-4f4f-8ed3-4a93b56cb916"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RightHandbrake"",
                    ""type"": ""Button"",
                    ""id"": ""311a29b0-a89c-496f-9427-d6862a1c66c9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""6467cbf5-e3d6-4d61-af74-def8102a14e6"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""StickLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""75266737-080e-4358-bb68-86e3b3382f46"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""StickRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""67516118-321a-4d4d-88d0-ef446b7eb217"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""KeyMoveForward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e0032ce9-1b86-44fb-9aa6-25ad8f9e7fa1"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RestartLevel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""94c3a66d-bd3d-413e-ac0d-a5990d8134d1"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RestartLevel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fc777f7c-a30a-4a23-ab51-6aab58718762"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""KeyMoveBackward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0d0e82dd-2903-499f-9915-31b17aac20d8"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""KeyTurnLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cd1bbc50-5d79-4860-9377-ca90e78c53a3"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""KeyTurnRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ce98578d-7307-468c-9fde-7567285b382e"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftHandbrake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5103d65f-1a7c-47ca-bf63-6e367fbde5d9"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightHandbrake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // GamePlay
        m_GamePlay = asset.FindActionMap("GamePlay", throwIfNotFound: true);
        m_GamePlay_StickLeft = m_GamePlay.FindAction("StickLeft", throwIfNotFound: true);
        m_GamePlay_StickRight = m_GamePlay.FindAction("StickRight", throwIfNotFound: true);
        m_GamePlay_KeyMoveForward = m_GamePlay.FindAction("KeyMoveForward", throwIfNotFound: true);
        m_GamePlay_RestartLevel = m_GamePlay.FindAction("RestartLevel", throwIfNotFound: true);
        m_GamePlay_KeyMoveBackward = m_GamePlay.FindAction("KeyMoveBackward", throwIfNotFound: true);
        m_GamePlay_KeyTurnLeft = m_GamePlay.FindAction("KeyTurnLeft", throwIfNotFound: true);
        m_GamePlay_KeyTurnRight = m_GamePlay.FindAction("KeyTurnRight", throwIfNotFound: true);
        m_GamePlay_LeftHandbrake = m_GamePlay.FindAction("LeftHandbrake", throwIfNotFound: true);
        m_GamePlay_RightHandbrake = m_GamePlay.FindAction("RightHandbrake", throwIfNotFound: true);
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

    // GamePlay
    private readonly InputActionMap m_GamePlay;
    private IGamePlayActions m_GamePlayActionsCallbackInterface;
    private readonly InputAction m_GamePlay_StickLeft;
    private readonly InputAction m_GamePlay_StickRight;
    private readonly InputAction m_GamePlay_KeyMoveForward;
    private readonly InputAction m_GamePlay_RestartLevel;
    private readonly InputAction m_GamePlay_KeyMoveBackward;
    private readonly InputAction m_GamePlay_KeyTurnLeft;
    private readonly InputAction m_GamePlay_KeyTurnRight;
    private readonly InputAction m_GamePlay_LeftHandbrake;
    private readonly InputAction m_GamePlay_RightHandbrake;
    public struct GamePlayActions
    {
        private @PlayerControls m_Wrapper;
        public GamePlayActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @StickLeft => m_Wrapper.m_GamePlay_StickLeft;
        public InputAction @StickRight => m_Wrapper.m_GamePlay_StickRight;
        public InputAction @KeyMoveForward => m_Wrapper.m_GamePlay_KeyMoveForward;
        public InputAction @RestartLevel => m_Wrapper.m_GamePlay_RestartLevel;
        public InputAction @KeyMoveBackward => m_Wrapper.m_GamePlay_KeyMoveBackward;
        public InputAction @KeyTurnLeft => m_Wrapper.m_GamePlay_KeyTurnLeft;
        public InputAction @KeyTurnRight => m_Wrapper.m_GamePlay_KeyTurnRight;
        public InputAction @LeftHandbrake => m_Wrapper.m_GamePlay_LeftHandbrake;
        public InputAction @RightHandbrake => m_Wrapper.m_GamePlay_RightHandbrake;
        public InputActionMap Get() { return m_Wrapper.m_GamePlay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GamePlayActions set) { return set.Get(); }
        public void SetCallbacks(IGamePlayActions instance)
        {
            if (m_Wrapper.m_GamePlayActionsCallbackInterface != null)
            {
                @StickLeft.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnStickLeft;
                @StickLeft.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnStickLeft;
                @StickLeft.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnStickLeft;
                @StickRight.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnStickRight;
                @StickRight.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnStickRight;
                @StickRight.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnStickRight;
                @KeyMoveForward.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnKeyMoveForward;
                @KeyMoveForward.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnKeyMoveForward;
                @KeyMoveForward.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnKeyMoveForward;
                @RestartLevel.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnRestartLevel;
                @RestartLevel.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnRestartLevel;
                @RestartLevel.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnRestartLevel;
                @KeyMoveBackward.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnKeyMoveBackward;
                @KeyMoveBackward.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnKeyMoveBackward;
                @KeyMoveBackward.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnKeyMoveBackward;
                @KeyTurnLeft.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnKeyTurnLeft;
                @KeyTurnLeft.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnKeyTurnLeft;
                @KeyTurnLeft.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnKeyTurnLeft;
                @KeyTurnRight.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnKeyTurnRight;
                @KeyTurnRight.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnKeyTurnRight;
                @KeyTurnRight.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnKeyTurnRight;
                @LeftHandbrake.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnLeftHandbrake;
                @LeftHandbrake.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnLeftHandbrake;
                @LeftHandbrake.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnLeftHandbrake;
                @RightHandbrake.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnRightHandbrake;
                @RightHandbrake.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnRightHandbrake;
                @RightHandbrake.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnRightHandbrake;
            }
            m_Wrapper.m_GamePlayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @StickLeft.started += instance.OnStickLeft;
                @StickLeft.performed += instance.OnStickLeft;
                @StickLeft.canceled += instance.OnStickLeft;
                @StickRight.started += instance.OnStickRight;
                @StickRight.performed += instance.OnStickRight;
                @StickRight.canceled += instance.OnStickRight;
                @KeyMoveForward.started += instance.OnKeyMoveForward;
                @KeyMoveForward.performed += instance.OnKeyMoveForward;
                @KeyMoveForward.canceled += instance.OnKeyMoveForward;
                @RestartLevel.started += instance.OnRestartLevel;
                @RestartLevel.performed += instance.OnRestartLevel;
                @RestartLevel.canceled += instance.OnRestartLevel;
                @KeyMoveBackward.started += instance.OnKeyMoveBackward;
                @KeyMoveBackward.performed += instance.OnKeyMoveBackward;
                @KeyMoveBackward.canceled += instance.OnKeyMoveBackward;
                @KeyTurnLeft.started += instance.OnKeyTurnLeft;
                @KeyTurnLeft.performed += instance.OnKeyTurnLeft;
                @KeyTurnLeft.canceled += instance.OnKeyTurnLeft;
                @KeyTurnRight.started += instance.OnKeyTurnRight;
                @KeyTurnRight.performed += instance.OnKeyTurnRight;
                @KeyTurnRight.canceled += instance.OnKeyTurnRight;
                @LeftHandbrake.started += instance.OnLeftHandbrake;
                @LeftHandbrake.performed += instance.OnLeftHandbrake;
                @LeftHandbrake.canceled += instance.OnLeftHandbrake;
                @RightHandbrake.started += instance.OnRightHandbrake;
                @RightHandbrake.performed += instance.OnRightHandbrake;
                @RightHandbrake.canceled += instance.OnRightHandbrake;
            }
        }
    }
    public GamePlayActions @GamePlay => new GamePlayActions(this);
    public interface IGamePlayActions
    {
        void OnStickLeft(InputAction.CallbackContext context);
        void OnStickRight(InputAction.CallbackContext context);
        void OnKeyMoveForward(InputAction.CallbackContext context);
        void OnRestartLevel(InputAction.CallbackContext context);
        void OnKeyMoveBackward(InputAction.CallbackContext context);
        void OnKeyTurnLeft(InputAction.CallbackContext context);
        void OnKeyTurnRight(InputAction.CallbackContext context);
        void OnLeftHandbrake(InputAction.CallbackContext context);
        void OnRightHandbrake(InputAction.CallbackContext context);
    }
}
