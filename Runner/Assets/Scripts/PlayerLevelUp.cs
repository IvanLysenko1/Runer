using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using static PlayerLevelUp;

public class PlayerLevelUp : MonoBehaviour
{
    [System.Serializable]
    public class Skin
    {
        public GameObject skinObject; // Объект-скин
        public int requiredCoins;     // Цена за скин (количество монет)
    }

    //public List<Skin> skins = new List<Skin>(); // Список скинов
    [SerializeField] Skin[] skins;
    [SerializeField] CoinManager _coinManager;
    private Skin currentSkin; // Текущий активный скин
    private void Awake()
    {
        _coinManager = GetComponent<CoinManager>();
    }
    private void Start()
    {
        UpdateSkins();
    }

    /// <summary>
    /// Обновляет активный скин на основе количества монет.
    /// </summary>
    public void UpdateSkins()
    {
        for (int i = 0; i < skins.Length; i++)
        {
            if (_coinManager.NumberOfCoins >= skins[i].requiredCoins)
            {
                //if(skins[i].skinObject == false)
                //{
                    skins[i].skinObject.SetActive(true);
                //}           

                // Деактивируем все остальные
                for (int j = 0; j < skins.Length; j++)
                {
                    if (j != i)
                        skins[j].skinObject.SetActive(false);
                }
            }
        }
    }
}
