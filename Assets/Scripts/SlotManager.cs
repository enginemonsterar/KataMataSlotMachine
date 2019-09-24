using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MonsterAR.Utility;

public class SlotManager : Singleton<SlotManager>
{
    // Start is called before the first frame update
    [SerializeField] private Slot[] slots;

    // Start is called before the first frame update
    void Start()
    {
                
    }

    IEnumerator RollingSlots(){
        for (int i = 0; i < slots.Length; i++)
        {
            slots[i].StartRolling();            
            yield return new WaitForSeconds(0.3f);   
        }
    }

    public void GoRolling(){
        StartCoroutine(RollingSlots());
    }
}
