using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace _Project.UI.View
{
    public class ItemView : MonoBehaviour
    {
        [SerializeField] private Image _itemImage;
        [SerializeField] private TextMeshProUGUI _price;
        [SerializeField] private GameObject _selectedFrame;
    }
}
