using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionManager : MonoBehaviour
{
    public List<QuestionData> questions = new List<QuestionData>();
    public GameManager gameManager;
    public TextAsset questionFile;
    public UIManager ui;

    void Awake()
    {
        LoadQuestions();
        DisplayRandomQuestion();
    }

    // Fungsi untuk memuat pertanyaan dari file JSON
    void LoadQuestions()
    {
        if (questionFile != null)
        {
            string jsonData = questionFile.text;
            QuestionListWrapper qwrapper = JsonUtility.FromJson<QuestionListWrapper>(jsonData);
            questions = qwrapper.questions;

        }
        else
        {
            Debug.LogError("File JSON tidak ditemukan!");
        }
    }

    void DisplayRandomQuestion()
    {
        if (questions.Count > 0)
        {
            int randomIndex = Random.Range(0, questions.Count);
            QuestionData selectedQuestion = questions[randomIndex];
            ui.DisplayQuestion(selectedQuestion.question);

            Debug.Log("Pertanyaan: " + selectedQuestion.question);

        }
        else
        {
            Debug.LogError("Daftar pertanyaan kosong.");
        }
    }

    // Wrapper untuk memuat file JSON yang berisi daftar pertanyaan
    [System.Serializable]
    public class QuestionListWrapper
    {
        public List<QuestionData> questions;
    }

    [System.Serializable]
    public class QuestionData
    {
        public string question;
        public Answer yes;
        public Answer no;

    }
    [System.Serializable]
    public class Answer
    {
        public int survival;
        public int happy;
        public int wealth;
    }


}
