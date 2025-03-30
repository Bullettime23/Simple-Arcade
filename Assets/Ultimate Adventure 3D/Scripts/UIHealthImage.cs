using UnityEngine;
using UnityEngine.UI;
public class UIHealthImage : MonoBehaviour
{
    [SerializeField] Destructable destructable;
    [SerializeField] Image image;

    private void Start()
    {
        destructable.ChangeHitpoints.AddListener(OnChangeHitpoints);
    }

    private void OnDestroy()
    {
        destructable.ChangeHitpoints.RemoveListener(OnChangeHitpoints);
    }
    private void OnChangeHitpoints()
    {
        image.fillAmount = (float) destructable.GetHitpoints() / (float) destructable.GetMaxHitpoints();
    }
}
