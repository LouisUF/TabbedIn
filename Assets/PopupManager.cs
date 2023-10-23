using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PopupManager : MonoBehaviour
{
    public GameObject panel;
    public TMP_Text titleText;
    public TMP_Text bodyText;
    public TimeManager timeManager;

    public GameObject GermGame;
    public GameObject MouthGame;
    public GameObject HeartGame;
    public GameObject BrainGame;
    public GameObject LungGame;

    public GameObject HealthBar;
    public GameObject HeartTimer;
    public GameObject HeartBar;
    public GameObject BrainTimer;
    public GameObject BrainBar;
    public GameObject LungTmimer;
    public GameObject LungBar;

    public GameObject SpawnerL;
    public GameObject SpawnerR;

    public GameObject foodSpawner;

    public GameObject heartGameManager;
    public HealthManager healthManager;


    public GameObject clickManager;
    public AudioManager audio;
    public void OpenPopup()
    {
        if (healthManager.playerHealth > 0)
        {
            audio.Play("PopUp");
        }
        else
        {
            audio.Play("error");
        }
        panel.SetActive(true);
        Time.timeScale = 0;
    }
    public void ClosePopup()
    {
        panel.SetActive(false);
        Time.timeScale = 1;
        
        if(healthManager.playerHealth <= 0){
            SceneManager.LoadScene("Credits");
        }
    }

    void Start()
    {
        OpenPopup();
        titleText.text = "Congratulations!";
        bodyText.text = "Welcome to your new role as Systems Manager! We’re so excited to see the incredible work you will do with your new client! We know that managing all of a client’s body systems can be a difficult task, so we will slowly hand out control over different parts of their software. Pretty soon though, you’ll be in charge of keeping all of their systems safe and healthy! We hope both of you can live long, happy lives.\r\n\r\n See you on the other side,\r\nManagement.";

    }

    void Update()
    {

        if (timeManager.currentAge == 2)
        {
            timeManager.currentAge = 3;
            OpenPopup();
            GermGame.SetActive(true);
            HealthBar.SetActive(true);
            clickManager.GetComponent<clickManager>().tabs.Add(GermGame);
            titleText.text = "New Task";
            bodyText.text = "To start off, we’re giving you control over the client’s Immune System, which is in charge of keeping bacteria and viruses away from other systems.\r\n\r\nYour client seems to have an open wound, so keep the germs away by clicking on them before they can enter it. If any germs get through, your client’s Total Health will decrease. If that ever hits 0, all of their systems will shut down, so make sure that doesn’t happen :)\r\n";
        }

        if (timeManager.currentAge == 5)
        {
            timeManager.currentAge = 6;
            OpenPopup();
            MouthGame.SetActive(true);
            clickManager.GetComponent<clickManager>().tabs.Add(MouthGame);
            titleText.text = "New Task";
            bodyText.text = "Good work! Next up, you need to manage a client’s Mouth in their Digestive System.\r\n\r\nYou must help your client eat healthy foods like Wheat Bread, Carrots, and Apples. These will recover your client’s Total Health!\r\nKeep bad foods like Burgers, Pizza, and Bleach away from your client’s mouth! These foods will damage your client’s Total Health. Click on these foods to get rid of them before they enter the Mouth!";
        }

        if (timeManager.currentAge == 9)
        {
            timeManager.currentAge = 10;
            OpenPopup();
            BrainGame.SetActive(true);
            BrainBar.SetActive(true);
            BrainTimer.SetActive(true);
            clickManager.GetComponent<clickManager>().tabs.Add(BrainGame);
            titleText.text = "New Task";
            bodyText.text = "Your client is doing great! We think you’re ready to handle the Nervous System’s brain now.\r\n\r\nKeep your client mentally active by helping them answer math questions. Notice the new bar that appeared in the bottom right of your screen. That brain bar will slowly decrease, and if it hits 0, your Total Health will take damage. Answer math questions to increase your brain bar!\r\n";
        }

        if (timeManager.currentAge == 13)
        {
            timeManager.currentAge = 14;
            OpenPopup();
            LungGame.SetActive(true);
            LungBar.SetActive(true);
            LungTmimer.SetActive(true);
            clickManager.GetComponent<clickManager>().tabs.Add(LungGame);
            titleText.text = "New Task";
            bodyText.text = "Awesome! You’re a natural Systems Manager! Now, you’re in charge of the Respiratory System’s Lungs.\r\n\r\nThe lungs have a bar that slowly decreases, just like the brain. To pump the lungs and increase your lung bar, quickly press the up and down arrows!\r\n";
        }

        if (timeManager.currentAge == 17)
        {
            timeManager.currentAge = 18;
            OpenPopup();
            HeartGame.SetActive(true);
            HeartBar.SetActive(true);
            HeartTimer.SetActive(true);
            clickManager.GetComponent<clickManager>().tabs.Add(HeartGame);
            titleText.text = "New Task";
            bodyText.text = "The heart has a bar just like the Brain and Lungs, but to fill this one up, you have to type the words you see in the tab. \r\n\r\nThis is it! Now that you’re in control of the Circulatory System’s Heart, you are in charge of the last system your client asked you to manage. Most clients have a couple more systems, but we’ll save that for when you get a promotion! Good luck, don’t die!\r\n";
        }

        //Special Events
        if (timeManager.currentAge == 25)
        {
            timeManager.currentAge = 26;
            OpenPopup();
            SpawnerL.GetComponent<germSpawner>().flatTime = 0;
            SpawnerR.GetComponent<germSpawner>().flatTime = 0;
            titleText.text = "Event!";
            bodyText.text = "Your client got sunburned.\r\n\r\nAs a result, your skin has been damaged, and more germs will now spawn to try to infect the weakened area. Not only can sunburns cause short-term damage, they can also lead to melanoma, the deadliest form of skin cancer. To reduce sunburns, make sure to use water-resistant sunscreen.\r\n";
        }

        if (timeManager.currentAge == 32)
        {
            timeManager.currentAge = 33;
            OpenPopup();
            foodSpawner.GetComponent<foodSpawner>().flatTime = 1;
            titleText.text = "Event!";
            bodyText.text = "Your client is binge-eating.\r\n\r\nAs a result, you will have to deal with a lot more food in the Digestive System. Binge-eating disorder is an eating disorder in which people consume unusually large amounts of food, which can lead to obesity. This can often be caused by depression, anxiety, and substance abuse. Talking to a doctor can be a good way to start treating binge eating.\r\n";
        }

        if (timeManager.currentAge == 39)
        {
            timeManager.currentAge = 40;
            OpenPopup();
            BrainTimer.GetComponent<BrainTimer>().decreaseSpeed *= 1.5f;
            titleText.text = "Event!";
            bodyText.text = "Your client is suffering from major depressive disorder.\r\n\r\nAs a result, your brain bar will decrease faster. Depression can be caused by stress, trauma, and a multitude of other factors. Symptoms of depression include prolonged changes in sleep, appetite, mood, and concentration. Exercising and speaking to a therapist can help with depression.\r\n";
        }

        if (timeManager.currentAge == 45)
        {
            timeManager.currentAge = 46;
            OpenPopup();
            LungTmimer.GetComponent<LungsTimer>().decreaseSpeed *= 1.5f;
            titleText.text = "Event!";
            bodyText.text = "Your client has pneumonia.\r\n\r\nAs a result, your lung bar will decrease faster. Pneumonia is an infection that causes the swelling of the lungs, which causes the air sacs to fill with fluid. To help treat Pneumonia, drink water often, get lots of rest, and take medication.\r\n";
        }

        if (timeManager.currentAge == 51)
        {
            timeManager.currentAge = 52;
            OpenPopup();
            heartGameManager.GetComponent<heartGameManager>().hardMode = true;
            titleText.text = "Event!";
            bodyText.text = "Your client just suffered a heart attack.\r\n\r\nAs a result, your words for the circulatory system will become more difficult. Heart attacks occur when the flow of blood to the heart is reduced or blocked. This can be caused by a buildup of fat or cholesterol. Symptoms of a heart attack include chest pain, fatigue, and nausea. To reduce the risk of a heart attack, exercise often and eat healthily.\r\n";
        }

        if (healthManager.playerHealth <= 0){
            OpenPopup();
            audio.Stop("music");
            titleText.text = "Uh Oh!";
            bodyText.text = "Well, everyone has to die someday.\r\n\r\nBut hey! At least your client lived till " + timeManager.currentAge + ".";
        }
    }
}
