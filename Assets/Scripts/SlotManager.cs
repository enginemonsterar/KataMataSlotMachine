using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using MonsterAR.Utility;

public class SlotManager : Singleton<SlotManager>
{
    // Start is called before the first frame update
    [SerializeField] private Slot[] slots;
    [SerializeField] private Sprite[] prizeSprites;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < slots.Length; i++)
        {
            slots[i].transform.GetChild(0).GetChild(0).GetChild(i).GetChild(0).GetComponent<Image>().sprite = prizeSprites[i];            
        }
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
