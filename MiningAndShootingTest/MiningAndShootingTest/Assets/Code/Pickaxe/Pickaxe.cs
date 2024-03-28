using DG.Tweening;
using UnityEngine;

namespace MiningAndShooting
{
    public class Pickaxe : MonoBehaviour
    {
        public Sequence WorkAnimation()
        {
            Sequence sequence = DOTween.Sequence();
            sequence
                .Append(transform.DORotate(new Vector3(0f, 0f, -35f), 0f))
                .Append(transform.DORotate(new Vector3(0f, 0f, 55f), 0.25f))
                .Append(transform.DORotate(new Vector3(0f, 0f, 25f), 0.15f));
            return sequence;
        }
    }
}