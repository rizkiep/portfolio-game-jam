using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI happyText;
    public TextMeshProUGUI survivalText;
    public TextMeshProUGUI wealthText;
    public TextMeshProUGUI questionText;
    public Button yesButton,noButton;

    public GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager.GetComponent<GameManager>();
        happyText.text = "Happy : "+gameManager.happy;
        survivalText.text = "Survival : " + gameManager.survival;
        wealthText.text = "Wealth : " + gameManager.wealth;
    }

    public void DisplayQuestion(string question)
    {
        questionText.text = question;  // Menampilkan pertanyaan di UI

        // Menambahkan event ke tombol Yes
        //yesButton.onClick.RemoveAllListeners();
        //yesButton.onClick.AddListener(() => HandleAnswer(question.yes));

        // Menambahkan event ke tombol No
        //noButton.onClick.RemoveAllListeners();
        //noButton.onClick.AddListener(() => HandleAnswer(question.no));
    }
}
