using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManyUI : MonoBehaviour
{
    [SerializeField] private Text _maneyUI;
    [SerializeField] private Many _many;

    private void Start()
    {
        TextUpdate();
    }
    private void OnEnable()
    {
        Many.ManyChange += TextUpdate;
    }
    private void OnDisable()
    {
        Many.ManyChange -= TextUpdate;
    }
    public void TextUpdate()
    {
       _maneyUI.text = _many.Money.ToString();
    }
}
