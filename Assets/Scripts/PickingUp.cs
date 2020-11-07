using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PickingUp : MonoBehaviour
{
    private int count;
    public TextMeshProUGUI countText;
    public GameObject winTextObject;

    void Start()
    {
        count = 0;
        SetCountText();
        winTextObject.SetActive(false);
    }
    void SetCountText()
    {
        countText.text = "Fruit Count: " + count.ToString();
        if (count >= 18)
        {

            winTextObject.SetActive(true);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Fruit"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();

        }
    }
}
