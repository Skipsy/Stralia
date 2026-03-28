using UnityEngine;


public class Enemy
{
    public NegativeEnemyStatus Status { get; private set; }

    public void SetStatus(ConditionID conditionId)
    {
        Status = ConditionDB.Conditions[conditionId];
    }
}

