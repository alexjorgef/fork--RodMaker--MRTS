using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;
using UnityEngine.Events;

public class InfantryUnit : NetworkBehaviour
{
    [SerializeField] private UnityEvent onSelected = null;
    [SerializeField] private UnityEvent onDeselected = null;

    [Header("Scripts")]
    [SerializeField] private InfantryUnitMovement unitMovement = null;

    public InfantryUnitMovement GetUnitMovement()
    {
        return unitMovement;
    }

    #region Server

    #endregion

    #region Client

    [Client]
    public void Select()
    {
        //if (!hasAuthority) { return; }

        onSelected?.Invoke();
    }

    [Client]
    public void Deselect()
    {
        //if (!hasAuthority) { return; }

        onDeselected?.Invoke();
    }

    #endregion
}
