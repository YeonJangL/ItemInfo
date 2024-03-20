using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemInfo : MonoBehaviour
{
    public InputField nameInput;
    public Text nameText;

    public Dropdown dropdown;
    public Image image;

    public InputField NPInput;
    public Text NPText;

    public InputField RarityInput;
    public Text RarityText;

    public InputField explainInput;
    public Text explainText;

    public void InputNameButton()
    {
        nameText.text = nameInput.text;
    }

    public void ChangeImage()
    {
        // 드롭다운에서 선택한 옵션에 따라 이미지를 변경
        int selectedIndex = dropdown.value;
        Sprite selectedSprite = dropdown.options[selectedIndex].image;

        // 이미지 UI 요소에 선택된 이미지를 설정
        image.sprite = selectedSprite;
    }

    public void InputImageButton()
    {
        // 버튼을 누를 때마다 이미지 변경
        ChangeImage();
    }

    public void InputNPButton()
    {
        NPText.text = "환금액 : " + NPInput.text + "NP";
    }

    public void InputRarityButton()
    {
        RarityText.text = "희귀도 : " + RarityInput.text;
    }

    public void InputexplainButton()
    {
        explainText.text = explainInput.text;
    }
}