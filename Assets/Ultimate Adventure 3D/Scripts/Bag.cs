using UnityEngine;
using UnityEngine.Events;

public class Bag : MonoBehaviour
{
    private int amountObject;

    public UnityEvent ChangeAmountObject;

    public void AddObject(int amount)
    {
        amountObject += amount;

        ChangeAmountObject.Invoke();
    }

    public bool DrawKey(int amount)
    {
        if (amountObject - amount < 0) return false;

        amountObject -= amount;

        ChangeAmountObject.Invoke();

        return true;
    }

    public int GetAmountKey()
    {
        return amountObject;
    }
}
