using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinManager : MonoBehaviour
{

    public int NumberOfCoins;
    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] PlayerLevelUp _playerLevelUp;

    private void Start()
    {       
        _text.text = NumberOfCoins.ToString();
    }

    public void AddMoney(int Add)
    {
        NumberOfCoins += Add;
        _text.text = NumberOfCoins.ToString();
        _playerLevelUp.UpdateSkins();
        if(NumberOfCoins< 0)
        {
            FindObjectOfType<PlayerBehaviour>().StartFinishBehaviour();
            FindObjectOfType<GameManager>().ShowLoseWindow();
            SaveToProgress();
        }
    }

    public void SaveToProgress() 
    {
        Progress.Instance.Coins = NumberOfCoins;
    }
}
