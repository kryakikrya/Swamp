using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class WeaponPanel : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] private Image _image;
    [SerializeField] private Button _button;

    private ShopController _shop;
    private Weapon _weapon;

    public void Init(string text, Sprite sprite, Weapon weapon, ShopController controller)
    {
        _text.text = text;
        _image.sprite = sprite;
        _weapon = weapon;
        _shop = controller;
    }

    private void OnEnable()
    {
        _button.onClick.AddListener(OnButtonClick);
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(OnButtonClick);
    }

    private void OnButtonClick()
    {
        _shop.UnlockItem(_weapon);
        _button.onClick.RemoveListener(OnButtonClick);
        Destroy(_button.gameObject);
    }
}
