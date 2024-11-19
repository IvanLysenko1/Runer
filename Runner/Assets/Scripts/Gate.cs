using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : MonoBehaviour
{

    [SerializeField] int _value;
    [SerializeField] GateAppearaence _gateAppearaence;
    [SerializeField] GameObject _effectPrefab;
    [SerializeField] float _timeToDieEffect;

    private void OnValidate()
    {
        _gateAppearaence.UpdateVisual(_value);
    }

    private void OnTriggerEnter(Collider other)
    {
            other.GetComponent<CoinManager>().AddMoney(_value);
            GameObject effect  = Instantiate(_effectPrefab, transform.position, transform.rotation);
            Destroy(effect,_timeToDieEffect);
            Destroy(gameObject);      
    }

}
