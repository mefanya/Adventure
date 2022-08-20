using UnityEngine;
using UnityEngine.UI;

public class UIKeyText : MonoBehaviour
{
    [SerializeField] private Bag bag;
    [SerializeField] private Text text;

    public void Start()
    {
        bag.ChangeAmountObject.AddListener(OnChangeHitpoints);
    }

    public void OnDestroy()
    {
        bag.ChangeAmountObject.RemoveListener(OnChangeHitpoints);
    }

    private void OnChangeHitpoints()
    {
        text.text = bag.GetAmountKey().ToString();
    }
}
