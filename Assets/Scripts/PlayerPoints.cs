using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerPoints : MonoBehaviour
{

    private AudioSource _audio;
    [SerializeField]
    private TextMeshProUGUI _scoreText;
    private void Awake()
    {
        _audio = GetComponent<AudioSource>();
        _scoreText.text = Score.totalScore.ToString();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Elmas"))
        {
            _audio.Play();
            Destroy(collision.gameObject);
            Score.totalScore++;
            _scoreText.text = Score.totalScore.ToString();
        }
    }
}
