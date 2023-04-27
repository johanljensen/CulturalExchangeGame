using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NarrativeEvents : MonoBehaviour
{
    [SerializeField]
    NarrativeStates States;

    [SerializeField]
    InventoryItem powerBankPrefab;
    [SerializeField]
    InventoryItem mapPrefab;
    [SerializeField]
    InventoryItem mapUpgradePrefab;

    private void Start()
    {
        States = FindObjectOfType<NarrativeStates>();
    }

    public void SetStateHurtLegHelped()
    {
        States.HelpedHurtLeg();
    }

    public void SetStateCryingGirlHelped()
    {
        States.HelpedCryingGirl();
    }
}
