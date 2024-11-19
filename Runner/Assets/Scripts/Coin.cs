using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{

    [SerializeField] private float _rotationSpeed;
    [SerializeField] private GameObject _effectPrefab;
    [SerializeField] private int _addMoney = 0;
    [SerializeField] float _timeToDieEffect;

    void Update()
    {
        transform.Rotate(0, _rotationSpeed * Time.deltaTime, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        other.GetComponent<CoinManager>().AddMoney(_addMoney);       
        Instantiate(_effectPrefab, transform.position, transform.rotation);
        Destroy(gameObject,_timeToDieEffect);
        Destroy(gameObject);
    }
}
