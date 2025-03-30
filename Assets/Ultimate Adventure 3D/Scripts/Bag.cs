using UnityEngine;
using UnityEngine.Events;

public class Bag : MonoBehaviour
{
    private int amount = 0;
    public UnityEvent ChangeKeysAmount;

    public void AddKey(int amountToAdd)
    {
        amount += amountToAdd;
        ChangeKeysAmount.Invoke();
    }

    public int GetKeysAmount()
    {
        return amount;
    }

    public bool DrawKey(int amountToDraw) {
        if (amount - amountToDraw < 0) return false;

        amount -= amountToDraw;
        ChangeKeysAmount.Invoke();

        return true;
    }
}
