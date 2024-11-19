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
        public GameObject skinObject; // ������-����
        public int requiredCoins;     // ���� �� ���� (���������� �����)
    }

    //public List<Skin> skins = new List<Skin>(); // ������ ������
    [SerializeField] Skin[] skins;
    [SerializeField] CoinManager _coinManager;
    private Skin currentSkin; // ������� �������� ����
    private void Awake()
    {
        _coinManager = GetComponent<CoinManager>();
    }
    private void Start()
    {
        UpdateSkins();
    }

    /// <summary>
    /// ��������� �������� ���� �� ������ ���������� �����.
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

                // ������������ ��� ���������
                for (int j = 0; j < skins.Length; j++)
                {
                    if (j != i)
                        skins[j].skinObject.SetActive(false);
                }
            }
        }
    }
}
