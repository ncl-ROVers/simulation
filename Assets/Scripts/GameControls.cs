// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/GameControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @GameControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @GameControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""GameControls"",
    ""maps"": [
        {
            ""name"": ""CameraMovement"",
            ""id"": ""139446eb-3bca-4774-a261-0723c6055bf5"",
            ""actions"": [
                {
                    ""name"": ""RightLeft"",
                    ""type"": ""PassThrough"",
                    ""id"": ""8d85479f-2a1a-4161-98c7-a261edf0b58b"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""FrontBack"",
                    ""type"": ""PassThrough"",
                    ""id"": ""452b5a82-8cfb-4b63-b294-d0e7b63ba669"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""UpDown"",
                    ""type"": ""PassThrough"",
                    ""id"": ""f3259875-5c31-4906-bfbf-0149c381e160"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LookPitch"",
                    ""type"": ""PassThrough"",
                    ""id"": ""048510b8-7796-4857-a823-7258dae2c85f"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LookYaw"",
                    ""type"": ""PassThrough"",
                    ""id"": ""b266e96e-c5c3-417e-9f6b-b398f724b79b"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Toggle"",
                    ""type"": ""Button"",
                    ""id"": ""74291ee1-a3fa-4cd1-be16-b8f85277f4d6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""FastFly"",
                    ""type"": ""PassThrough"",
                    ""id"": ""67aaf2a8-fc09-4188-9e99-f3e5d8fb3cf0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""a6cf3b89-5272-4092-9bf3-733369f5cf5a"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightLeft"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""4a525d75-01b7-491c-a279-437f3026c358"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""a5f1e3ce-eb97-484e-8fae-9bff4a02f88a"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""ff5069cf-39bf-473c-a720-14a5334fe664"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FrontBack"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""2d718c9e-d6e2-44b0-b964-66a53101f38c"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FrontBack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""421d3c2b-ccff-4d12-afd8-a1a17107cef6"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FrontBack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""4e065976-c42c-4661-9412-e2bfe4142aa9"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UpDown"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""cbf27f8f-d7e1-44cb-ac60-91f12896271e"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UpDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""c17c5923-3724-4839-91c8-b5211f709df5"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UpDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""8475afe7-dd22-4aa5-9a8b-74a637245b9e"",
                    ""path"": ""<Mouse>/delta/y"",
                    ""interactions"": """",
                    ""processors"": ""Scale(factor=0.25)"",
                    ""groups"": """",
                    ""action"": ""LookPitch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fbf2fe12-4241-4137-96ad-e6dd8bba1c93"",
                    ""path"": ""<Mouse>/delta/x"",
                    ""interactions"": """",
                    ""processors"": ""Scale(factor=0.25)"",
                    ""groups"": """",
                    ""action"": ""LookYaw"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""70df7b5b-1331-4ecd-af40-6e2cf3b6bbbb"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Toggle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7f053fd9-b086-4b26-9e8a-8577a99082ff"",
                    ""path"": ""<Keyboard>/ctrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FastFly"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // CameraMovement
        m_CameraMovement = asset.FindActionMap("CameraMovement", throwIfNotFound: true);
        m_CameraMovement_RightLeft = m_CameraMovement.FindAction("RightLeft", throwIfNotFound: true);
        m_CameraMovement_FrontBack = m_CameraMovement.FindAction("FrontBack", throwIfNotFound: true);
        m_CameraMovement_UpDown = m_CameraMovement.FindAction("UpDown", throwIfNotFound: true);
        m_CameraMovement_LookPitch = m_CameraMovement.FindAction("LookPitch", throwIfNotFound: true);
        m_CameraMovement_LookYaw = m_CameraMovement.FindAction("LookYaw", throwIfNotFound: true);
        m_CameraMovement_Toggle = m_CameraMovement.FindAction("Toggle", throwIfNotFound: true);
        m_CameraMovement_FastFly = m_CameraMovement.FindAction("FastFly", throwIfNotFound: true);
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

    // CameraMovement
    private readonly InputActionMap m_CameraMovement;
    private ICameraMovementActions m_CameraMovementActionsCallbackInterface;
    private readonly InputAction m_CameraMovement_RightLeft;
    private readonly InputAction m_CameraMovement_FrontBack;
    private readonly InputAction m_CameraMovement_UpDown;
    private readonly InputAction m_CameraMovement_LookPitch;
    private readonly InputAction m_CameraMovement_LookYaw;
    private readonly InputAction m_CameraMovement_Toggle;
    private readonly InputAction m_CameraMovement_FastFly;
    public struct CameraMovementActions
    {
        private @GameControls m_Wrapper;
        public CameraMovementActions(@GameControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @RightLeft => m_Wrapper.m_CameraMovement_RightLeft;
        public InputAction @FrontBack => m_Wrapper.m_CameraMovement_FrontBack;
        public InputAction @UpDown => m_Wrapper.m_CameraMovement_UpDown;
        public InputAction @LookPitch => m_Wrapper.m_CameraMovement_LookPitch;
        public InputAction @LookYaw => m_Wrapper.m_CameraMovement_LookYaw;
        public InputAction @Toggle => m_Wrapper.m_CameraMovement_Toggle;
        public InputAction @FastFly => m_Wrapper.m_CameraMovement_FastFly;
        public InputActionMap Get() { return m_Wrapper.m_CameraMovement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CameraMovementActions set) { return set.Get(); }
        public void SetCallbacks(ICameraMovementActions instance)
        {
            if (m_Wrapper.m_CameraMovementActionsCallbackInterface != null)
            {
                @RightLeft.started -= m_Wrapper.m_CameraMovementActionsCallbackInterface.OnRightLeft;
                @RightLeft.performed -= m_Wrapper.m_CameraMovementActionsCallbackInterface.OnRightLeft;
                @RightLeft.canceled -= m_Wrapper.m_CameraMovementActionsCallbackInterface.OnRightLeft;
                @FrontBack.started -= m_Wrapper.m_CameraMovementActionsCallbackInterface.OnFrontBack;
                @FrontBack.performed -= m_Wrapper.m_CameraMovementActionsCallbackInterface.OnFrontBack;
                @FrontBack.canceled -= m_Wrapper.m_CameraMovementActionsCallbackInterface.OnFrontBack;
                @UpDown.started -= m_Wrapper.m_CameraMovementActionsCallbackInterface.OnUpDown;
                @UpDown.performed -= m_Wrapper.m_CameraMovementActionsCallbackInterface.OnUpDown;
                @UpDown.canceled -= m_Wrapper.m_CameraMovementActionsCallbackInterface.OnUpDown;
                @LookPitch.started -= m_Wrapper.m_CameraMovementActionsCallbackInterface.OnLookPitch;
                @LookPitch.performed -= m_Wrapper.m_CameraMovementActionsCallbackInterface.OnLookPitch;
                @LookPitch.canceled -= m_Wrapper.m_CameraMovementActionsCallbackInterface.OnLookPitch;
                @LookYaw.started -= m_Wrapper.m_CameraMovementActionsCallbackInterface.OnLookYaw;
                @LookYaw.performed -= m_Wrapper.m_CameraMovementActionsCallbackInterface.OnLookYaw;
                @LookYaw.canceled -= m_Wrapper.m_CameraMovementActionsCallbackInterface.OnLookYaw;
                @Toggle.started -= m_Wrapper.m_CameraMovementActionsCallbackInterface.OnToggle;
                @Toggle.performed -= m_Wrapper.m_CameraMovementActionsCallbackInterface.OnToggle;
                @Toggle.canceled -= m_Wrapper.m_CameraMovementActionsCallbackInterface.OnToggle;
                @FastFly.started -= m_Wrapper.m_CameraMovementActionsCallbackInterface.OnFastFly;
                @FastFly.performed -= m_Wrapper.m_CameraMovementActionsCallbackInterface.OnFastFly;
                @FastFly.canceled -= m_Wrapper.m_CameraMovementActionsCallbackInterface.OnFastFly;
            }
            m_Wrapper.m_CameraMovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @RightLeft.started += instance.OnRightLeft;
                @RightLeft.performed += instance.OnRightLeft;
                @RightLeft.canceled += instance.OnRightLeft;
                @FrontBack.started += instance.OnFrontBack;
                @FrontBack.performed += instance.OnFrontBack;
                @FrontBack.canceled += instance.OnFrontBack;
                @UpDown.started += instance.OnUpDown;
                @UpDown.performed += instance.OnUpDown;
                @UpDown.canceled += instance.OnUpDown;
                @LookPitch.started += instance.OnLookPitch;
                @LookPitch.performed += instance.OnLookPitch;
                @LookPitch.canceled += instance.OnLookPitch;
                @LookYaw.started += instance.OnLookYaw;
                @LookYaw.performed += instance.OnLookYaw;
                @LookYaw.canceled += instance.OnLookYaw;
                @Toggle.started += instance.OnToggle;
                @Toggle.performed += instance.OnToggle;
                @Toggle.canceled += instance.OnToggle;
                @FastFly.started += instance.OnFastFly;
                @FastFly.performed += instance.OnFastFly;
                @FastFly.canceled += instance.OnFastFly;
            }
        }
    }
    public CameraMovementActions @CameraMovement => new CameraMovementActions(this);
    public interface ICameraMovementActions
    {
        void OnRightLeft(InputAction.CallbackContext context);
        void OnFrontBack(InputAction.CallbackContext context);
        void OnUpDown(InputAction.CallbackContext context);
        void OnLookPitch(InputAction.CallbackContext context);
        void OnLookYaw(InputAction.CallbackContext context);
        void OnToggle(InputAction.CallbackContext context);
        void OnFastFly(InputAction.CallbackContext context);
    }
}
