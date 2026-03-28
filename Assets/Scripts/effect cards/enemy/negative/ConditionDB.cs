using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConditionDB
{
    public static Dictionary<ConditionID, NegativeEnemyStatus> Conditions { get; set; } = new Dictionary<ConditionID, NegativeEnemyStatus>()
    {
        {
            ConditionID.poison,
            new NegativeEnemyStatus()
            {
                Name = "poison",
            }
        }
    };
}

public enum ConditionID
{
   none, poison, burn, stun, freeze, debuf

}

/* put intro where card attacks enenmy 
if (effects.Status != ConditionID.none 
{


}
*/  