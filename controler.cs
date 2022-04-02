using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class controler : MonoBehaviour
{
    static int money = 100;
    static int bullet = 30;
    public GameObject image;
    [SerializeField]TextMeshProUGUI moneyText;
    [SerializeField]TextMeshProUGUI bulletText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown()
    {
        bullet = bullet - 1;
        bulletText.text  = bullet + "";
        money = money + 50;
        moneyText.text = money + "$";
        Destroy(gameObject);
        Destroy(image);
    }
}
