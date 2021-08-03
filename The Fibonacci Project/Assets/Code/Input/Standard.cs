// GENERATED AUTOMATICALLY FROM 'Assets/Code/Input/Standard.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Standard : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Standard()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Standard"",
    ""maps"": [
        {
            ""name"": ""Interact"",
            ""id"": ""cd1f7424-9113-4d87-a425-6ac2db71a607"",
            ""actions"": [
                {
                    ""name"": ""Select"",
                    ""type"": ""Button"",
                    ""id"": ""1698974c-e9db-4655-80f9-e3437d0d1e07"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""1c4ff02b-8378-46f4-9d31-56aa749d840d"",
                    ""path"": ""<Mouse>/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Input"",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1d9eb6b1-713a-491c-8db1-04fc478d9417"",
                    ""path"": ""<Touchscreen>/primaryTouch/tap"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Input"",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Input"",
            ""bindingGroup"": ""Input"",
            ""devices"": []
        }
    ]
}");
        // Interact
        m_Interact = asset.FindActionMap("Interact", throwIfNotFound: true);
        m_Interact_Select = m_Interact.FindAction("Select", throwIfNotFound: true);
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

    // Interact
    private readonly InputActionMap m_Interact;
    private IInteractActions m_InteractActionsCallbackInterface;
    private readonly InputAction m_Interact_Select;
    public struct InteractActions
    {
        private @Standard m_Wrapper;
        public InteractActions(@Standard wrapper) { m_Wrapper = wrapper; }
        public InputAction @Select => m_Wrapper.m_Interact_Select;
        public InputActionMap Get() { return m_Wrapper.m_Interact; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(InteractActions set) { return set.Get(); }
        public void SetCallbacks(IInteractActions instance)
        {
            if (m_Wrapper.m_InteractActionsCallbackInterface != null)
            {
                @Select.started -= m_Wrapper.m_InteractActionsCallbackInterface.OnSelect;
                @Select.performed -= m_Wrapper.m_InteractActionsCallbackInterface.OnSelect;
                @Select.canceled -= m_Wrapper.m_InteractActionsCallbackInterface.OnSelect;
            }
            m_Wrapper.m_InteractActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Select.started += instance.OnSelect;
                @Select.performed += instance.OnSelect;
                @Select.canceled += instance.OnSelect;
            }
        }
    }
    public InteractActions @Interact => new InteractActions(this);
    private int m_InputSchemeIndex = -1;
    public InputControlScheme InputScheme
    {
        get
        {
            if (m_InputSchemeIndex == -1) m_InputSchemeIndex = asset.FindControlSchemeIndex("Input");
            return asset.controlSchemes[m_InputSchemeIndex];
        }
    }
    public interface IInteractActions
    {
        void OnSelect(InputAction.CallbackContext context);
    }
}
