using UnityEngine;
using TMPro;  // Add this to work with TextMeshPro

public class EDLDisplayScript : MonoBehaviour
{
    public TMP_Text textComponent;  // Reference to the TMP_Text component

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Ensure the text component is set up correctly
        if (textComponent == null)
        {
            Debug.LogError("TMP_Text component is not assigned!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Get WPM from DataManager (rounded to nearest int)
        int wpm = DataManager.Instance.WPM;
        DisplayWpmMessage(wpm, textComponent);
    }
    // Display appropriate text based on WPM value
    public void DisplayWpmMessage(int wpm, TMP_Text textComponent)
    {
        if (wpm > 100)
        {
            textComponent.text = @" 
    Tu as atteint la vitesse des légendes!
    Noble esprit divin! 
    Même les vents de la forêt 
    ne peuvent te suivre";
        }
        else if (wpm >= 0 && wpm <= 4)
        {
            textComponent.text = @"
    Oups à cette vitesse même les herbes
    de la jungle te dépassent.
    Un peu plus d'élan petite limace!";
        }
        else if (wpm <= 8)
        {
            textComponent.text = @" 
    Ah un escargot!
    Ce n'est pas pour critiquer mais
    tu pourrais faire une petite sieste
    en pleine course et rester premier";
        }
        else if (wpm <= 12)
        {
            textComponent.text = @" 
    Doucement mais sûrement
    petite tortue! Tu avances 
    mais la jungle est vaste...
    et tes ennemis rapides!";
        }
        else if (wpm <= 16)
        {
            textComponent.text = @"
    Quel calme mon ami le paresseux!
    Mais si tu veux  survivre ici
    mieux vaut éviter de trop traîner!";
        }
        else if (wpm <= 20)
        {
            textComponent.text = @" 
    Petite fourmi courageuse!
    Ton rythme est modeste mais
    dans la jungle même 
    les plus petits peuvent 
    devenir grands";
        }
        else if (wpm <= 24)
        {
            textComponent.text = @"
    La chenille se déplace...
    lentement mais sûrement
    Un jour tu deviendras peut-être
    un papillon rapide!";
        }
        else if (wpm <= 28)
        {
            textComponent.text = @" 
    Croaa!
    Saute plus haut grenouille!
    La forêt attend de te voir bondir
    à la vitesse du renard";
        }
        else if (wpm <= 32)
        {
            textComponent.text = @"
    Petit hérisson tu te roules
    et tu avances mais
    attention aux prédateurs
    rapides!";
        }
        else if (wpm <= 36)
        {
            textComponent.text = @"
    Tu sautes bien petit lapin!
    Mais sais-tu courir
    plus vite pour échapper
    au renard?";
        }
        else if (wpm <= 40)
        {
            textComponent.text = @" 
    Ah le renard rusé!
    Ton intelligence t'amène loin
    mais il te faudra plus de vitesse
    pour régner";
        }
        else if (wpm <= 44)
        {
            textComponent.text = @"
    Vaillant blaireau
    tu es courageux et persévérant
    Continue comme ça et tu 
    deviendras un vrai 
    guerrier!";
        }
        else if (wpm <= 48)
        {
            textComponent.text = @" 
    Amusante et rapide dans l'eau
    petite loutre
    mais dans la jungle la vitesse
    compte aussi sur terre!";
        }
        else if (wpm <= 52)
        {
            textComponent.text = @"
    Ah malin comme un singe!
    Mais pour défier
    les prédateurs il te faudra
    taper plus vite!";
        }
        else if (wpm <= 56)
        {
            textComponent.text = @"
    Astucieux raton!
    La jungle est vaste mais
    même toi ne peux t'arrêter
    pour nettoyer chaque touche!";
        }
        else if (wpm <= 60)
        {
            textComponent.text = @" 
    Diligent comme un castor!
    Avec un peu plus de rapidité
    tu bâtiras des records
    en un clin d'oeuil";
        }
        else if (wpm <= 64)
        {
            textComponent.text = @" 
    Ah agile lynx tes pattes
    sont prêtes mais
    sauras-tu accélérer encore pour
    rivaliser avec les meilleurs?";
        }
        else if (wpm <= 68)
        {
            textComponent.text = @" 
    Brave chèvre de montagne!
    Les rochers sont à toi
    mais les pentes glissantes
    te feront avancer encore plus 
    vite!"
    ;
        }
        else if (wpm <= 72)
        {
            textComponent.text = @"
    Gracieux cerf tu es élégant
    mais ne ralentis pas
    pour admirer la forêt
    car les loups te poursuivent!";
        }
        else if (wpm <= 76)
        {
            textComponent.text = @"
    Bravo noble loup!
    Tu cours avec puissance
    mais il te reste un dernier défi 
    pour atteindre le sommet!";
        }
        else if (wpm <= 80)
        {
            textComponent.text = @"
    Félicitations rapide comme un puma!
    Un ultime effort et
    tu seras le maître
    de la jungle";
        }
        else if (wpm <= 84)
        {
            textComponent.text = @" 
    Rapide comme l'éclair
    noble guépard!
    Bientôt aucun animal
    ne pourra te suivre!";
        }
        else if (wpm <= 88)
        {
            textComponent.text = @"
    Haut dans le ciel
    comme un aigle tu vois tout
    Mais sais-tu taper 
    plus vite que le vent?";
        }
        else if (wpm <= 92)
        {
            textComponent.text = @"
    Le faucon plonge avec précision!
    Continue et tu seras
    plus rapide que l'oeuil humain!";
        }
        else if (wpm <= 96)
        {
            textComponent.text = @" 
    Incroyable tu as la vitesse
    d'un faucon pèlerin!
    La jungle entière est à ta merci";
        }
        else if (wpm <= 100)
        {
            textComponent.text = @"
    Félicitations maître de la jungle!
    À cette vitesse même 
    les prédateurs te craignent 
    Bravo Jaguar!";
        }
    }
}
