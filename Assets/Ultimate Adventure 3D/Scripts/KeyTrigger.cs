using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class KeyTrigger : MonoBehaviour
{
    [SerializeField] private GameObject massageBox;
    [SerializeField] private int ammountKeyActive;

    [SerializeField] private UnityEvent Enter;

    private bool IsActive = false;

    protected void OnTriggerEnter(Collider other)
    {
        if (IsActive == true) return;

        Bag bag = other.GetComponent<Bag>();

        if (bag != null)
        {
            if (bag.DrawKey(ammountKeyActive) == true)
            {
                Enter.Invoke();
                IsActive = true;
            }
            else
            {
                massageBox.SetActive(true);
            }
        }
    }

    public void OnTriggerExit(Collider other)
    {
        massageBox.SetActive(false);
    }
}
