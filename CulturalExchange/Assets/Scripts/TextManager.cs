using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class TextManager : MonoBehaviour
{
     public GameObject narrativeTextBox;
    public TextMeshProUGUI narrativeText;
    public Button narrativeTextButton;

    public GameObject decisionTextBox;
    public TextMeshProUGUI decisionTextPrompt;
    public List<TextMeshProUGUI> decisionTexts;
    public List<Button> decisionButtons;

    [FormerlySerializedAs("currentNode")] private NarrativeBase currentNarration;
    public NarrativeBase GetCurrentNarration() { return currentNarration; }

    private void SetNarrationOrDecision(bool isMultiChoice)
    {
        narrativeTextBox.SetActive(!isMultiChoice);
        decisionTextBox.SetActive(isMultiChoice);

        foreach(TextMeshProUGUI text in decisionTexts)
        {
            text.gameObject.SetActive(false);
        }
    }

    public void SetNarration(NarrativeBase narration)
    {
        currentNarration = narration;

        SetNarrationOrDecision(false);

        narrativeText.text = narration.GetText();
        narrativeTextButton.onClick.RemoveAllListeners();
        narrativeTextButton.onClick.AddListener(() => narration.GetNextNarrative().AdvanceNarrative(this));
    }

    public void SetDecision(NarrativeTextDecisions decisions)
    {
        currentNarration = decisions;

        SetNarrationOrDecision(true);

        decisionTextPrompt.text = decisions.GetText();

        List<NarrativeDecision> choices = decisions.GetDecisions();
        for (int x = 0; x < choices.Count; x++)
        {
            int CurrentIndex = x;
            decisionTexts[x].gameObject.SetActive(true);
            decisionTexts[x].text = choices[x].DecisionText();
            decisionButtons[x].onClick.RemoveAllListeners();
            decisionButtons[x].onClick.AddListener(() => decisions.GetDecisionNarrative(CurrentIndex).AdvanceNarrative(this));
        }
    }

    public void SetDecisionTranslate(NarrativeTextDecisionsTranslate decisionsTranslate)
    {
        currentNarration = decisionsTranslate;

        SetNarrationOrDecision(true);

        decisionTextPrompt.text = decisionsTranslate.GetText();

        List<NarrativeDecisionTranslate> choices = decisionsTranslate.GetDecisions();
        for (int x = 0; x < choices.Count; x++)
        {
            int CurrentIndex = x;
            decisionTexts[x].gameObject.SetActive(true);
            decisionTexts[x].text = choices[x].GetText();
            decisionButtons[x].onClick.RemoveAllListeners();
            decisionButtons[x].onClick.AddListener(() => decisionsTranslate.GetDecisionNext(CurrentIndex).AdvanceNarrative(this));
        }
    }
}
