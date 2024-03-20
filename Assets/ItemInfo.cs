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
        // ��Ӵٿ�� ������ �ɼǿ� ���� �̹����� ����
        int selectedIndex = dropdown.value;
        Sprite selectedSprite = dropdown.options[selectedIndex].image;

        // �̹��� UI ��ҿ� ���õ� �̹����� ����
        image.sprite = selectedSprite;
    }

    public void InputImageButton()
    {
        // ��ư�� ���� ������ �̹��� ����
        ChangeImage();
    }

    public void InputNPButton()
    {
        NPText.text = "ȯ�ݾ� : " + NPInput.text + "NP";
    }

    public void InputRarityButton()
    {
        RarityText.text = "��͵� : " + RarityInput.text;
    }

    public void InputexplainButton()
    {
        explainText.text = explainInput.text;
    }
}