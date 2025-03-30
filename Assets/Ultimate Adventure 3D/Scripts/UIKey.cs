using UnityEngine;
using UnityEngine.UI;

public class UIKey : MonoBehaviour
{
    [SerializeField] Bag bag;
    [SerializeField] Text text;

    private void Start()
    {
        bag.ChangeKeysAmount.AddListener(OnChangeKeysAmount);
    }

    private void OnDestroy()
    {
        bag.ChangeKeysAmount.RemoveListener(OnChangeKeysAmount);
    }   
    private void OnChangeKeysAmount()
    {
        text.text = bag.GetKeysAmount().ToString();
    }
}
