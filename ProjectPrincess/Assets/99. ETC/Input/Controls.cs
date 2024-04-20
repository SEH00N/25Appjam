//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/99. ETC/Input/Controls.inputactions
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

public partial class @Controls: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""Ingame"",
            ""id"": ""c30957fc-65a6-4ab8-b3bd-2b22b59aab0f"",
            ""actions"": [
                {
                    ""name"": ""Stack"",
                    ""type"": ""Button"",
                    ""id"": ""90162fab-5df2-48eb-8369-f0f7946b0e12"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""0b706087-28ea-4111-8d2f-fcce2e52ab56"",
                    ""path"": ""<Touchscreen>/Press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Stack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Android"",
            ""bindingGroup"": ""Android"",
            ""devices"": [
                {
                    ""devicePath"": ""<Touchscreen>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Ingame
        m_Ingame = asset.FindActionMap("Ingame", throwIfNotFound: true);
        m_Ingame_Stack = m_Ingame.FindAction("Stack", throwIfNotFound: true);
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

    // Ingame
    private readonly InputActionMap m_Ingame;
    private List<IIngameActions> m_IngameActionsCallbackInterfaces = new List<IIngameActions>();
    private readonly InputAction m_Ingame_Stack;
    public struct IngameActions
    {
        private @Controls m_Wrapper;
        public IngameActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Stack => m_Wrapper.m_Ingame_Stack;
        public InputActionMap Get() { return m_Wrapper.m_Ingame; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(IngameActions set) { return set.Get(); }
        public void AddCallbacks(IIngameActions instance)
        {
            if (instance == null || m_Wrapper.m_IngameActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_IngameActionsCallbackInterfaces.Add(instance);
            @Stack.started += instance.OnStack;
            @Stack.performed += instance.OnStack;
            @Stack.canceled += instance.OnStack;
        }

        private void UnregisterCallbacks(IIngameActions instance)
        {
            @Stack.started -= instance.OnStack;
            @Stack.performed -= instance.OnStack;
            @Stack.canceled -= instance.OnStack;
        }

        public void RemoveCallbacks(IIngameActions instance)
        {
            if (m_Wrapper.m_IngameActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IIngameActions instance)
        {
            foreach (var item in m_Wrapper.m_IngameActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_IngameActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public IngameActions @Ingame => new IngameActions(this);
    private int m_AndroidSchemeIndex = -1;
    public InputControlScheme AndroidScheme
    {
        get
        {
            if (m_AndroidSchemeIndex == -1) m_AndroidSchemeIndex = asset.FindControlSchemeIndex("Android");
            return asset.controlSchemes[m_AndroidSchemeIndex];
        }
    }
    public interface IIngameActions
    {
        void OnStack(InputAction.CallbackContext context);
    }
}
