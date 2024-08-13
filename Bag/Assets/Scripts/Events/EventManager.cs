using System;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    #region Fields
    public static EventManager Instance;
    public static Action OnPlayerAttack;
    public static Action<bool> OnPlayerMove;
    #endregion

    #region Initializing

    private void Awake()
    {
        Instance = this;
    }

    #endregion

    #region Invokable Methods

    public void PlayerAttack()
    {
        OnPlayerAttack?.Invoke();
    }

    public void PlayerMoveInvoke(bool state)
    {
        OnPlayerMove?.Invoke(state);
    }

    #endregion
}
