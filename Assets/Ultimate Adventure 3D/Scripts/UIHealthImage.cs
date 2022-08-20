using UnityEngine;
using UnityEngine.UI;

public class UIHealthImage : MonoBehaviour
{
    [SerializeField] private Destructible destructible;
    [SerializeField] private Image image;

    public void Start()
    {
        destructible.ChangeHitPoints.AddListener(OnChangeHitpoints);
    }

    public void OnDestroy()
    {
        destructible.ChangeHitPoints.RemoveListener(OnChangeHitpoints);
    }

    private void OnChangeHitpoints()
    {
        image.fillAmount = (float) destructible.GetHitPoints() / (float) destructible.GetMaxHitPoints();
    }
}