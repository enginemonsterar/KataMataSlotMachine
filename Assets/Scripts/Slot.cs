using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slot : MonoBehaviour
{

    private GameObject content;
    private bool rolling;

    private GameObject resultSlotItem;

    // Start is called before the first frame update
    void Start()
    {
        content = transform.GetChild(0).GetChild(0).gameObject;
        resultSlotItem = transform.GetChild(0).GetChild(1).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if(rolling){
            content.transform.position = new Vector3(
                content.transform.position.x,
                content.transform.position.y + 20,
                content.transform.position.z
            );
        }
    }

    public void StartRolling(){
        rolling = true;
        StartCoroutine(Rolling());
    }

    public void StopRolling(){
        rolling = false;
        resultSlotItem.SetActive(true);
        content.SetActive(false);
        
    }

    IEnumerator Rolling(){
        resultSlotItem.SetActive(false);
        content.SetActive(true);
        
        yield return new WaitForSeconds(5);        
        StopRolling();
    }

    
}
